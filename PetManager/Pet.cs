using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + (this.Lastname != null ? this.Lastname.GetHashCode() : 0);
                hash = hash * 23 + (this.Firstname != null ? this.Firstname.GetHashCode() : 0);
                hash = hash * 23 + (this.Pets != null ? this.Pets.GetHashCode() : 0);
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pet))
            {
                return object.Equals(obj, this);
            }
            var pet = (Pet)obj;
            return Birthday.Equals(pet.Birthday) && string.Equals(this.Name, pet.Name) &&
            string.Equals(this.Breed, pet.Breed);
        }
    }
}
