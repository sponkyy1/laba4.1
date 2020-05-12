using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using laba4._1;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            student1.setRating(99);
            student2.setRating(75);
            student3.setRating(61);
            Console.Write("Student 1: ");
            Console.WriteLine(student1.studentRating(student1.getRating()));
            Console.Write("Student 2: ");
            Console.WriteLine(student2.studentRating(student2.getRating()));
            Console.Write("Student 3: ");
            Console.WriteLine(student3.studentRating(student3.getRating()));
        }
    }
}
