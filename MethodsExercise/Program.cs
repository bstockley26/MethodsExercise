namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GreetingHub(); //



            Console.WriteLine("Give me one number.");

            var FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var SecondNumber = Convert.ToInt32(Console.ReadLine());

            Sum(FirstNumber,SecondNumber);



            Console.WriteLine("Give me one more number");

            var num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var num4 = Convert.ToInt32(Console.ReadLine());

            difference(num3, num4);



            Console.WriteLine("Give me one more number");

            var num5= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var num6 = Convert.ToInt32(Console.ReadLine());

            divide(num5, num6);



            Console.WriteLine("Give me one more number");

            var num7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var num8 = Convert.ToInt32(Console.ReadLine());

            multiply(num7, num8);

         

        }
        public static void GreetingHub()
        {
            Console.WriteLine("Hello what is your name!");

            var GetName =Console.ReadLine();

            Console.WriteLine($"Hello {GetName}. How old are you?");

            var GetAge = Console.ReadLine();

            Console.WriteLine($"Wow {GetName}. {GetAge} years old is pretty old if you ask me.");
  
        }
        public static void Sum(int num1, int num2)
        {
            int Add = num1 + num2;

            Console.WriteLine($"The answer for {num1} plus {num2} is {Add}");
        }


        public static void difference(int num1, int num2)
        {
            Double Subtract = num1 - num2;

            Console.WriteLine($"The answer for {num1} minus {num2} is {Subtract}");
        }


        public static void multiply (int num1, int num2)
        {
            Double mult = num1 * num2;

            Console.WriteLine($"The answer for {num1} times {num2} is {mult}");
        }


        public static void divide (int num1, int num2)
        {
            Double div = num1 / num2;

            Console.WriteLine($"The answer for {num1} divided by {num2} is {div}");
        }
        


    }
}
