using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    public enum operations
    {
        Plus,
        Minus,
        Multiplication,
        Division
    }


    public delegate void Notify(float result);

    public interface ICalcObserver
    {
        void Notify(float result);
    }

    public class ConsoleObserver:ICalcObserver
    {
        public void Notify(float result)
        {
            Console.WriteLine("Calculate operation result:" + result);
        }
    }
    public class FileObserver:ICalcObserver
    {
        StreamWriter streamToFile;

        public FileObserver()
        {
            streamToFile=new StreamWriter("C:\\2.txt",true,System.Text.Encoding.Default);
        }
        public void Notify(float result)
        {
            streamToFile.Write(result);
        }     
        
        ~FileObserver()
        {
            streamToFile.Close();
        }
    }

    public class Calculator
    {
        public event Notify spam;

        private float first;
        private float second;
        private float result;
        private operations operation;
        private bool isCalc;

        public float Result { get { return result;} }
        public operations Operation { get { return operation; } set { operation = value; } }


        public bool IsCalc
        {
            get { return isCalc; }
        }
        public float First
        {
            get { return first; }
            set { first = value; }
        }
        public float Second
        {
            get { return second; }
            set { second = value; }
        }


        public Calculator() 
        {
            operation = operations.Plus;
        }
        public float Calculate()
        {
            isCalc = true;
            switch (operation)
            {
                case operations.Plus:
                    result = first + second;
                    break;
                case operations.Minus:
                    result = first - second;
                    break;
                case operations.Multiplication:
                    result = first * second;
                    break;
                case operations.Division:
                    result = first / second;
                    break;
                default:
                    isCalc = false;
                    break;
            }
            if(isCalc)
                this.spam.Invoke(result);
            else
                Console.WriteLine("Error in expression");
            return 0;
        }

    }
}
