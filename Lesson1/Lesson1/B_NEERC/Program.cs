using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_NEERC
{
    
    class Program
    {
        static void Main(string[] args)
        {
            uint institutes,halls,result=0;

            Console.Write("Enter number of institutes");
            institutes = Convert.ToUInt16(Console.ReadLine());
            if (institutes > 10000)
                institutes = 10000;

            Console.Write("Enter number of halls");
            halls = Convert.ToUInt16(Console.ReadLine());
            if (halls > 10000)
                halls = 10000;

            uint[] commands = new uint[institutes];
            Random rand=new Random();
            for(int i=0;i<institutes;i++)
            {
                commands[i]=Convert.ToUInt16( rand.Next( Convert.ToUInt16(halls+halls)));
            }
            Console.WriteLine("Number of commands from institutes");
            foreach(uint i in commands)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < commands.Length; i++)
			{
                if(commands[i]>halls)
                    result+=halls;
                else
                    result+=commands[i];
			}
            Console.WriteLine("Max number of commands{0}",result);

            Console.ReadKey();
        }
    }
}
