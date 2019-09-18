using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Methods()
        {
            int sum = 2 + 2;

            // 4 pillars of OOP: APIE Abstraction, Polymorphism, Inheritance, Encapsulation
            // SOLID: singe responsibility, open-closed, Liskov, interface segregation, dependency inversion

            int sub = 2 - 2;
            int mult = 2 * 2;
            int div = 2 / 2;
            int remain = 2 % 2;


            Assert.AreEqual(sum, AddTwoNumbers());
            Console.WriteLine();
            Assert.AreEqual(5, SubtractTwoNumbers(15,20));
            
        }

        //1 = 

        public int AddTwoNumbers()
        {
            return 2 + 2;
        }

        public int SubtractTwoNumbers(int numOne, int numTwo)
        {
            int result = numTwo - numOne;
            return result;
        }

    }
}
