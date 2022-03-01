// See https://aka.ms/new-console-template for more information
int n = 6;
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

int Fibonacci(int element)
{
    if (element == 0)
    {
        return 0;
    }
    if (element == 1)
    {
        return 1;
    }
    return Fibonacci(element - 2) + Fibonacci(element - 1);
}