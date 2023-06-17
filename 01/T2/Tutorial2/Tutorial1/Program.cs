using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
namespace Tutorial1
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the animal!");

                String animalTyped = Console.ReadLine().ToLower();

                Animal animal = null;
                switch (animalTyped)
                {
                    case "cat":
                        animal = new Cat();
                        break;
                    case "cow":
                        animal = new Cow();
                        break;
                    case "dog":
                        animal = new Dog();
                        break;
                    case "elephant":
                        animal = new Elephant();
                        break; ;
                    case "lion":
                        animal = new Lion();
                        break;
                    case "pig":
                        animal = new Pig();
                        break;
                    default:
                        Console.WriteLine($"{animalTyped}" + " Not found");
                        break;

                }
                if (animal != null)
                {
                    animal.animalSound();
                }



                Console.ReadKey();


            }
        }
    }
}
