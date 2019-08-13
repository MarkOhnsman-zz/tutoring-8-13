using System;
using System.Collections.Generic;
using petshop.Models;

namespace petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE Order matters for all methods; hover over the method to 
            Cat wiskers = new Cat("wiskers", 4);
            Cat mittens = new Cat("mittens", 6);
            Cat snowball = new Cat("snowball", 6);
            Cat booger = new Cat("booger", 6);
            Cat peaches = new Cat("peaches", 6);



            //NOTE Creates a type Store named myStore sets it equal to a new instance of the Store class;
            Store myStore = new Store();

            myStore.Breeds["calico"].Add(wiskers);
            myStore.Breeds["calico"].Add(mittens);
            myStore.Breeds["tabby"].Add(booger);
            myStore.Breeds["tabby"].Add(peaches);
            myStore.Breeds["sphinx"].Add(snowball);

            //NOTE: Itterating over a dictionary of lists
            foreach (var breed in myStore.Breeds)
            {
                string breedLabel = breed.Key; //calico, sphinx, tabby
                List<Cat> catsOfBreed = myStore.Breeds[breedLabel];
                System.Console.Write(breedLabel + ": ");
                foreach (var cat in catsOfBreed)
                {
                    System.Console.Write(cat.Name + ", ");
                }
                System.Console.WriteLine("");
            }



            //NOTE Add == Push
            // myStore.Cats.Add(wiskers);
            // myStore.Cats.Add(mittens);
            // myStore.Cats.Add(snowball);
            // myStore.Cats.Add(booger);
            // myStore.Cats.Add(peaches);
            // myStore.Cats.Add(new Cat("Mario", 100));

            //NOTE Remove/RemoveAt == splice
            //myStore.Cats.Remove(booger);

            //NOTE Reflect back on this when you need to find an item by name and remove it on Thursday
            // Cat found = myStore.Cats.Find(c => c.Name == "Mario");
            // myStore.Cats.Remove(found);


            // System.Console.WriteLine(wiskers.Name);
            // System.Console.WriteLine(wiskers.GetAge());
            // System.Console.WriteLine(wiskers.Hungry);
            // wiskers.Feed();
            // wiskers.Feed("CatFood");
            // System.Console.WriteLine(wiskers.Hungry);






            // System.Console.WriteLine(mittens.Name);
            // System.Console.WriteLine(mittens.GetAge());
        }
    }
}
