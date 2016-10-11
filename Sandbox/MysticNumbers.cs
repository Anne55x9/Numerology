using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }


        public int TwoNumbers(int a, int b)
        {
            int result;

            if (b > a)
            {
                result = b;
            }
           else
            {
                result = a;
                if(a > b)
                {
                    result = a;
                }
            }

            return result;
        }

        public int FourNumbers(int a, int b, int c, int d)
        {
            int result;

            if (c > d)
            {
                result = c;
                if (a > c || b > c)
                {
                    result = TwoNumbers(a, b);
                }
            }
            else
            {
                result = d;
                if (a > d || b > d)
                {
                    result = TwoNumbers(a, b);
                }
            }

            return result;   
        }

        public int NewThreeNumbers(int a, int b, int c)
        {
            int result;

            if(a > c || b > c)
            {
                result = TwoNumbers(a, b);
            }
            else
            {
                result = c;
            }
            return result;
        }
        
    }
}
