using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            byte judges;
            double summa = 0;
            Console.Write("Enter number of judges:");
            judges = Convert.ToByte(Console.ReadLine());

            Random rand=new Random();


            if (judges < 3)
                judges = 3;
            if (judges > 10)
                judges = 10;

            Console.Write("Enter ratings (format X,X : spacebar - separator)");
            string inputString = Console.ReadLine();
            string[] ratings=inputString.Split(' ');
            
            Array.Resize<string>(ref ratings, judges);

            foreach (var item in ratings)
	        {
		         Console.WriteLine(item);
	        }

            double[] mas = new double[judges];

            for(int i=0;i<ratings.Length;i++)
            {
                double temp=Math.Round(Convert.ToDouble(ratings[i]),1);
                if(temp>10.0)
                    temp=10.0;
                if(temp<0.0)
                    temp=0.0;
                mas[i] = temp;
            }

            
            Array.Sort(mas);

            for (int i = 1; i < mas.Length - 1; i++ )
            {
                summa += mas[i];
            }

            Console.WriteLine("summa avarange:{0:f1}", summa / (mas.Length - 2));

            Console.ReadKey();
        }
    }
}
