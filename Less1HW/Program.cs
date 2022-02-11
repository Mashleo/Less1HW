using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less1HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ВВедите количество гвоздей от 1 до 10  - ");

            int numberOfNail = int.Parse(Console.ReadLine());

            if (numberOfNail <= 0 || numberOfNail > 10)
            {
                Console.WriteLine("не выполнено условие");
            }

            else
            {
                Console.Write("Введите количесвто ударов от 1 до 5 - ");

                string hit = Console.ReadLine();

                int numberOfHit = Convert.ToInt32(hit);

                if (numberOfHit <= 0 || numberOfHit > 5)
                {
                    Console.WriteLine("Не выполнено условие");
                }
                else
                {
                    Console.WriteLine();
                    for (int i = 1; i <= numberOfNail; i++)
                    {

                        for (int j = 1; j <= numberOfHit; j++)
                        {
                            Console.Write("Удар номер " + j + "\t");

                        }
                        Console.WriteLine();
                        Console.WriteLine("Гвоздь №" + i + " забит");

                    }
                }



            }
        }
    }
}
