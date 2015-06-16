using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_TimeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of time moment:");
            int momentNumber = Convert.ToInt16(Console.ReadLine());

            if (momentNumber < 1)
                momentNumber = 1;
            if (momentNumber > 100)
                momentNumber = 100;

            TimeSpan[] data_mas = new TimeSpan[momentNumber];

            for (int i = 0; i < data_mas.Length; i++)
            {
                Console.Write("Enter time format XX:XX:XX ");
                if (TimeSpan.TryParse(Console.ReadLine(), out data_mas[i]))
                    continue;
                else
                    Console.WriteLine("Bad Format");
            }

            Array.Sort(data_mas);

            Console.WriteLine("Sorted time");
            foreach (var item in data_mas)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
