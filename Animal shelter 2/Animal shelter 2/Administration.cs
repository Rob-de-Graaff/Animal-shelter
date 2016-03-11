using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    class Administration
    {
        public List<Animal> Animals;

        public Administration()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal, out string err)
        {
            err = "";
            if (animal.Name == "")
            {
                err = "Animal with this number cannot be created.";
                return false;
            }
            foreach (Animal an in Animals)
            {
                if (an.Name == animal.Name)
                {
                    err = "Animal with this name already exists.";
                    return false;
                }
            }
            if (Animals.Contains(animal))
            {
                err = "list contains animal.";
                return false;
            }
            Animals.Add(animal);
            return true;
        }
    }
}
