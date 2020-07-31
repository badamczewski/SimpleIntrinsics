# Simple Intrinsics

This project aims to rename all C# intrinsic names to their more compact C/C++ counterparts that the industry uses.

![obraz](https://user-images.githubusercontent.com/752380/89054887-d3f7bd80-d359-11ea-9d99-9690d98ef50d.png)

## Why?

When reading tutorials, CPU manuals, or academic papers about fast implementations of algorithms and data structures using SIMD instructions, you will often find a different naming convention that's difficult to map to C# code. While dotnet versions have better human-readable names, they do not easily map to any material out there; this decision limits the amount of content that C# developers can use to learn about Intrinsics.

Simple Intrinsics is a tool that generates C++ names for C# intrinsics and packs them into Upper Cased versions of original classes. The classes are already pre-generated from a C# file containing the intrinsic classes (from dotnet core sources)

The generated code is under the: "Intrinsics" directory. You can take them and start using them. If you need more methods that, for some reason, are not mapped, you can grab the newest source code version of the intrinsic and generate them again.

## How?

The tool uses a CSharp parser and a custom Comment parser to create a C#/C++ signature pair.

![obraz](https://user-images.githubusercontent.com/752380/89056729-c5f76c00-d35c-11ea-878a-0a7a3547d36f.png)

This allows us to create a method with C++ semantics and alias all of the types to their native counterparts if needed (not yet done). The pairs are then fed to the code generator that uses them and a bunch of options to generate code for the renamed intrinsics.

## Drawbacks

There are a couple of things that don't yet work correctly:
* sometimes the comments will not have a valid signature since it contains some information that should be ignored by the parser.
* Take extra care when using the dotnet files since they will have more overloads that the official version of dotnet provides.
