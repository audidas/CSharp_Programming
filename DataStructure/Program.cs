using System;
using System.Collections.Generic;

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

        class Map
        {
            int[,] tiles ={
                {1,1,1,1,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,1}
            };
            public void Render()
            {
                for (int i = 0; i < tiles.GetLength(0); i++)
                {
                    for (int j = 0; j < tiles.GetLength(1); j++)
                    {
                        if (tiles[i, j] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            //배열
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            // 삽입 삭제
            list.Insert(2, 999);

            bool success = list.Remove(999);
            list.RemoveAt(0);
            list.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
