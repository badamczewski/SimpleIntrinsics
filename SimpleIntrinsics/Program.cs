using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SimpleIntrinsics.CommentTokenization;
using SimpleIntrinsics.ParsingAndGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleIntrinsics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classPaths = new string[]
            {
                "Docs\\sse.m",
                "Docs\\sse2.m",
                "Docs\\sse3.m",
                "Docs\\sse41.m",
                "Docs\\ssse3.m",
                "Docs\\avx.m",
                "Docs\\avx2.m"
            };

            var outputDirectory = "Intrinsics";
            Directory.CreateDirectory(outputDirectory);
            outputDirectory += Path.DirectorySeparatorChar;

            var parser = new IntrinsicDocumentParser();
            var generator = new IntrinsicGenerator();

            foreach (var classPath in classPaths)
            {
                var document = parser.ParseCSharp(classPath);
                var resultClassName = document.ClassName.ToUpper();

                var @class = generator.Generate(document.Methods, document.ClassName, resultClassName);

                File.WriteAllText(outputDirectory + resultClassName + ".cs", @class);
            }
        }
    }
}
