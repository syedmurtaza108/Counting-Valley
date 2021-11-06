using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valley
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            
            Console.WriteLine(result);
        }

        static int countingValleys(int n, string s)
        {
            int valleys = 0;     
            int level = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U') level++;
                else
                    level--;

                if (level == 0 && s[i] == 'U')
                    valleys++;
            }
            return valleys;
        }

        int indexOfValleys(string s, int start)
        {
            
            char strt = s[start];
            if (strt == 'D')
                return start;
            else
            {
                int uCount = 0, dCount = 0;
                for (int i = start + 1; i < s.Length; i++)
                {
                    if (s[i] == 'U')
                    {
                        uCount++;
                    }
                    else
                    {
                        dCount++;
                    }
                    if (uCount == dCount)
                        return i;
                }
            }
            return -1;
        }
    }
}
