using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    public struct int_interval
    {
        private int left;
        private int right;
        private bool start_include;
        private bool end_include;
        private List<char> hooks;

        private void init_borders()
        {
            hooks = new List<char>();
            hooks.Add('(');
            hooks.Add(')');
            hooks.Add('[');
            hooks.Add(']');
        }
/*        public int_interval()
        {
            left = right = 0;
            start_include = false;
            end_include = false;
            hooks = new List<char>();
            hooks.Add('(');
            hooks.Add(')');
            hooks.Add('[');
            hooks.Add(']');
        }
  */      public int_interval(int l, int r)
        {
            left = l;
            right = r;
            start_include = false;
            end_include = false;
            hooks = new List<char>();
            hooks.Add('(');
            hooks.Add(')');
            hooks.Add('[');
            hooks.Add(']');
        }
        public void set_interval(int l, int r)
        {
            left = l;
            right = r;
        }
        public void set_include(bool start, bool end)
        {
            start_include = start;
            end_include = end;
        }
        public bool is_in_interval(int number)
        {
            bool lResult, rResult;
            if (start_include)
                lResult = (number >= left) ? true : false;
            else
                lResult = (number > left) ? true : false;

            if (end_include)
                rResult = (number <= right) ? true : false;
            else
                rResult = (number < right) ? true : false;

            return (lResult && rResult);
        }
        public static bool tryParse(string inString, out int_interval result)
        {
            bool start, end;
            start = end = false;
            inString.Trim();
            string[] symbols = new string[2];
            string numbers = "0123456789";

            symbols = inString.Split(',');


            //first element
            if (symbols[0].First() == '(')
                start = false;
            else if (symbols[0].First() == '[')
                start = true;
            else
            {
                result = default(int_interval);
                return false;
            }
            ///////////////////////

            //last element
            if (symbols[1].Last() == ')')
                end = false;
            else if (symbols[1].Last() == ']')
                end = true;
            else
            {
                result = default(int_interval);
                return false;
            }
            ///////////////////////

            for (int i = 1; i < symbols[0].Length;i++ )
            {
                if()
            }


                result = default(int_interval);
            return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int_interval interval;
            int_interval.tryParse("[23,45)",out interval);
        }
    }
}
