using System;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type attrType = typeof(AssemblyDescriptionAttribute);
            object[] Attributes = currentAssembly.GetCustomAttributes(attrType, false);


            if (Attributes.Length > 0)
            {
                AssemblyDescriptionAttribute Description = (AssemblyDescriptionAttribute)Attributes[0];
                Console.WriteLine("Description: " + Description);
                Console.ReadLine();
            }
        }
    }
}
