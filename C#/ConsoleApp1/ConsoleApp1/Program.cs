namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // variables

            // data types name value
            string name = "Mohamed";
            var age = 30;
            string country;
            double salary = 5000.50;
            bool isEmployed = true;
            char initial = 'M';
            decimal balance = 1000.75m;
            DateTime birthDate = new DateTime(1993, 5, 15);

            // array
            string[] hobbies = new string[] { "Reading", "Traveling", "Cooking" };
            //hobbies[0];
            int[] scores = new int[5] { 90, 85, 78, 92, 88 };

            var fNum = scores[0];
            scores[1] = 95;

            // arthmetic operations
            // + * - / %
            var num1 = 10;
            var num2 = 3;
            var sum = num1 + num2; // 13
            var difference = num1 - num2; // 7
            var product = num1 * num2; // 30
            var quotient = num1 / num2; // 3
            var remainder = num1 % num2; // 1

            // comparison operations
            // == != > < >= <=  ! = > = < =
            var isEqual = num1 == num2; // false
            var isNotEqual = num1 != num2; // true
            var isGreater = num1 > num2; // true
            var isLess = num1 < num2; // false
            var isGreaterOrEqual = num1 >= num2; // true
            var isLessOrEqual = num1 <= num2; // false


            // logical operations
            // && || !
            var condition1 = true;
            var condition2 = false;

            var andCondition = condition1 && condition2; // false
            var orCondition = condition1 || condition2; // true
            var notCondition = !condition1; // false

            // if statement
            if (age > 18 && age < 50)
            {
                Console.WriteLine("You are an adult.");

            }
            else
            {
                Console.WriteLine("You are a minor.");
            }


            if (isEmployed || salary > 5000)
            {
                Console.WriteLine("You are employed or have a high salary.");
            }
            else if (isEmployed && salary < 5000)
            {
                Console.WriteLine("You are employed but have a low salary.");
            }
            else
            {
                Console.WriteLine("You are unemployed or have a low salary.");
            }

            // switch statement
            switch (salary)
            {
                case 5000:
                    Console.WriteLine("Your salary is exactly 5000.");
                    break;

                case 6000:
                    Console.WriteLine("Your salary is 6000.");
                    break;

                default:
                    Console.WriteLine("Your salary is something else.");
                    break;
            }

            // switch expression
            var message = salary switch
            {
                5000 => "Your salary is exactly 5000.",
                6000 => "Your salary is 6000.",
                _ => "Your salary is something else."
            };


            // while loop
            int i = 5;
            while (i < 5)
            {
                Console.WriteLine($"While Loop Iteration: {i}");
                i++;
            }

            do
            {
                Console.WriteLine($"While Loop Iteration: {i}");
                i++;
            } while (i < 5);

            // for loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"For Loop Iteration: {j}");
            }

            for (int j = 0; j < hobbies.Length; j++)
            {
                Console.WriteLine($"hobbies {j + 1}: {scores[j]}");
            }


            // foreach loop
            foreach (var hobby in hobbies)
            {
                Console.WriteLine($"Hobby: {hobby}");
            }


            var obj = new Person
            {
                Name = "Mohamed",
                Age = 30,
                Country = "Egypt"
            };


            var obj2 = new Person
            {
                Name = "Mohamed",
                Age = 30,
                Country = "Egypt"
            };

            var isEqualObj = obj == obj2; // false, because they are different instances

        }
    }
}