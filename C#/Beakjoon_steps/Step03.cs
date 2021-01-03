using System;

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
        
        
    }
}