using System;

namespace OOP
{
    // OOP(은닉성 / 상속성 / 다형성)
    class Player // 부모 / 기반 
    {
        static public int counter = 1; // 오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;
        public void Move()
        {
            System.Console.WriteLine("Player Move");
        }
        public void Attack()
        {
            System.Console.WriteLine("Player Attack");
        }
    }

    class Mage : Player
    {

    }
    class Archer : Player
    {

    }
    class Knight : Player // 자식 / 파생
    {
        public void Stun()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Attack();
        }
    }
}
