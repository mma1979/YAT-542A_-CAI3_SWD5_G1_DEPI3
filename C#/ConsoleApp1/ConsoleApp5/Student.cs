using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5;

internal class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public override string ToString()
    {
        return $"{Name}, Age: {Age}, Grade: {Grade}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age, Grade);
    }

    //public override bool Equals(object? obj)
    //{
    //    if (obj is Student other)
    //    {
    //        return Name == other.Name && Age == other.Age && Grade == other.Grade;
    //    }
    //    return false;
    //}


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");

        
    }

    public string GPA()
    {
        // Placeholder for GPA calculation logic
        return "GPA: 3.5"; // Example GPA
    }   
}
