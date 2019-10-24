using System;

namespace TestWoodUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myDbStudent = new Student() { 
                Name = "Brendan", Age = 46 , SomethingIDontWantToCopy = "Whatever" };

            ApiStudent apiStudent = new ApiStudent();

            WoodUtils.PropertyCopier<Student, ApiStudent>.Copy(myDbStudent, apiStudent);

            // Now, apiStudent should have name and age copied from the database object.

            Console.WriteLine(apiStudent.Name + " " + apiStudent.Age);

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SomethingIDontWantToCopy { get; set; }
    }
    class ApiStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
