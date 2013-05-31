CSharpConsoleCompiler
=====================

An interpretator of mathematics and string operators and functions with c# grammar

Instruction
===========
1) Work with integer and double values.
  For example 5 is integer, but 5.0 is double
2) Work with string
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

where usercmd is your expression. Expression may be anything, that returns type, that can be converted to object
