using System;

class C_Calc
{
    public void Fn_Calc()
    {
        Fn_Operations();
    }

    private void Fn_Operations()
    {
        UInt16 option;
        do
        {
            Console.WriteLine("================CALCULATOR===============");

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            UInt16 choice = Convert.ToUInt16(Console.ReadLine());
            option = choice;

            switch (option)
            {
                case 1:
                    Fn_Helper(add.Fn_Add);
                    break;

                case 2:
                    Fn_Helper(sub.Fn_Subtract);
                    break;

                case 3:
                    Fn_Helper(multi.Fn_Multiply);
                    break;

                case 4:
                    Fn_Helper(div.Fn_Divide);
                    break;

                case 5:
                    Console.WriteLine("Thank you for using our Calculator.");
                break;
            }
        }
        while (option != 5);

    }

    //private void Addition()
    //{
    //    Console.WriteLine("Enter first number:");
    //    string input1 = Console.ReadLine();
    //    double res1 = Convert.ToDouble(input1);

    //    Console.WriteLine("Enter second number:");
    //    string input2 = Console.ReadLine();
    //    double res2 = Convert.ToDouble(input2);

    //    double res = add.Add(res1, res2);
    //    Console.WriteLine("Result: {0:F2}", res);
    //}
    //private void Subtraction()
    //{
    //    Console.WriteLine("Enter first number:");
    //    string input1 = Console.ReadLine();
    //    double res1 = Convert.ToDouble(input1);

    //    Console.WriteLine("Enter second number:");
    //    string input2 = Console.ReadLine();
    //    double res2 = Convert.ToDouble(input2);

    //    double res = sub.Subtract(res1, res2);
    //    Console.WriteLine("Result: {0:F2}", res);
    //}
    //private void Multiplication()
    //{
    //    Console.WriteLine("Enter first number:");
    //    string input1 = Console.ReadLine();
    //    double res1 = Convert.ToDouble(input1);

    //    Console.WriteLine("Enter second number:");
    //    string input2 = Console.ReadLine();
    //    double res2 = Convert.ToDouble(input2);

    //    double res = multi.Multiply(res1, res2);
    //    Console.WriteLine("Result: {0:F2}", res);
    //}
    //private void Division()
    //{
    //    Console.WriteLine("Enter first number:");
    //    string input1 = Console.ReadLine();
    //    double res1 = Convert.ToDouble(input1);

    //    Console.WriteLine("Enter second number:");
    //    string input2 = Console.ReadLine();
    //    double res2 = Convert.ToDouble(input2);

    //    double res = div.Divide(res1, res2);
    //    Console.WriteLine("Result: {0:F2}", res);
    //}
    private static void Fn_Helper(Func<double, double, double> operation)
    {
        Console.Write("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        double res = operation(num1, num2);
        Console.WriteLine("Result: {0:F2}", res);
    }

    private readonly C_Add add = new C_Add();
    private readonly C_Subtract sub = new C_Subtract();
    private readonly C_Multiply multi = new C_Multiply();
    private readonly C_Divide div = new C_Divide();
}