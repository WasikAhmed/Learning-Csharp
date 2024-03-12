using System;

namespace Calculator
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public int Operation { get; set; }
        public bool On { get; set; }

        public Calculator()
        {
            On = true;
            WelcomeMessage();
            do
            {
                GetOperation();
                if (Operation == 5)
                {
                    break;    
                }

                GetInputs();
                Calculate();

            } while (On);
        }

        private void Calculate()
        {
            switch (Operation)
            {
                case 1:
                    Console.WriteLine($"Addition of {Num1} and {Num2}: {Add()}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction of {Num2} from {Num1}: {Subtract()}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of {Num1} times {Num2}: {Multiply()}");
                    break;
                case 4:
                    Console.WriteLine($"Division of {Num1} by {Num2}: {Divide()}");
                    break;
                case 5:
                    On = false;
                    break;
                default:
                    break;
            }
        }
        
        private double Add()
        {
            return Num1 + Num2;
        }
        private double Subtract()
        {
            return Num1 - Num2;
        }
        private double Multiply()
        {
            return Num1 * Num2;
        }
        private double Divide()
        {
            if (Num2 == 0)
            {
                return double.NaN;
            }

            return Num1 / Num2;
        }

        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Console Calculator :)");
        }
        private bool GetOperation()
        {                
            Console.WriteLine("Please choose an operation to perform!!!");
            Console.Write("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit\n");
            Console.Write("Enter your choice: ");
            try
            {
                Operation = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            if (Operation <= 0 || Operation >= 5)
            {
                Console.WriteLine("Choose a valid option. Try again!");
                GetOperation();
            }

            return true;
        }
        private bool GetInputs()
        {
            try
            {
                Console.WriteLine("Enter your inputs!");
                Console.Write("1st Number: ");
                Num1 = int.Parse(Console.ReadLine());
                Console.Write("2nd Number: ");
                Num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return true;
        }
    }
}