using System;

namespace OOP
{
    // OOP(은닉성 / 상속성 / 다형성)

    class Player
    {
        protected int hp;
        protected int attack;
        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }
    class Knight : Player
    {
        public sealed override void Move()
        {
            base.Move();
            Console.WriteLine("걸어서 이동");
        }
    }

    class SuperKnight : Knight
    {
        
    }
    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            Console.WriteLine("순간이동");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
            Mage mage = player as Mage;
            if (mage != null)
            {
                mage.mp = 10;
            }
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            //EnterGame(mage);

        }
    }
}
