using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class ShelterDogs : ShelterAnimal
    {
        public DogBreeds Breed;

        public ShelterDogs(DogBreeds b)
        {
            Breed = b;
        }


    }
}
    

