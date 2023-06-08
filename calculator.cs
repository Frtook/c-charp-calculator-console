using System;


namespace AssWeek1
{
    class Program
    {
        static void calc(Double n1,Double n2,string op)
        {
            
            switch (op)
            {
                case "+":
                    Console.WriteLine(n1+n2);
                    break;

                case "-":
                    Console.WriteLine(n1 - n2);
                    break;

                case "*":

                    Console.WriteLine(n1 * n2);
                    break;

                case "/":
                    if (n2 == 0) Console.WriteLine("Connot divided by zero ! ");

                    else Console.WriteLine(n1 / n2);
                    
                    break;

                default:
                    Console.WriteLine("Error Operation! \n\nEnter + Or - Or * Or / ");
                    break;


            }
        }
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Welcom to Console Calculator\n");

                Console.Write("Enter Number 1 :");
                Double num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Number 2 :");
                Double num2 = int.Parse(Console.ReadLine());

                Console.Write("Ener the Operation :");
                string op = Console.ReadLine();

                calc(num1,num2,op);

                }
            catch(FormatException)
            {
                Console.WriteLine("Error valse !!");
            }
           

            Console.ReadKey();
        }
    }
}
