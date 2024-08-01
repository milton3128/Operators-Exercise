namespace OperatorExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // 1. Create two integer variables.//

            int a = 17;
            int b = 4;
          

            // 2. Write out operations for add, sub, mult.//

            int sum = a + b;
         
            sum = a - b;
            sum = a * b;

            // 3. For division and modulus, create 2 more integer variables.//

            int quotient = a / b;
            int remainder = a % b;

            // 4. Write out

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.");

            Console.WriteLine($"Please enter the radius of the circle");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        ////Exercise 2////
        ///

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }
}
