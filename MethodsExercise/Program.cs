namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GreetingHub(); //



            Console.WriteLine("Give me one number.");

            var numOne = Convert.ToInt32(Console.ReadLine());//changed num1 to numOne

            Console.WriteLine("give me a second number");

            var numTwo = Convert.ToInt32(Console.ReadLine());//changed num2 to numTwo

            Sum(numOne,numTwo);



            Console.WriteLine("Give me one more number");

            var numThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var numFour = Convert.ToInt32(Console.ReadLine());

            Difference(numThree, numFour);//capatilized D



            Console.WriteLine("Give me one more number");

            var numFive= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var numSix = Convert.ToInt32(Console.ReadLine());

            Divide(numFive, numSix);//Capitilized D



            Console.WriteLine("Give me one more number");

            var numSeven = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give me a second number");

            var numEight = Convert.ToInt32(Console.ReadLine());

            Multiply(numSeven, numEight);//capitilized M 

         

        }
        public static void GreetingHub()
        {
            Console.WriteLine("Hello what is your name!");

            var getName =Console.ReadLine();//i think these are correct. does the G need to be Capitilized?

            Console.WriteLine($"Hello {getName}. How old are you?");

            var getAge = Console.ReadLine();//I think these are correct. does the G need to be Capitilized?

            Console.WriteLine($"Wow {getName}. {getAge} years old is pretty old if you ask me.");
            
        }
        public static void Sum(int num1, int num2)
        {
            int add = num1 + num2; 

            Console.WriteLine($"The answer for {num1} plus {num2} is {add}");
        }


        public static void Difference(int num1, int num2)//capatilized D
        {
            double subtract = num1 - num2;// lowercased d

            Console.WriteLine($"The answer for {num1} minus {num2} is {subtract}");
        }


        public static void Multiply (int num1, int num2)// Capitilized M
        {
            double mult = num1 * num2;// lowercased d

            Console.WriteLine($"The answer for {num1} times {num2} is {mult}");
        }


        public static void Divide (int num1, int num2) //capitilized D 
        {
             double div = num1 / num2;//lowercased d in double 

            Console.WriteLine($"The answer for {num1} divided by {num2} is {div}");
        }
        


    }
}
