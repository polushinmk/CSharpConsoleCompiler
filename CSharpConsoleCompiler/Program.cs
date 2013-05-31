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
            //Постоянный цикл работы с пользователем до завершения приложения
            do {
                //Провайдер языка С# и его настройки
                try
                {
                    CodeDomProvider prov = CodeDomProvider.CreateProvider("CSharp");
                    CompilerParameters cp = new CompilerParameters(new string[] { "System.dll" });
                    cp.CompilerOptions = "/t:library";
                    //Объявление необходимых переменных
                    object ci, result = null;
                    string usercmd, sources;
                    CompilerResults cr = null;
                    Type tp = null;
                    MethodInfo mi = null;
                    //Логика работы
                    Console.WriteLine("Введите выражение для расчета на синтаксисе C#");
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
