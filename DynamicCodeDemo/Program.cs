using System;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll";

            Assembly webAssembly = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\System.Web.dll");
            //Cannot open existing file for some reason!!!

            // Get the type to the HttpUtility class
            Type httputilType = webAssembly.GetType("System.Web.HttpUtility");

            //Get MethodInfo objects for the HtmlEncode and HtmlDecode methods by calling GetMethod on the new Type object.
            MethodInfo encode = httputilType.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo decode = httputilType.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            string toEncode = "Can we encode this: <>@#&";
            Console.WriteLine(toEncode);

            //Using the HttpEncode ’s MethodInfo object, encode your string to create a new encoded string. Write this string out to the console.
            string encodedString = (string)encode.Invoke(null, new object[] { toEncode });
            Console.WriteLine(encodedString);

            //Decode encoded string
            string decodedString = (string)decode.Invoke(null, new object[] { encodedString });
            Console.WriteLine(decodedString);
            Console.Read();

        }
    }
}
