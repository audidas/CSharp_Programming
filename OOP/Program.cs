using System;

namespace OOP
{
    class Knight
    {
        public int hp;
        public int attack;
        public void Move()
        {
            System.Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Knight Attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
        }
    }
}
