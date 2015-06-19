using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NumberExpansion
{
    class Program
    {            
        static int count = 0;

        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = Convert.ToInt16(Console.ReadLine());

            int i = 1, max = 0, temp = 0, summ = 0; 

            while ((i/2)<=(num/2))
            {
                if(((i%2)==1) && ((num%i)==1))
                {
                    max = i;
                    temp = (num / i) - (i / 2);
                }
                if((i%2)==0 && ((num%i)*2)==i)
                {
                    max = i;
                    temp = (num / i) - (i / 2) + 1;
                }
                i++;
            }

            for (int j = temp; j < temp - 1 + max; )
                summ += j;

            Console.WriteLine(summ);
 
  //          Console.WriteLine(rect(num,1));
            Console.ReadKey();
        }
        static double rect(double num,int i)
        {                    

            if (num < 2)
                return 1;

            int first = (int) num / 2;
            int second = (int) num - first;

            Console.WriteLine("{0} {1} i:{2}", first, second, i);

            rect(first,i++);
            rect(second,i++);

            return i;
        }
    }
}
