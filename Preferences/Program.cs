using System;

namespace CSharp_Programming {
  class Program {
    static void Main (string[] args) {

      // byte , short , int , long
      // sbyte(-128 ~ 127) , ushort(0 ~ 6만) , uint(0 ~ 43억) , ulong

      // # 정수

      /*  int hp;
        short level = 100;
        hp = 100;

        byte attack = 0;
        

        Console.WriteLine ("Hello World ! {0}", hp); */

      // # 2진수 ,10진수 ,16진수

      // 10진수
      // 00 01 02 03 04 05 06 07 08 09
      // 10

      // 2진수
      // 0~1
      //  0b00 0b01 0b10 0b11 0b100  
      //  0b10001111 = 0x8F

      // 16진수
      // 0~9 a b c d e f  
      // 0x00 0x01 0x02 .. 0x0f

      /*  
      
      // 1바이트(참 / 거짓)
      bool b;
        b = true;
        b = false; */

      // 소수
      // 4바이트
      /*  float f = 3.14f;
       // 8바이트
       double d = 3.14;

       // 2바이트
       char c = '가';
       string str = "Hello World";

       Console.WriteLine(str); */

      // # 형변환

      /*
            // 1. 바구니 크기가 다른 경우
            int a = 0x0FFFFFFF;
            short b = (short) a;

            // 2. 바구니 크기는 같은데, 부호가 다른 경우
            byte c = 255;
            sbyte sb = (sbyte) c;
            // underflow, overflow
            // 0xFF = 0b11111111 = -1;

            // 3. 소수
            float f = 3.1414f;
            double d = f;
      */

      // # 논리 연산

      /*
      int hp = 100;
      int level = 50;

      bool isAlive = (hp > 0);
      bool isHighLevel = level >= 40;

      bool a = isAlive && isHighLevel;

      bool b = isAlive || isHighLevel;

      bool c = !isAlive;
      */

      // # 비트연산

      /*
      int id = 123;
      int key = 401;

      int a = id ^ key;
      int b = a ^ key;

      // << >>  &(and) |(or) ^(xor) ~(not)
      //num = num >> 1;

      Console.WriteLine (b);
      Console.WriteLine (a);
      */

      // # 할당 연산

      /*
      int a;

      a = 100;

      int b;
      b = a;

      a += 1;
      a -= 1;
      a *= 1;
      a /= 1;
      a %= 1;
      a <<= 1;
      a >>= 1;
      a &= 1;
      a |= 1;
      a ^= 1;
      */

      //var num =3;

      // var num2 = "Hello World";

    }
  }
}