using System;
using System.Reflection;

namespace Reflection_Hands_on
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";

            Assembly assembly = Assembly.LoadFile(path);
            ShowAssembly(assembly);

            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(ourAssembly);
            ShowAssembly(assembly);
            Console.ReadLine();
        }

        public static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.GlobalAssemblyCache);
            Console.WriteLine(assembly.Location);
            Console.WriteLine(assembly.ImageRuntimeVersion);
            foreach (Module method in assembly.GetModules())
            {
                Console.WriteLine(" Mod: {0}", method.Name);
            }

        }
    }
}
