﻿using System;

namespace OOP
{
    // 참조
    class Knight
    {
        public int hp;
        public int attack;
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            System.Console.WriteLine("Int 생성자 호출!");
        }
        public Knight(int hp, int attack) : this(hp)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int , int 생성자 호출");
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

            Knight knight = new Knight(50, 50);
        }
    }
}
