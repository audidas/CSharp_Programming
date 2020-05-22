using System;
using System.Collections.Generic;

namespace OtherGrammar
{
    class Program
    {
        class Knight
        {

            // 객체지향 -> 은닉성
            public int Hp
            {
                get;
                set;
            } = 100;
        }
        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            int hp = knight.Hp;
        }
    }
}
