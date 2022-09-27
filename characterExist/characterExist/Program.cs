using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterExist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            char value = 'a';
            Boolean result = s.Contains(value);
            Console.WriteLine(result);  
        }
    }
}
