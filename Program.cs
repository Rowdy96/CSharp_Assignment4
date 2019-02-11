using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Array = new string[] { "Boat", "house", "cat", "river", "cupboard" } ;

            List<string> objectArray = new List<string>(Array);


            Console.WriteLine("The plurals of all words:");
            for(var i=0; i<Array.Length;i++)
            {
                Console.WriteLine($"{Array[i]}s");
            }
            Console.WriteLine();
            Console.WriteLine("After replacing the 2nd word, with its synonym:");
         
            objectArray[1] = "home";

            var pairValue = from val in objectArray select val;
            foreach (var value in pairValue)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Console.WriteLine();
            objectArray.Add("college");

            Console.WriteLine($"After adding {objectArray.Last()} word,the length of the array: { objectArray.Count}");
            Console.WriteLine();
            var query = from element in objectArray where element.Length == 7 select element;
            foreach (var i in query)
            {
                Console.WriteLine($"{i} has length {i.Length}");
            }
            Console.WriteLine();

            Console.WriteLine("The Word is at 3rd position:" + objectArray.ElementAt(2));
            Console.WriteLine();

            Console.WriteLine("All the words in ascending order.");
            var oderingQuery = from element in objectArray orderby element select element;
            foreach (var o in oderingQuery)
            {
              Console.WriteLine(o);
            }


            Console.WriteLine();
            Console.WriteLine("Revese order:");
            Array.Reverse();
            for (var i = Array.Length-1; i >=0; i--) {
                Console.WriteLine(Array[i]);
            }

            Console.ReadKey();
        }
     
    }
}
