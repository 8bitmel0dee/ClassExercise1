using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise1
{
    public class Product
    {
        // Properties of the product

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }

    public class CatFood : Product
    {
        // Properties of cat food products
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

    }

    public class DogLeash : Product
    {
        // Properties of dog leash products
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }

    
    
}
