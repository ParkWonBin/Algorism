using System;
using System.Runtime.InteropServices;

namespace Beakjoon_steps
{
    public class Step04
    {
        public static void P01() {
            while (true) { // 0 0 입력 받으면 종료
                string[] AB = Console.ReadLine().Split(" ");
                int A = int.Parse(AB[0]);
                int B = int.Parse(AB[1]);
                if (A == 0 && B == 0) break;
                Console.WriteLine(A + B);
            }
        }

        public static void P02() {
            while (true) { // EOF 나오면 종료
                string n = Console.ReadLine();
                if (n == null) break;
                string[] m = n.Split();
                int a = int.Parse(m[0]);
                int b = int.Parse(m[1]);
                int c = a + b;
                Console.WriteLine(c);
            }
        }

        public static void P03() {
            int n = int.Parse(Console.ReadLine()!);
            int count = 1;
            int tmp1 = n % 10 + (n - n % 10) / 10;
            int tmp = tmp1 % 10 + 10*(n % 10);
            while (tmp != n) {
                tmp = 10*(tmp % 10) + (tmp % 10 + (tmp - tmp % 10) / 10)%10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}