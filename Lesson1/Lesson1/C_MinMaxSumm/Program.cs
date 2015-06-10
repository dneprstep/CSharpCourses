using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MinMaxSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements,max=0,min=0;
            Console.Write("Enter number of elements:");
            elements = Convert.ToInt16(Console.ReadLine());
            if (elements < 2)
                elements = 2;
            if (elements > 200000)
                elements = 200000;

            int[] mas = new int[elements];
            Random rand = new Random();
            for (int i = 0; i < elements; i++)
            {
                mas[i] = rand.Next(-10000, 10000);
                Console.WriteLine(mas[i]);
            }

            for(int i=0;i<elements;i++)
            {
                if (i % 2 != 0 && mas[i] < mas[min])
                    min = i;
                if (i % 2 == 0 && mas[i] > mas[max])
                    max = i;
            }

            Console.WriteLine("Min:{0}, Max{1}", min, max);
            Console.WriteLine("MinElement:{0}, MaxElement:{1}", mas[min], mas[max]);

            Console.WriteLine("Summa:{0}", mas[min] + mas[max]);
            Console.ReadKey();
        }
    }
}
