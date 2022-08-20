void Task64()
{
    Console.WriteLine("Please enter number one");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter number two");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    DividedToThree(numberOne, numberTwo);
}

void Task66()
{
    int sum = 0;
    Console.WriteLine("Please enter number one");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter number two");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int result = SumOfElements(numberOne, numberTwo, sum);
    Console.WriteLine($"Sum of elements = {result}");
}

void Task68()
{
    double res = 0;
    Console.WriteLine("Please enter number one");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter number two");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double result = AkkermanFunction(numberOne, numberTwo, res);
    Console.WriteLine($"Akkerman function result = {result}");
}


void DividedToThree(int numberOne, int numberTwo)
{
    if (numberOne == numberTwo) return;
    numberOne++;
    if (numberOne % 3 == 0) Console.Write($"{numberOne}, ");
    DividedToThree(numberOne, numberTwo);
}

int SumOfElements(int numberOne, int numberTwo, int sum)
{
    if (numberOne > numberTwo) return sum;
    sum += numberOne;
    numberOne++;
    return SumOfElements(numberOne, numberTwo, sum);
}

double AkkermanFunction(double numberOne, double numberTwo, double res)
{
    if (numberOne == 0) return res = numberTwo + 1;
    if (numberOne > 0 && numberTwo == 0) res = AkkermanFunction(numberOne - 1, 1, res);
    if (numberOne > 0 && numberTwo > 0) res = AkkermanFunction(numberOne - 1, AkkermanFunction(numberOne, numberTwo - 1, res), res);
    return res;
}

// Task64();
// Task66();
Task68();