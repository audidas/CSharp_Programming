using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            // 100만
            // [~~~~~~~]

            // Key  -> Value
            // Dictionary

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            dic.Clear();

        }
    }
}
