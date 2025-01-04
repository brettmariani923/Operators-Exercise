namespace OperatorExercise
{
    public class Program
    {
        static double AreaOfCircle(double radius)
        {
          return Math.PI * Math.Pow(radius, 2);
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            Console.WriteLine("What is the radius of your circle?");

            double userInput = double.Parse(Console.ReadLine());

            double solution = AreaOfCircle(userInput);

            Console.WriteLine($"The area of a circle with radius of {userInput} is {solution}");

        }
    }
}
