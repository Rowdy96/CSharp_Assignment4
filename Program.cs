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
            Dictionary<int, string> objectArray = new Dictionary<int, string>();
            objectArray.Add(1, "Boat");
            objectArray.Add(2, "house");
            objectArray.Add(3, "cat");
            objectArray.Add(4, "river");
            objectArray.Add(5, "cupboard");

           
            Console.WriteLine("The plurals of all words:");
            foreach (KeyValuePair<int, string> i in objectArray)
            {
                Console.WriteLine($"{i.Key} {i.Value}s");
            }

            Console.WriteLine("After replacing the 2nd word, with its synonym:");
            objectArray.Remove(2);
            objectArray.Add(2,"home");
  
            var pairValue = from val in objectArray select val;
            foreach(var value in pairValue)
            {
                Console.WriteLine(value);
            }
      
            Console.WriteLine();
            objectArray.Add(6, "college");

            Console.WriteLine($"After adding {objectArray.Values.Last()} word,the length of the array: { objectArray.Count}");
            foreach(KeyValuePair<int,string> i in objectArray)
            {
                if (i.Value.Length == 7)
                {
                    Console.WriteLine($"length of {i.Value} is: {i.Value.Length}");
                    break;
                }
            }

            Console.WriteLine("The Word in 3rd position is:"+objectArray.Values.ElementAt(2));

            Console.WriteLine("all the words in ascending order.");
            var oderingQuery = from val in objectArray orderby val.Value ascending select val;
            foreach ( var  o in oderingQuery) {
                Console.WriteLine(o);
            }
             


            Console.WriteLine("Revese order:");
            
            for (int i = objectArray.Count-1; i>=0; i--)
            {
                Console.WriteLine(objectArray.Values.ElementAt(i));
            }

            Console.ReadKey();
        }
     
    }
}
