using System.Collections;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var item3 = numbers[2];
            var lastitem = numbers[numbers.Length - 1];
            var lastItem = numbers[1..3];

            string[] countries = new string[5];
            countries[0] = "USA";
            countries[1] = "Canada";
            countries[2] = "Mexico";
            countries[3] = "UK";
            countries[4] = "Germany";


            // List
            List<string> cities = new List<string>();
            Console.WriteLine($"you have {cities.Count} cities");

            cities.Add("New York");
            cities.Add("Tanta");
            cities.Add("Cairo");

            Console.WriteLine($"1: {cities[1]}");

            Console.WriteLine($"you have {cities.Count} cities");

            cities.Insert(1, "Alexandria");

            Console.WriteLine($"1: {cities[1]}");

            cities.Remove("Cairo");
            cities.RemoveAt(0);

            var newites = new List<string> { "Paris", "Berlin", "Madrid" };

            cities.AddRange(newites);

            Console.WriteLine($"you have {cities.Count} cities");
            Console.WriteLine(string.Join(',', cities));

            // cities = [..cities, ..newites];

            cities.Sort();
            cities.Reverse();
            cities.Clear();
          var hasItems =   cities.Any();
          var isExist=  cities.Contains("Tanta");
         var firstIndex=   cities.IndexOf("Tanta");
          var lastIndex =   cities.LastIndexOf("Tanta");
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine($"City {i + 1}: {cities[i]}");
            }

            foreach (var city in cities)
            {
                Console.WriteLine($"City: {city}");
            }

            for (int i = 0; i < 10; i++)
            {
               cities.Add($"Tanta");
            }
            Console.WriteLine(string.Join(',', cities));


            //var citiesSet = new HashSet<string>(cities);

            //citiesSet.Add("Tanta");

            //Console.WriteLine($"uniqu cties: {string.Join(',', citiesSet)}");

            //Dictionary<int, string> countriesAndCapitals = new Dictionary<int, string>()
            //{
            //    {  1, "Cairo" }
            //};

            //countriesAndCapitals.Add(1, "Cairo");

            var translation = new Dictionary<string, string>()
            {
                { "Hello", "مرحبا" },
                { "Goodbye", "مع السلامة" },
            };

            var helloAR = translation["Hello"];
            translation["Goodbye"] = "اشوفك بكرة يا شقي";
           

            var citiesDect = new Dictionary<int, string>()
            {
                {1, "Giza" },
                {3, "Alex"  },
              {5, "Cairo" },
                
            };

            Console.WriteLine("Enter Yor city number from : ");
            foreach(var (id, name) in citiesDect)
            {
                Console.WriteLine($"{id} - {name}");
            }

            var cityId = int.Parse(Console.ReadLine() ?? "0");

            var bitArray = new BitArray(10);
            bitArray.Set(0, true);

            var bList = new List<bool>();

            Hashtable hashtable = new Hashtable();

            
            hashtable.Add("USA", "Washington, D.C.");
            hashtable.Add(2, "Ottawa");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
                
            var item = queue.Dequeue();


            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
