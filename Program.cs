using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 920;
            int s = 9;
            string res = "";
            int flag = 0;
            while (i != 0)
            {
                if (((i % 10) * s) > 9)
                {
                    if (flag == 0)
                    {
                        res += (((i % 10) * s) % 10);//8
                        flag = (((i % 10) * s) / 10);
                    }
                    else
                    {
                        res += ((((i % 10) * s) + flag) % 10);
                        flag = ((((i % 10) * s) + flag) / 10);
                    }
                }
                else
                {
                    if (flag == 0)
                    {
                        res += ((i % 10) * s);
                    }
                    else
                    {
                        if ((((i % 10) * s) + flag) > 9)
                        {

                            res += ((((i % 10) * s) + flag) % 10);
                            flag = ((((i % 10) * s) + flag) / 10);
                        }
                        else
                        {
                            res += (((i % 10) * s) + flag);
                        }
                    }
                }
                i /= 10;

            }

            if (flag != 0) res += flag;

            //res.Concat(res.Reverse());

            Console.WriteLine(res);
        }
    }
}
