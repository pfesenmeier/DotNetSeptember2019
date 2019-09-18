using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int students = 13;

            for(int i = 0; i < students; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < 15; i++)
            {
                students -= 1;
                Console.WriteLine(i);
                Console.WriteLine(students);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int number = 2;
            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void foreachloops()
        {
            List<string> students = new List<string>();

            students.Add("Regan");
            students.Add("Ben");
            students.Add("Aaron");
            students.Add("Newby");
            students.Add("Ian");

            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            foreach (char letter in students[0])
            {
                if (letter == 'a')
                {
                    Console.WriteLine(letter);
                }
            }

        }
    }
}
