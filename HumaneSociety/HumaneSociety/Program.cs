using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            ShelterDogs Dog1 = new ShelterDogs(DogBreeds.poodle);
            ShelterDogs Dog2 = new ShelterDogs(DogBreeds.retriever);
            ShelterCats Cat1 = new ShelterCats(CatBreeds.evil);
            ShelterCats Cat2 = new ShelterCats(CatBreeds.lazy);

            Dog1.name = "Fifi";
            Dog1.age = 3;

            Dog2.name = "Ginger";
            Dog2.age = 2;

            Cat1.name = "Nasty";
            Cat1.age = 47;

            Cat2.name = "Fatso";
            Cat2.age = 63; 

            Console.WriteLine("Dogs available:");
            Console.WriteLine(Dog2.name + " " + Dog2.Breed + " " + Dog2.age);
            Console.WriteLine(Dog1.name + " "  + Dog1.Breed + " " + Dog1.age);
            Console.WriteLine("Cats available:");
            Console.WriteLine(Cat1.name + " " + Cat1.Breed + " " + Cat1.age);
            Console.WriteLine(Cat2.name + " " + Cat2.Breed + " " + Cat2.age);
            Console.ReadLine();
        }
    } 
}
