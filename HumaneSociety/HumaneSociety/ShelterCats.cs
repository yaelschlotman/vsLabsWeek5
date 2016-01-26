using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class ShelterCats : ShelterAnimal
    {
        public CatBreeds Breed;
        public ShelterCats(CatBreeds b)
        {
            Breed = b;
        }

    }
}
