using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using SimpleIntrinsics.CommentTokenization;
using SimpleIntrinsics.Utils;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;
using System.Linq.Expressions;

namespace SimpleIntrinsics.ParsingAndGeneration
{
    public class IntrinsicGenerator
    {
        private string pad = new string(' ', 4);

        public string Generate(IEnumerable<CSharpToIntrinsicMethod> methods, string rootClassName, string destinationClassName)
        {
            Dictionary<string, int> conflictinSignatures = new Dictionary<string, int>();

            StringBuilder classBuilder = new StringBuilder();
            classBuilder.AppendLine("using System.Runtime.CompilerServices;");
            classBuilder.AppendLine("using System.Runtime.Intrinsics;");
            classBuilder.AppendLine("using System.Runtime.Intrinsics.X86;");
            classBuilder.AppendLine();

            classBuilder.AppendLine($"public class {destinationClassName}");
            classBuilder.AppendLine("{");
            classBuilder.AppendLine();

            foreach (var method in methods)
            {
                if (string.IsNullOrWhiteSpace(method.IntrinsicSignature.Name))
                    continue;

                string args = "";
                string inputArgs = "";
                if (method.CsharpSignature.Arguments.Any())
                {
                    foreach (var arg in method.CsharpSignature.Arguments)
                    {
                        args += $"{arg.Name}, ";
                        inputArgs += $"{arg.ArgumentType} {arg.Name}, ";
                    }

                    args = args.Remove(args.Length - 2, 2);
                    inputArgs = inputArgs.Remove(inputArgs.Length - 2, 2);
                }

                //string convertedReturn = signature.ReturnType;
                //switch (signature.ReturnType)
                //{
                //    case "int": convertedReturn = "bool"; break;
                //    case "__int64": convertedReturn = "long"; break;
                //}
                
                string subClassName = 
                    rootClassName == method.CsharpSignature.ParentClass ? string.Empty : method.CsharpSignature.ParentClass;

                StringBuilder commentBuilder = new StringBuilder();
                commentBuilder.AppendLine(pad + "/// <summary>");
                commentBuilder.AppendLine(pad + $"/// {method.CsharpSignature.Name}");
                commentBuilder.AppendLine(pad + "/// </summary>");

                var methodNameWithArgs = $"{method.IntrinsicSignature.Name} ({inputArgs})";

                if(conflictinSignatures.TryGetValue(methodNameWithArgs, out var counter))
                {
                    conflictinSignatures[methodNameWithArgs] = counter + 1;
                    methodNameWithArgs = $"{method.IntrinsicSignature.Name}__{counter} ({inputArgs})";
                }
                else
                {
                    conflictinSignatures.Add(methodNameWithArgs, 1);
                }

                string inlineSignature = "[MethodImpl(MethodImplOptions.AggressiveInlining)]";
                string methodSignature = 
                    $"public static " +
                    $"{(method.CsharpSignature.IsUnsafe ? "unsafe " : string.Empty)}" +
                    $"{method.CsharpSignature.ReturnType} {methodNameWithArgs}";

                string bracketOpen = "{";

                string methodImplementation = 
                    $"{(method.CsharpSignature.ReturnType == "void" ? string.Empty : "return")} " +
                    $"{rootClassName}{(subClassName != string.Empty ? "." + subClassName : string.Empty)}.{method.CsharpSignature.Name}" +
                    $"({args});";


                string bracketClose = "}";

                classBuilder.AppendLine(commentBuilder.ToString());
                classBuilder.AppendLine(pad + inlineSignature);
                classBuilder.AppendLine(pad + methodSignature);
                classBuilder.AppendLine(pad + bracketOpen);
                classBuilder.AppendLine(pad + pad + methodImplementation);
                classBuilder.AppendLine(pad + bracketClose);

                ConsoleUtils.WriteLine(pad + inlineSignature);
                ConsoleUtils.WriteLine(pad + methodSignature);
                ConsoleUtils.WriteLine(ConsoleColor.White, pad + bracketOpen);
                ConsoleUtils.WriteLine(pad + methodImplementation);
                ConsoleUtils.WriteLine(ConsoleColor.White, pad + bracketClose);
            }

            classBuilder.AppendLine("}");

            return classBuilder.ToString();
        }
    }
}
