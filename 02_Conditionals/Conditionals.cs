using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class Conditionals
    {
        [TestMethod]
        public void IfElseStatements()
        {
            //if else if else
            int age = 42;

            if (age > 21)
            {
                Console.WriteLine("You can drink");
            }
            else
            {
                Console.WriteLine("You cannot drink");
            }
            age += 4;

            //and && or ||
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 18;
            switch (age)
            {
                case 1:
                    // code
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 18:
                    Console.WriteLine("no cases met");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            //1 condition  2 if true 3 if false
            //1  //2    //3
            //() ? true : false;
            bool statement = age > 18 ? true : false;

        }
    }
}
