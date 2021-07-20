using System;
using System.Collections.Generic;

namespace WosCollections
{
    class Program
    {
        static void Main(string[] args)
        {
                CollectionsQuestions();
        }

        static void CollectionsQuestions()
        {
            int[] nums = {0,1,2,3,4,5,6,7,8,9};
            
            // array of names
            string[] names = {"Tim", "Martin", "Sara"};

            // 10 true false
            bool[] alternate = {true, false, true, false, true, false, true, false, true, false};

             // make the list
            List<string> flavors = new List<string>();
            // add 5 flavors to it
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("strawberry");
            flavors.Add("mint");
            flavors.Add("rocky road");
            // out put the list length
            Console.WriteLine($"We have {flavors.Count} ice cream flavors");    
            // output 3rd flavor and remove the value
            Console.WriteLine(flavors[2]);
            flavors.Remove("strawberry");
            Console.WriteLine($"Now we have {flavors.Count} flavors");
            
            


            // makes dictionary for users
            Dictionary<string, string> users =  new Dictionary<string, string>();
            // gets random num from 0-4
            Random rand = new Random();
            int randomFlavor = rand.Next(0,4);
            
            users.Add(names[0], flavors[randomFlavor]);
            users.Add(names[1], flavors[randomFlavor]);
            users.Add(names[2], flavors[randomFlavor]);

            // loop through dictionary
            foreach (var entry in users)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }

       

    


    }
}
