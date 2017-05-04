using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cavidan_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqem daxil edin: ");
            int reqem = Convert.ToInt16(Console.ReadLine());
            int netice = (reqem % 2 == 0) ? netice = reqem * reqem : netice = reqem * reqem * reqem;
            Console.WriteLine("netice: {0}",netice);
            Console.ReadLine();
            
        }
    }
}
