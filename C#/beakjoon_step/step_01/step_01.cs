using System;

namespace step01
{
    class Prob_01
    {
        public void print()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Prob_02
    {
        public void print()
        {
            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("강한친구 대한육군");
            }
        }
    }

    class Prob_03
    {
        public void print()
        {
            string cat = "\\    /\\\n )  ( ')\n(  /  )\n \\(__)|";
            Console.WriteLine(cat);
        }
    }

    class Prob_04
    {
        public void print()
        {
            Console.WriteLine(@"|\_/|
|q p|   /}
( 0 )""""""\
|""^""`    |
||_/=\\__|");
        }
    }

    class Prob_05
    {
        public void print()
        {
            string[] AB = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(AB[0]) + int.Parse(AB[1]));
        }
    }
}
