using ClassExercise1;
using System.Text.Json;



var productLogic = new ProductLogic(); //instance

Console.WriteLine("Press 1 to add a cat food product");
Console.WriteLine("Press 2 to add a dog leash");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

CatFood catFood = new CatFood();

DogLeash dogLeash = new DogLeash();




while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {

        Console.Write("Enter cat food name: ");
        string name = Console.ReadLine();
        catFood.Name = name;

        Console.Write("Enter the price: ");

        decimal price = decimal.Parse(Console.ReadLine());
        catFood.Price = price;

        Console.Write("Enter the quantity: ");

        int quantity = int.Parse(Console.ReadLine());
        catFood.Quantity = quantity;

        Console.Write("Enter the description: ");

        string description = Console.ReadLine();
        catFood.Description = description;

        Console.Write("Enter the weight in pounds: ");

        double weight = double.Parse(Console.ReadLine());
        catFood.WeightPounds = weight;

        Console.Write("Is it kitten food? (yes/no): ");

        string kitten = Console.ReadLine();
        bool isKitten = kitten == "yes";
        catFood.KittenFood = isKitten;

        Console.WriteLine();
       
        productLogic.AddProduct(catFood);

        Console.WriteLine("Success!");
       

        


    }
    else if (userInput == "2") 
    {

        Console.Write("Enter the dog leash name: ");
        string name = Console.ReadLine();
        dogLeash.Name = name;

        Console.Write("Enter the price: ");

        decimal price = decimal.Parse(Console.ReadLine());
        dogLeash.Price = price;

        Console.Write("Enter the quantity: ");

        int quantity = int.Parse(Console.ReadLine());
        dogLeash.Quantity = quantity;

        Console.Write("Enter the description: ");

        string description = Console.ReadLine();
        dogLeash.Description = description;

        Console.Write("Enter the length in inches: ");

        int length = int.Parse(Console.ReadLine());
        dogLeash.LengthInches = length;

        Console.Write("What kind of material?");

        string material = Console.ReadLine();

        dogLeash.Material = material;

        Console.WriteLine();
      
        productLogic.AddProduct(dogLeash);
        
        Console.WriteLine("Success!");

        
     


    }

    
    //testing git connection to github after resetting PC 

   
}













