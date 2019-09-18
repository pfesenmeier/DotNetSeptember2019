using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            byte mybyte = 255;
            short myshort = -30000;
            ushort myushort = 65000;
            int myint = 2000000000;
            uint myuint = 4000000000;
            ulong myulong = 18000000000000000;
            char mychar = 'a';


        }

        [TestMethod]
        public void Operators()
        {
            // + - / % *
            int num0 = 3;
            int num1 = 5;

            int sum = num0 + num1;
            int div = num0 / num1;
            int sub = num0 - num1;
            int mult = num0 * num1;
            int mod = num0 % num1;

            Console.WriteLine(sum);
            Console.WriteLine(div);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(mod);

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Lawrence";
            string lastName = "Wagner";

            //Concatanation
            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            //Composite Formatting
            string composite = string.Format("Hello my name is {0} {1}", firstName, lastName);
            Console.WriteLine(composite);

            // String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            // Classes
            // Structs

            // Collections
            List<string> myList = new List<string>();
            myList.Add("2");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello World.");
            
            //new instance made in the heap
            Dictionary<int, string> myDict = new Dictionary<int,string>();
            myDict.Add(0, "Myles Turner");

            Stack<int> newStack = new Stack<int>();

            string banana = "Fruit";
            string[] stringArray = { "Hello", "Character", "Food", "Water" };

        }
    }
}
