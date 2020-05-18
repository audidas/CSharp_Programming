using System;

namespace CSharp {

    class Flow {

        enum Choice {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main (string[] args) {
            /*
            int hp = 10;

            bool isDead = hp <= 0;

            if (isDead) {

                Console.WriteLine ("You are Dead!");
            } else {
                Console.WriteLine ("You are Alive");
            }
            */
            /*
            // # if

            int choice = 0; // 0: 가위 1: 바위 2:보 3: 치트키

            if (choice == 0) {
                Console.WriteLine ("가위 입니다");
            } else if (choice == 1) {
                Console.WriteLine ("바위 입니다");

            } else if (choice == 2) {
                console.WriteLine ("보 입니다");
            } else {
                console.WriteLine ("치트키 입니다");
            }

            // # switch

            switch (choice) {
                case 0:
                    Console.WriteLine ("가위 입니다");
                    break;
                case 1:
                    Console.WriteLine ("바위 입니다");
                    break;
                case 2:
                    Console.WriteLine ("보 입니다");
                    break;
                case 3:
                    Console.WriteLine ("치트키 입니다");
                    break;
                default:
                    Console.WriteLine ("다 실패했습니다");
                    break;
            }

            // 삼항 연산자

            int number = 25;
            bool isPair = number % 2 == 0 ? true : false;
*/

            // 가위 바위 보 게임
            // const int ROCK = 1;
            // const int PAPER = 2;
            // const int SCISSORS = 0;
            /*
            Random rand = new Random ();
            int aiChoice = rand.Next (0, 3); //0 ~ 2 사이의 랜덤 값

            int choice = Convert.ToInt32 (Console.ReadLine ());

            switch (choice) {
                case (int) Choice.Scissors:
                    Console.WriteLine ("당신의 선택은 가위 입니다.");
                    break;
                case (int) Choice.Rock:
                    Console.WriteLine ("당신의 선택은 바위 입니다.");
                    break;
                case (int) Choice.Paper:
                    Console.WriteLine ("당신의 선택은 보 입니다.");
                    break;
            }
            switch (aiChoice) {
                case (int) Choice.Scissors:
                    Console.WriteLine ("컴퓨터의 선택은 가위 입니다.");
                    break;
                case (int) Choice.Rock:
                    Console.WriteLine ("컴퓨터의 선택은 바위 입니다.");
                    break;
                case (int) Choice.Paper:
                    Console.WriteLine ("컴퓨터의 선택은 보 입니다.");
                    break;
            }

            int result = choice - aiChoice;
            // 숭라 무승부 패배
            if (result == 1 || result == -2) {
                Console.WriteLine ("당신이 이겼습니다!!");
            } else if (result == 0) {
                Console.WriteLine ("비겼습니다");
            } else {
                Console.WriteLine ("졌습니다");
            }
            */
            /*
            // while 반복문
            int count = 5;
            string answer;
            while (count > 0) {
                Console.WriteLine ("Hello World");
                count--;
            }

            do {
                Console.WriteLine ("나는 잘생겼는가 ? y/n ");
                answer = Console.ReadLine ();
            } while (answer != "y");

            */

            /*
            for (int i = 0; i < 5; i++) {
                Console.WriteLine ("Hello World");
            }
            */

            /*
            int num = 97;
            bool isPrime = true;

            for (int i = 2; i < num; i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) {
                Console.WriteLine ("소수입니다");
            } else {
                Console.WriteLine ("소수가 아닙니다");
            }
            */
            /*
            for (int i = 0; i < 100; i++) {
                if (i % 3 != 0) {
                    continue;
                }
                Console.WriteLine ($"3으로 나뉘는 숫자 발견 {i}");
            }
            */

            // int num1 = 10;
            // int num2 = 3;

            // int result1;
            // int result2;

            // Divide (num1, num2, out result1, out result2);

            // System.Console.WriteLine (result1);
            // System.Console.WriteLine (result2);
            Console.WriteLine (Factorial2 (5));
        }

        // static void HelloWorld () {
        //     Console.WriteLine ("Hello World");
        // }

        // static void Divide (int a, int b, out int result1, out int result2) {
        //     result1 = a / b;
        //     result2 = a % b;
        // }

        // static void Swap (ref int a, ref int b) {
        //     int tmp = a;
        //     a = b;
        //     b = tmp;
        // }
        // static void AddOne (ref int number) {
        //     number += 1;
        // }
        // static int AddOne2 (int number) {
        //     return number += 1;
        // }

        static void GuGuDan () {

            for (int i = 2; i < 10; i++) {

                for (int j = 1; j < 10; j++) {
                    Console.WriteLine ($"{i} * {j} = {i*j}");
                }
            }
        }

        static void Star () {
            for (int i = 0; i < 5; i++) {

                for (int j = 0; j <= i; j++) {
                    Console.Write ("*");
                }
                Console.WriteLine ();

            }
        }

        static int Factorial (int n) {
            int result = 1;

            for (int i = n; i > 0; i--) {
                result *= i;
            }
            return result;
        }

        static int Factorial2 (int n) {
            if (n <= 1) {
                return 1;
            }
            return n * Factorial2 (n - 1);
        }

    }

}