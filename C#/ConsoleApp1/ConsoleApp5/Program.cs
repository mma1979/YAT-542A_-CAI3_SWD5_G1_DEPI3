namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
         {
             new Student("Alice", 20, "A"),
             new Student("Bob", 22, "B"),
             new Student("Charlie", 21, "C"),
            new Student("David", 23, "A"),
            new Student("Eve", 20, "B"),
            new Student("Frank", 22, "C"),
            new Student("Grace", 21, "A"),
            new Student("Hannah", 23, "B"),
            new Student("Ian", 20, "C"),
         };

            var hasStudents = students.Any();
            var zStudents = students.Any(s=>s.Name.StartsWith("Z"));
            
            Console.WriteLine($"Has students: {hasStudents}");
            Console.WriteLine($"Has students with names starting with 'Z': {zStudents}");


            var studentsLess23 = students
               .Where(s => s.Age < 23 && s.Name.StartsWith("A"))
               .ToList();


            Console.WriteLine("Students younger than 23:");
            foreach (var student in studentsLess23)
            {
                student.DisplayInfo();
            }


            var frank = students
                .FirstOrDefault(s => s.Name == "Frank");

            var frank2 = students
                .SingleOrDefault(s => s.Name == "Frank");

            var frank3 = students
               .First(s => s.Name == "Frank");

            var frank4 = students
                .Single(s => s.Name == "Frank");

            Console.WriteLine("Frank's info:");

            
                frank?.DisplayInfo();


            var names = students
                .Select(s => s.Name)
                .ToList();

            Console.WriteLine("Student Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            students
               .Select(s => new {s.Age, s.Name})
               .ToList()
                .ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));

            var students2 = new List<Student>
         {
             new Student("Alice", 20, "A"),
             new Student("Bobaby", 22, "B"),
             new Student("Charlie", 21, "C"),
            new Student("Davis", 23, "A"),
            new Student("Evan", 20, "B"),
            new Student("Frank", 22, "C"),
            new Student("Grant", 21, "A"),
            new Student("Hannah", 23, "B"),
            new Student("Iman", 20, "C"),
         };

            var studentsIntersection = students
                .Intersect(students2)
                .ToList();

            Console.WriteLine("Students in both lists:");
            foreach (var student in studentsIntersection)
            {
                student.DisplayInfo();
            }

            Console.WriteLine("Students Hash Codes");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - Hash Code: {student.GetHashCode()}");
            }

            Console.WriteLine("Students 2 Hash Codes");
            foreach (var student in students2)
            {
                Console.WriteLine($"{student.Name} - Hash Code: {student.GetHashCode()}");
            }


            Console.WriteLine(frank?.ToString());

            var allStudents = students
                .Union(students2)
                .ToList();  
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                student.DisplayInfo();
            }
        }
    }
}
