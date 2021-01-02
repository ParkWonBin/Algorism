using System;

namespace step_02
{
    class Prob
    {
        public void p01()
        {
            string[] AB = Console.ReadLine().Split(" ");
            int d = int.Parse(AB[0]) - int.Parse(AB[1]);
            Console.WriteLine(d < 0 ? "<" : d == 0 ? "==" : ">");
            //if (d < 0){
            //    Console.WriteLine("<");
            //}
            //else if (d == 0){
            //    Console.WriteLine("==");
            //}
            //else{
            //    Console.WriteLine(">");
            //}
        }

        public void p02()
        {
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(s>89 ? "A" : s>79 ? "B": s>69 ? "C": s>59? "D" : "F");
        }

        public void p03()
        {
            int year = int.Parse(Console.ReadLine());
            bool is_yun = false;
            if (year % 4 == 0) { is_yun = true; };
            if (year % 100 == 0) { is_yun = false; };
            if (year % 400 == 0) { is_yun = true; };

            if (is_yun) { Console.WriteLine("1"); }
            else { Console.WriteLine("0"); }
        }

        public void p04()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x > 0 ? y > 0 ? "1" : "4" : y > 0 ? "2" : "3");

        }

        public void p05()
        {
            string[] arr = Console.ReadLine().Split(" ");
            int h = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);

            m -= 45;
            if (m < 0)
            { 
                m += 60;
                h -= 1;
            }
            if (h < 0)
            {
                h += 24;
            }
            Console.WriteLine("{0} {1}", h, m);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Prob p1 = new Prob();
            //p1.p04();
            new Prob().p05();
        }
    }

}
