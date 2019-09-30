using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sside1, sside2, sside3;
            int side1, side2, side3;

            Console.Write("Enter side 1 for triangle: ");
            sside1 = Console.ReadLine();
            int.TryParse(sside1, out side1);

            Console.Write("Enter side 2 for triangle: ");
            sside2 = Console.ReadLine();
            int.TryParse(sside2, out side2);

            Console.Write("Enter side 3 for triangle: ");
            sside3 = Console.ReadLine();
            int.TryParse(sside3, out side3);
        }
    }
}
 