// Task66
int sumNaturalNumbers(int m, int n)
{
    if (m <= n) return m + sumNaturalNumbers(++m, n);
    return 0;
}
Console.WriteLine(sumNaturalNumbers(1, 15));