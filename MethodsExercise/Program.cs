namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int mult = Multiply(2, 5);
            Console.WriteLine(mult);

            int div = Divide(4, 2);
            Console.WriteLine(div);

            int result = Sum(5, 4, 3, 2, 1);
            Console.WriteLine(result);
        }

        public static void MadLib()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("How fast can you drive mph?");
            string speed = Console.ReadLine();
            Console.WriteLine(speed);

            Console.WriteLine("What is your favorite city");
            string city = Console.ReadLine();
            Console.WriteLine(city);

            Console.WriteLine("What is your worst fear?");
            string fear = Console.ReadLine();
            Console.WriteLine(fear);

            Console.WriteLine($"Hello {name}! Your fastest speed is {speed} above highway limits, nice. Your favorite city is {city}, but your worst fear is {fear}!");


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
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum; 
        }
    }

}