using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Named_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValues(MiddleName: "Chandrakant", LastName: "Naik", FirstName: "Kishor");
        }

        public static void GetValues(String FirstName, String MiddleName, String LastName)
        {
            System.Console.WriteLine("{0} {1} {2}",FirstName,MiddleName,LastName);
            
        }
    }
}
