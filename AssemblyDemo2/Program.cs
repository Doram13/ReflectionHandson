using System;
using System.Reflection;

namespace AssemblyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";
            
            // Using BindingFlags to only get declared and instance members
          
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;


            // Load the Assembly from the path
            Assembly myAssembly = Assembly.LoadFrom(path);
            Console.WriteLine(myAssembly.FullName);

            Type[] types = myAssembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(" Type: " + type.Name);
                MemberInfo[] members = type.GetMembers(flags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine(" {0}: {1}", member.MemberType, member.Name);
                }
            }
            Console.Read();
            // It has no Types!!! WHy tho??
        }
    }
}
