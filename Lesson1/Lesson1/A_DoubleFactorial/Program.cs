using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DoubleFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num;

                Console.Write("Enter number:");
                num = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("({0})!!={1}", num, DFactorial(num));            
        }

        static decimal DFactorial(decimal num)
        {                 
            decimal result = 1;
       
            if(num<0)
                return 0;

            for (int i = 0; i * 2 < num; i++)
            {
                    result *= (num - i * 2);
             }


            return result;
        }

    }
}
