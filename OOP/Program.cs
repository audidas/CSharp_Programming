using System;

namespace OOP
{
    // 참조
    class Knight
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;
        static public void Test()
        {
            Console.WriteLine(counter);
        }
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            System.Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Knight Attack");
        }
    }
    // 복사

    class Program
    {
        static void Main(string[] args)
        {
          Knight knight = Knight.CreateKnight(); // static 
          knight.Move(); // 일반
        }
    }
}
