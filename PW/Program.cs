using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AChiper aChiper = new AChiper();
            Console.WriteLine(aChiper.Encode("ABC123 XYZ"));
            BChiper bChiper = new BChiper();
            Console.WriteLine(bChiper.Encode("ABC123 XYZ"));
            Console.ReadKey();
        }
    }
}
