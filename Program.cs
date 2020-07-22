using System;

namespace Lesson6_ClassExercise_OOP_CoffeeMug
{
    class CoffeeMug
    {
        private string color { get; set; }
        private string textColor { get; set; }
        private string phrase { get; set; }

        private int size { get; set; }

        private bool isFull { get; set; }

        // Empty contructor with no arguments
        public CoffeeMug()
        {
        }

        // Constructor with arguments
        public CoffeeMug(string whatColor, string whatTextColor, string whatPhrase, int whatSize)
        {
            this.color = whatColor;
            this.textColor = whatTextColor;
            this.phrase = whatPhrase;
            this.size = whatSize;
            this.isFull = false;
        }

        // Fill method
        public void Fill()
        {
            if (isFull == false)
            {
                Console.WriteLine("You poured coffee into " + this.phrase + ".");
                isFull = true;
            }
            else
            {
                Console.WriteLine("Coffee spills ALL OVER THE PLACE! It was already full. What were you thinking?!");
            }

        }

        // Drink method
        public void Drink()
        {
            if (isFull == true)
            {
                Console.WriteLine("You drink some coffee out of " + this.phrase + ". It tastes great!");
                isFull = false;
            }
            else
            {

                Console.WriteLine("There's no coffee in there! Fill it up first!");

            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson6_ClassExercise_OOP!");

            //CoffeeMug coffeeMug = new CoffeeMug();
            //coffeeMug.color = "red";
            //coffeeMug.textColor = "black";
            //coffeeMug.phrase = "This is my cup!";
            //coffeeMug.size = 8;
            //coffeeMug.hasHandle = true;

            CoffeeMug coffeeMug = new CoffeeMug("green", "white", "My new secure cup!", 16);

            // Call the Fill/Drink method...added by th 07072020
            coffeeMug.Fill();
            coffeeMug.Drink();
            coffeeMug.Fill();
            coffeeMug.Fill();
            coffeeMug.Fill();
            coffeeMug.Drink();
            coffeeMug.Fill();
            coffeeMug.Fill();
            coffeeMug.Fill();
            coffeeMug.Drink();
            coffeeMug.Drink();

        }
    }
}
