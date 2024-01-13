using System;

class Program
{
    static void Main()
    {
      
        Console.WriteLine("Welcome");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.Write("Please enter your salary: ");

        if (int.TryParse(Console.ReadLine(), out int userSalary))
        {
            double netIncome = CalculateNetIncome(userSalary);
            Console.WriteLine($" {name}, your net income is ${netIncome}");
        }
        else
        {
            Console.WriteLine("t seems like there might be an issue with the salary input you provided. Please ensure that you are entering a valid numeric value for the salary. ");
        }
    }

    static double CalculateNetIncome(int userSalary)
    {
        const double TaxRate1 = 0.05;
        const double TaxRate2 = 0.1;
        const double TaxRate3 = 0.2;

        int remainingSalary = userSalary - 100;
        double taxPaid1 = 0, taxPaid2 = 0, taxPaid3 = 0;

        if (remainingSalary > 0)
        {
            int taxedAmount1 = Math.Min(remainingSalary, 200);
            taxPaid1 = taxedAmount1 * TaxRate1;
            remainingSalary -= taxedAmount1;

            if (remainingSalary > 0)
            {
                int taxedAmount2 = Math.Min(remainingSalary, 500);
                taxPaid2 = taxedAmount2 * TaxRate2;
                remainingSalary -= taxedAmount2;

                if (remainingSalary > 0)
                {
                    int taxedAmount3 = remainingSalary;
                    taxPaid3 = taxedAmount3 * TaxRate3;
                }
            }
        }

        double netIncome = userSalary - taxPaid1 - taxPaid2 - taxPaid3;
        return netIncome;
    }
}
