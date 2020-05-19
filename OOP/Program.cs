﻿using System;

namespace OOP
{
    // 참조
    class Knight
    {
        public int hp;
        public int attack;
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
    struct Mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage = new Mage();
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;
            // KillKnight(knight);

            Knight knight2 = knight.Clone();
            knight2.hp = 0;

        }
    }
}
