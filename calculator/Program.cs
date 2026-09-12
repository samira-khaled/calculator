namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start;
            do {
                Console.Write("Enter the first number: ");
                double X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter an operator (+, -, *, /): ");
                string Operator = Console.ReadLine();
                if (Operator == "+")
                {
                    double Result = X + Y;
                    Console.WriteLine(Result);
                }
                else if (Operator == "-")
                {
                    double Result = X - Y;
                    Console.WriteLine(Result);
                }
                else if (Operator == "*")
                {
                    double Result = X * Y;
                    Console.WriteLine(Result);
                }
                else if (Operator == "/")
                {
                    double Result = X / Y;
                    Console.WriteLine(Result);
                }
                Console.Write("do caculate again read y/n : ");
               start= Console.ReadLine();
            } while (start=="y");
            

        }
    }
}
