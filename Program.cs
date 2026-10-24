using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace listinventorymanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Mango"); 
            fruits.Add("Apple");

            Console.Write("Enter fruit to search: "); 
            string oldFruit = Console.ReadLine();

            Console.Write("Enter new fruit: "); 
            string newFruit = Console.ReadLine();

            SearchAndUpdate(fruits, oldFruit, newFruit);

            Console.WriteLine("\nUpdated fruit list:");

            for (int i = 0; i < fruits.Count; i++) 
            { 
                Console.WriteLine(fruits[i]);
            }

            CountFruit(fruits, "Apple");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static void SearchAndUpdate(List<string> fruits, string oldFruit, string newFruit)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == oldFruit)
                {
                    fruits[i] = newFruit;
                    Console.WriteLine("Fruit updated successfully.");
                }
            }
           
          
        }

        private static void CountFruit(List<string> fruits, string v)
        {
            int icount = 0;

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == v)
                {
                    icount++;
                }
               
            }
            Console.WriteLine();
            Console.WriteLine(v + " occurs " + icount + " times...");




        }

     
    }
}
