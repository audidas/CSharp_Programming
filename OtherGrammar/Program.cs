using System;
using System.Collections.Generic;

namespace OtherGrammar
{
    class Program
    {
        class MyList<T> where T : Monster
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();
        }
    }
}
