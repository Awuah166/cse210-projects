using System;
using System.Security.Cryptography.X509Certificates;

class Name
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
    }

    public class Student : Person
    {
        private string _studentId;

        public Student(string name, string studentId, int age) : base(name, age)  
        {
            _studentId = studentId;
        }
        public string GetStudentId()
        {
            return _studentId;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alice", "S12345", 20);
            Console.WriteLine("Name: " + student.GetName());
            Console.WriteLine("Student ID: " + student.GetStudentId());
            Console.WriteLine("Age: " + student.GetAge());
        }
    }
}