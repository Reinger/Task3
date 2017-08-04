using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static double ReadDouble(string S)
        {
            double X;
            bool ok;
            do
            {
                Console.Write(S);
                ok = Double.TryParse(Console.ReadLine(), out X);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода. Необходимо ввести действительное число. Нажмите любую кнопку и повторите ввод.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);

            Console.Clear();
            return X;
        }

        static void Main(string[] args)
        {
            double X = ReadDouble("X="), Y = ReadDouble("Y=");
        }
    }
}
