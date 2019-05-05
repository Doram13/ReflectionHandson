using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Assembly Name
            AssemblyName myName = new AssemblyName();
            myName.Name = "DemoAssembly";
            myName.Version = new Version("1.0.0.0");

            // Get the AppDomain to put our assembly in

            AppDomain currentAppDomain = AppDomain.CurrentDomain;

            // Create the Assembly
            AssemblyBuilder assemBldr = currentAppDomain.DefineDynamicAssembly(myName, AssemblyBuilderAccess.ReflectionOnly);

            // Define a module to hold our type
            ModuleBuilder modBldr = assemBldr.DefineDynamicModule("CodeModule", "DemoAssembly.dll");

            // Create a new type
            TypeBuilder animalBldr = modBldr.DefineType("Animal", TypeAttributes.Public);

            Type animal = animalBldr.CreateType();
            Console.WriteLine(animal.FullName);

            foreach (MemberInfo info in animal.GetMembers())
            {
                Console.WriteLine(" Member ({0}): {1}", info.MemberType, info.Name);
            }

            Console.Read();

        }
    }
}
