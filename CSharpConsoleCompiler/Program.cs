using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace CSharpConsoleCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write an expression, using C# syntax:");
            //Infinite cycle
            do {
                try
                {
                    //Provider of c# compiler and his options
                    CodeDomProvider prov = CodeDomProvider.CreateProvider("CSharp");
                    CompilerParameters cp = new CompilerParameters(new string[] { "System.dll" });
                    cp.CompilerOptions = "/t:library";
                    //Declaration of required variables
                    object ci, result = null;
                    string usercmd, sources;
                    CompilerResults cr = null;
                    Type tp = null;
                    MethodInfo mi = null;
                    //The main program
                    Console.Write("> ");
                    usercmd = Console.ReadLine();
                    sources = "using System; using System.Text; namespace Samples{class Program{public object MyMethod(){return (" + usercmd + ");} }}";
                    cr = prov.CompileAssemblyFromSource(cp, sources);
                    tp = cr.CompiledAssembly.GetType("Samples.Program");
                    mi = tp.GetMethod("MyMethod");
                    ci = Activator.CreateInstance(tp, null);
                    result = mi.Invoke(ci, null);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oooops! It seems like error. Information: {0}", e.Message);
                    continue;
                }

            } while (true);
        }
    }
}
