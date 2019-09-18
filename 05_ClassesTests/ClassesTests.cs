using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_Classes;


namespace _05_ClassesTests
{
    [TestClass]
    public class ClassesTests
    {
        
        [TestMethod]
        public void CookieVoid()
        {
            //"new" is for class
            Cookie cookie0 = new Cookie();
            cookie0.GetType();
            cookie0.BatchSize = 42;
            cookie0.Direction = "Mix and bake.";
            cookie0.Name = "Snicker Doodle";
            cookie0.Shape = "round";
            cookie0.Size = "3 oz";

            Cookie cookie1 = new Cookie();
            cookie1.Name = "Sea Salt Chocolate Chip";

            Cookie cookie2 = new Cookie("Confetti", "Sugar, sprinkles","4 oz", "19 minutes at 250F", "circle", 42);

        }

        [TestMethod]
        public void Vehicle()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "Honda";
        }

    }
}
