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


            if (c > TwoNumbers(a, b))
            {
                result = c;
            }
            else
            {
                result = d;
                if(d > TwoNumbers(a,b))
                {
                    result = d;
                }       
            }
            return result;       
        }
    }
}
