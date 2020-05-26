using System;
using System.Collections.Generic;

namespace OtherGrammar
{
    class Program
    {
        class TestException : Exception
        {

        }
        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 다른
                // 2. 잘못된 메모리를 참조 (null)
                // 3. 오버플로우
                // int a = 10;
                // int b = 0;
                // int result = a / b;

                // int c = 0;

                throw new TestException();
            }
            catch (DivideByZeroException e)
            {

            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }

    }
}
