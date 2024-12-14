//total < 10 - 1%
//total >= 10 && total < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculatorDiscount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(discount, userInput);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculatorDiscount(int total)
{
    if (total > 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double discount, double total)
{
    double result = total - ((total * discount) / 100);
    return result;
}