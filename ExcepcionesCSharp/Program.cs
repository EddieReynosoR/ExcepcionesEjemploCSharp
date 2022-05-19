using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa el numero 1: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa el numero 2: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine(n1 / n2);
                Console.ReadKey();
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
