using System;

namespace Beakjoon_steps
{
    public class Step02
    {
        public static void P01() {
            string[] AB = Console.ReadLine()!.Split(" ");
            int d = int.Parse(AB[0]) - int.Parse(AB[1]);
            Console.WriteLine(d < 0 ? "<" : d == 0 ? "==" : ">");
        }

        public static void P02() {
            int s = int.Parse(Console.ReadLine()!);
            Console.WriteLine(s > 89 ? "A" : s > 79 ? "B" : s > 69 ? "C" : s > 59 ? "D" : "F");
        }

        public static void P03() {
            int year = int.Parse(Console.ReadLine()!);
            bool is_yun = year % 4 == 0;
            
            if (year % 100 == 0) {
                is_yun = false;
            }
            
            if (year % 400 == 0) {
                is_yun = true;
            }
            
            Console.WriteLine(is_yun ? "1" : "0");
        }

        public static void P04() {
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            Console.WriteLine(x > 0 ? y > 0 ? "1" : "4" : y > 0 ? "2" : "3");
        }

        public static void P05() {
            string[] arr = Console.ReadLine()!.Split(" ");
            int h = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);

            m -= 45;
            if (m < 0) {
                m += 60;
                h -= 1;
            }

            if (h < 0) {
                h += 24;
            }
            Console.WriteLine("{0} {1}", h, m);
        }
    }
}