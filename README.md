CSharpConsoleCompiler
=====================

An interpretator of mathematics and string operators and functions with c# grammar

Instruction
===========
1. Work with integer and double values.
  For example 5 is integer, but 5.0 is floating number
2. Work with string
  For example this text is not string for C# compiler, but "this text is string and you can use a string methods for it such as .ToUpper()".ToUpper()

How does it works
=================

This program use CodeDomProvider class to compile the source code, which builds from this sources
    using System;

    using System.Text;

    namespace Samples {

      class Program {

        public object MyMethod() {

        return usercmd;

        }

      }

    }

where usercmd is your expression. Expression may be anything, that returns type, that can be converted to object.

After this, program uses reflection to invoke the MyMethod with your expression and print the result.

So, if you try to send this expression: "1+Math.Pow(2,2)" you will get 5.

This program can help you to compute hard mathmatics expressions or do some basic work, without open and create a solution for Visual Studio and compile it

Program has written with .NET Framework 2.0 in Visual Studio 2012 at Windows 8 Pro
