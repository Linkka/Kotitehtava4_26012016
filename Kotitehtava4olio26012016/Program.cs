using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava4olio26012016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();

            // add persons to list
            humans.Add(new Human { Name = "Sami", Age = 20, Height = 171 });
            humans.Add(new Human { Name = "Vera", Age = 18, Height = 162 });

            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog { Name = "Cookie", Age = 0, Breed = "Huskymix" });
            dogs.Add(new Dog { Name = "Vilma", Age = 5, Breed = "Mix" });

            // loop through all the persons
            foreach (Human human in humans)
            {
                Console.WriteLine(human.ToString());
            }

            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.ToString());
            }





            // do something methods
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
