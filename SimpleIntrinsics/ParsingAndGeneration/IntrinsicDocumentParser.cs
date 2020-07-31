using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using SimpleIntrinsics.CommentTokenization;

namespace SimpleIntrinsics.ParsingAndGeneration
{
    public class IntrinsicDocumentParser
    {
        public IntrinsicDocument ParseCSharp(string file)
        {
            List<CSharpToIntrinsicMethod> methods = new List<CSharpToIntrinsicMethod>();
            var result = new IntrinsicDocument();
            result.Methods = methods;

            //
            // Use the CSharp AST parser and find methods with comments.
            //
            var ast = CSharpSyntaxTree.ParseText(File.ReadAllText(file));
            var root = ast.GetRoot();
            var nodes = root.DescendantNodes();

            foreach (var node in nodes)
            {
                var kind = node.Kind();

                //
                // 1. Look for methods that contain comments.
                // 2. Look for a class at the begining of a file,
                // this class should be the name of the Intrinsics class, we shall
                // use it later to generate a propper clas name.
                //
                if (kind == SyntaxKind.MethodDeclaration)
                {
                    MethodDeclarationSyntax methodDeclarationSyntax = (MethodDeclarationSyntax)node;

                    //
                    // Look for documentation type comments.
                    //
                    var trivia = node.GetLeadingTrivia();
                    var comment = trivia.FirstOrDefault(x =>
                        x.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia
                    );

                    if (comment != null)
                    {
                        var commentText = comment.ToString();

                        if (string.IsNullOrWhiteSpace(commentText) == false)
                        {
                            //
                            // Parse CSharp Method, and the comment method signature.
                            //
                            CSharpToIntrinsicMethod intrinsicMap = new CSharpToIntrinsicMethod();
                            intrinsicMap.CsharpSignature = ParseCsharpMethodSignature(methodDeclarationSyntax);
                            intrinsicMap.IntrinsicSignature = ParseCommentAndCreateMethodSignature(commentText);

                            methods.Add(intrinsicMap);
                        }
                    }
                }
                else if (kind == SyntaxKind.ClassDeclaration)
                {
                    if (result.ClassName == null)
                    {
                        result.ClassName = ((ClassDeclarationSyntax)node).Identifier.ToString();
                    }
                }
            }

            return result;
        }

        private MethodSignature ParseCsharpMethodSignature(MethodDeclarationSyntax method)
        {
            List<ArgumentSignature> arguments = new List<ArgumentSignature>();
            MethodSignature signature = new MethodSignature();
            signature.Name = method.Identifier.Text;
            signature.ReturnType = method.ReturnType.ToString();
            signature.ParentClass = ((ClassDeclarationSyntax)method.Parent).Identifier.ToString();
            signature.Arguments = arguments;

            //
            // Find if the method needs to be unsafe since it may contain pointer arguments
            // or pointer based returns.
            //
            foreach (var modifier in method.Modifiers)
            {
                if (modifier.ToString() == "unsafe")
                {
                    signature.IsUnsafe = true;
                    break;
                }
            }

            foreach (var parameter in method.ParameterList.Parameters)
            {
                arguments.Add(new ArgumentSignature()
                {
                    Name = parameter.Identifier.Text,
                    ArgumentType = parameter.Type.ToString()
                });
            }

            signature.Arguments = arguments;

            return signature;
        }

        private MethodSignature ParseCommentAndCreateMethodSignature(string comment)
        {
            Tokenizer tokenizer = new Tokenizer();
            //
            // The comment is split into multiple signatures one of them beeing a C++ signature
            // we shall parse this signature.
            //
            // BUG TODO: Sometimes this might not be true so we should actually parse everything 
            // and split the signatures ourselvs.
            //
            var parts = comment.Split(Environment.NewLine);
            var tokens = tokenizer.Tokenize(parts[1]);

            List<ArgumentSignature> arguments = new List<ArgumentSignature>();
            MethodSignature result = new MethodSignature();
            result.ReturnType = "void";
            result.Arguments = arguments;

            //
            // Tokenize the C++ method signature.
            //
            MethodState state = MethodState.Return;
            ArgumentSignature argumentSignature = null;
            foreach (var token in tokens)
            {
                if (token.TokenName == "Comment")
                    continue;

                if (token.TokenName == "Word" && state == MethodState.Return)
                {
                    result.ReturnType = token.GetValue();
                    state++;
                }
                else if (token.TokenName == "Word" && state == MethodState.Method)
                {
                    result.Name = token.GetValue();
                    state++;
                }
                else if (token.TokenName == "BracketOpen" && state == MethodState.ArgumentsStart)
                {
                    state++;
                }
                else if (token.TokenName == "Word" && state == MethodState.ArgumentType)
                {
                    argumentSignature = new ArgumentSignature() { ArgumentType = token.GetValue() };
                    state++;
                }
                else if (token.TokenName == "Word" && state == MethodState.ArgumentName)
                {
                    argumentSignature.Name = token.GetValue();
                    arguments.Add(argumentSignature);

                    state--;
                }
                else if (token.TokenName == "BracketClose" &&
                    (state == MethodState.ArgumentsEnd ||
                     state == MethodState.ArgumentType ||
                     state == MethodState.ArgumentName))
                {
                    state++;
                }
            }

            return result;
        }

        public enum MethodState : int
        {
            Return,
            Method,
            ArgumentsStart,
            ArgumentType,
            ArgumentName,
            ArgumentsEnd
        }
    }
}
