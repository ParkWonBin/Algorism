using System;
using System.Text;

namespace Beakjoon_steps
{
    public class Step03
    {
        public static void P01() {
            // 백준 2739 번 문제
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 9; i++) {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        public static void P02() {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++) {
                string[] arr = Console.ReadLine().Split(" ");
                Console.WriteLine(int.Parse(arr[0]) + int.Parse(arr[1]));
            }
        }

        public static void P03() {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        
        public static void P04() {
            // string builder를 쓰지 않으면 시간초과 or 메모리 초과 생김
            int T = Int32.Parse(Console.ReadLine()!);
            string result = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < T; i++) {
                string[] arr = Console.ReadLine()!.Split();
                sb.Append($"{Int32.Parse(arr[0]) + Int32.Parse(arr[1])}\n");
            }
            Console.Write(sb.ToString());
        }

        public static void P05() {
            int n = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 1; i <= n; i++) {
                sb.Append(i.ToString() +"\n");
            }
            Console.WriteLine(sb);
        }
        
    }
}