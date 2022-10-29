using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module3_2_1_lab_Conscl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

#region calculator
        static void Calculator()
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Console Calculator");
            Console.WriteLine(' ');
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Select the arithmetic operation:
                        1. Multiplication 
                        2. Divide 
                        3. Addition 
                        4. Subtraction
                        ");
            Console.ForegroundColor = ConsoleColor.Red;
            string q = Console.ReadLine();
            int a, b;
            Console.WriteLine(' ');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type the first value");
            Console.ForegroundColor = ConsoleColor.Red;
            a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type the second value");
            Console.ForegroundColor = ConsoleColor.Red;
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(' ');
            if (q == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of the multiplication = {0}", proxy.Mul(a, b));
            }
            if (q == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of the  division = {0}", proxy.Div(a, b));
            }
            if (q == "3")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of the  addition  = {0}", proxy.add(a, b));
            }
            if (q == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of the subtraction = {0}", proxy.Sub(a, b));
            }

        }
        #endregion
    }
}
