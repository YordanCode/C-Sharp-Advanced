
int n = int.Parse(Console.ReadLine());
static long CalculateFactorial(int n)
{
    if (n == 0 || n == 1)
        return 1; // Base case: factorial of 0 and 1 is 1
    else
        return n * CalculateFactorial(n - 1); // Recursive case
}
Console.WriteLine(CalculateFactorial(n));