using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            // Check if the name is not null or empty
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name must be provide");

                return; // Exit the program if name is not provided
            }
            
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            var isNumber = int.TryParse(ageInput, out var age);
            if(!isNumber)
            {
                Console.WriteLine("age must be number");

                return;
            }

            Console.WriteLine($"Welcome {name}, you are {age} years old");

            Console.WriteLine("Enter your Salary: ");
            string salaryInput = Console.ReadLine();

            var isSalaryNumber = float.TryParse(salaryInput, out var salary);

            var message = salary switch
            {
                5000 => "Your salary is exactly 5000.",
                6000 => "Your salary is 6000.",
                _ => "Your salary is something else."
            };

            Console.WriteLine(message);
        }
    }
}
