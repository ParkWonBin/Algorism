using System;

namespace Beakjoon_steps
{
    public class Step01
    {
        public static void P01() {
            Console.WriteLine("Hello World!");
        }

        public static void P02() {
            for (int i = 0; i < 2; i++) {
                Console.WriteLine("강한친구 대한육군");
            }
        }

        public static void P03() {
            string cat = "\\    /\\\n )  ( ')\n(  /  )\n \\(__)|";
            Console.WriteLine(cat);
        }

        public static void P04() {
            Console.WriteLine(@"|\_/|
|q p|   /}
( 0 )""""""\
|""^""`    |
||_/=\\__|");
        }

        public static void P05() {
            string[] ab = Console.ReadLine()!.Split(' ');
            Console.WriteLine(int.Parse(ab[0]) + int.Parse(ab[1]));
        }
    }
}