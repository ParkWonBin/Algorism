using System;

namespace Beakjoon_steps {
    class Program {
        static void Main(string[] args) {
            /*
            RunStep01();
            RunStep02();
            RunStep03();
            */
            Step04.P03();
        }

        // 파일 입출력 
        static void RunStep01() {
            Step01.P01();
            Step01.P02();
            Step01.P03();
            Step01.P04();
            Step01.P05(); // ' ' 구분 숫자 2개 입력
        }

        // if 문
        static void RunStep02() {
            // ' ' 구분 숫자 2개 입력
            Step02.P01();
            Step02.P02();
            Step02.P03();
            Step02.P04();
            Console.WriteLine("공백 구분 숫자 2개 입력 바람");
            Step02.P05();
        }

        // for 문
        static void RunStep03() {
            Step03.P01();
            Step03.P02();
            Step03.P03();
            Step03.P04();
            Step03.P05();
        }

        // while 문
        static void Runstep04() {
            Step04.P01(); // 0 0 나오면 종료
            Step04.P02(); // EDF 나오면 종료
            Step04.P03(); // EDF 나오면 종료

        }
    }
}