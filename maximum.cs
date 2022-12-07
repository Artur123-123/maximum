using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zamienianie_liczb
{
    internal class Program
    {
        class Liczby
        {
            public static int[] nums = {1, 2, 3, 4, 5};

            public void Elementy()
            {
                int tdl = nums.Length / 2;
                int skladzik;
                for (int i = 0; i < tdl; i++)
                {
                    skladzik = nums[i];
                    nums[i] = nums[nums.Length - 1 - i];
                    nums[nums.Length - 1 - i] = skladzik;
                }
            }

            public int Wypisywanie()
            {
                foreach(int i in nums)
                {
                    Console.WriteLine(i);
                }
                return 0;
            }

            public int Max()
            {
                int maximum = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > maximum)
                    {
                        maximum = nums[i];
                        //int tab = nums[nums.Length - 1] + maximum;
                    }
                    
                }
                return maximum;
            }

            public int AllMax()
            {
                int maximum = Max();
                for(int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i] = maximum);
                }
                return maximum;
            }
        }
        static void Main(string[] args)
        {
            Liczby liczba = new Liczby();
            //liczba.Elementy();
            liczba.Wypisywanie();
            //Console.WriteLine(liczba.Max());
            liczba.AllMax();
        }
    }
}
