using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Режимы: Сложение +, вычитание -, умножить *, разделить /");
            string X = Convert.ToString(Console.ReadLine());
            string Plus;
            string Minus;
            string Umn;
            string Razd;

            if(X == "+")
            {
                int C = A + B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "-")
            {
                int C = A - B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "*")
            {
                int C = A * B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "/")
            {
                int C = A / B;
                Console.WriteLine("Ответ: " + C);
            }

            Console.ReadKey();


            


        }
    }
}
