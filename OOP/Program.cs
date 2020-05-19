using System;

namespace OOP
{
    // OOP(은닉성 / 상속성 / 다형성)

    // 자동차
    // 핸들 페달 차문
    // 전기장치 엔진 기름 <-> 외부 노출

    class Knight
    {
        // 접근 한정자
        // public protected private
        public int hp;
    }
    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
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
