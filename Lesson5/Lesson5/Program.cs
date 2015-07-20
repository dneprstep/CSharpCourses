using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleObserver observerConsole = new ConsoleObserver();
            FileObserver observerFile = new FileObserver();

            Calculator calc = new Calculator();
            calc.spam += new Notify(observerConsole.Notify);
            calc.spam += new Notify(observerFile.Notify);

            calc.First = 45;
            calc.Second = 56;
            calc.Operation = operations.Multiplication;
            calc.Calculate();

        }
    }
}
