class Program
{
    static void Main()
    {
            string exp;
            Console.WriteLine("Enter expression seperated by spaces");
            exp = Console.ReadLine();
            string []data = exp.Split(' ');
            int a = Convert.ToInt16(data[0]);
            int b = Convert.ToInt16(data[2]);
            
            if(data[1] == '+')
            {
                Console.WriteLine($"sum of {a} and {b} is {a + b}");
            }
            else if(data[1] == '-')
            {
                Console.WriteLine($"diff of {a} and {b} is {a - b}");
            }
            else if(data[1] == '*')
            {
                Console.WriteLine($"product of {a} and {b} is {a * b}");
            }
            else if(data[1] == '/')
            {
                // try(data)
                if(data[2] == 0)return DivideByZeroException;
                Console.WriteLine($"fraction of {a} and {b} is {a / b}");
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }



    }
}