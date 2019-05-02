using System;
using System.Reflection;

namespace Reflection_Hands_on
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAssembly(new Assembly());
            Console.ReadLine();
        }

        public static void ShowAssembly(Assembly assembly)
        {

            Type ClassType = assembly.GetType();
            
            Console.WriteLine(ClassType.AssemblyQualifiedName);
            Console.WriteLine(ClassType.FullName);
            Console.WriteLine(ClassType.Assembly.GlobalAssemblyCache);
            Console.WriteLine(ClassType.Assembly.Location);
            Console.WriteLine(ClassType.Assembly.ImageRuntimeVersion);

        }
    }
}
