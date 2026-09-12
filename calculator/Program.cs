namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start;
            do {
                Console.Write("Enter the first number: ");
                double X;
                
                    while (!double.TryParse(Console.ReadLine(), out X))
                    {
                        Console.Write("Invalid number enter the valid number : ");
                    

                    }
                    
                
 
                
                Console.Write("Enter the second number: ");
                double Y ;
                while (!double.TryParse(Console.ReadLine(), out Y))
                {
                    Console.Write("Invalid number enter the valid number : ");
                }

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
                    if(Y!=0)
                    {
                        double Result = X / Y;
                        Console.WriteLine(Result);
                    }
                    else
                    {
                        Console.WriteLine("canot devide on zero");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                }
                Console.Write("do caculate again read y/n : ");
               start= Console.ReadLine();
            } while (start=="y");
            

        }
    }
}
