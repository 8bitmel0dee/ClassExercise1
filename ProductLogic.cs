using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise1
{

    public class ProductLogic
        {
            // Private list of products
            private List<Product> _products;

            // Private dictionary - dog leashes
            private Dictionary<string, DogLeash> _dogLeashes;

            // Private dictionary - cat food
            private Dictionary<string, CatFood> _catFoods;


            // Constructor
            public ProductLogic()
            {
                // Instance List - Products
                _products = new List<Product>();

                // Instance Dictionary - DogLeashes
                _dogLeashes = new Dictionary<string, DogLeash>();

                // Instance Dictionary - CatFood
                _catFoods = new Dictionary<string, CatFood>();
            }

            // AddProduct method
            public void AddProduct(Product product)
            {
                // Check if the product is a dog leash

                if (product is DogLeash)
                {
                    // Convert product
                    DogLeash dogLeash = product as DogLeash;

                    // Add the dog leash to the dictionary
                    _dogLeashes.Add(dogLeash.Name, dogLeash);
                }

                else if (product is CatFood)
                {
                    CatFood catFood = product as CatFood;

                    _catFoods.Add(catFood.Name, catFood);
                }
                else
                {
                    _products.Add(product);

                }

            }

            // GetAll Method that returns the products
            public List<Product> GetAllProducts()
            {
                return _products;
            }

            //
            public DogLeash GetDogLeashByName(string name)
            {
                if (_dogLeashes.ContainsKey(name))
                {
                    return _dogLeashes[name];
                }
                else
                {
                    return null;
                }


            }
        }
}
