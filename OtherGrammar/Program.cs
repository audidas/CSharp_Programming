using System;
using System.Collections.Generic;
using System.Reflection;

namespace OtherGrammar
{
    class Program
    {

        static Monster FindMonster(int id)
        {
            // for()
            // return monster;
            return null;
        }

        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {
            Monster monster = null;
            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id;
            if (monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.Id;
            }

            // Nullable -> Null + able
            int? number = null;

            int b = number ?? 5;
            Console.WriteLine(b);
            number = 5;
            if (number != null)
            {
                int a = number.Value;
                System.Console.WriteLine(a);

            }

            if (number.HasValue)
            {
                int a = number.Value;
                System.Console.WriteLine(a);

            }
        }

    }
}
