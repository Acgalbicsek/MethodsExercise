using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("Hello, What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite late night snack?");
            string lateNightSnack = Console.ReadLine();
            Console.WriteLine("What is your Favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band or singer?");
            string favoriteMusic = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {userName} was sled riding when he came across a {favoriteAnimal} with a {faveColor} mohawk," +
                $" head banging to {favoriteMusic}.  {userName} stopped and split some {lateNightSnack} with the {favoriteAnimal} and then said goodbye.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
            
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int Sum = 0;

            foreach (int number in numbers)
            {
                Sum += number;

                
            }
            return Sum;
        }
            
        


        
        public static void Main(string[] args)
        {
           // MadLib();
        //Console.WriteLine(Add(2,2));
        //Console.WriteLine(Subtract(10, 5));
        //Console.WriteLine(Multiply(10, 5));
        //Console.WriteLine(Divide(10, 5));

        Console.WriteLine(Sum( 5, 5, 5, 5, 5, 5));

             
        }

        
    }
}
