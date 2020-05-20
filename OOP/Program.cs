using System;

namespace OOP
{
    // OOP(은닉성 / 상속성 / 다형성)

    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {

    }
    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
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

            EnterGame(mage);

        }
    }
}
