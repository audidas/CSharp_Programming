using System;

namespace DataStructure
{
    class Player
    {

    }
    class Moster
    {

    }
    class Program
    {

        static int GetHighestScore(int[] scores)
        {
            if (scores.Length < 1)
            {
                return 0;
            }
            else
            {
                int high = 0;
                foreach (int score in scores)
                {
                    if (score > high)
                    {
                        high = score;
                    }
                }
                return high;
            }

        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length < 1)
            {
                return 0;
            }
            else
            {
                int avg = 0;
                foreach (int score in scores)
                {
                    avg += score;
                }
                return avg / scores.Length;
            }

        }

        static int GetIndexOf(int[] scores, int value)
        {
            if (scores.Length < 1)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    if (scores[i] == value)
                    {
                        return i;
                    }
                }
                return -1;
            }

        }

        static int[] Sort(int[] scores)
        {
            if (scores.Length < 1)
            {
                return null;
            }
            int temp = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        temp = scores[j];
                        scores[j] = scores[i];
                        scores[i] = temp;
                    }
                }
            }
            return scores;

        }
        static void Main(string[] args)
        {
            //배열
            int[] scores = new int[7] { 10, 10, 30, 30, 10,27,5 };

            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 12));

            int[] scores2 = Sort(scores);

            foreach (int score in scores2)
            {
                Console.WriteLine(score);
            }
        }
    }
}
