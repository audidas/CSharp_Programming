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

        }

    }

}