// Task64
void reverseNumbers(int n)
{
    Console.Write($"{n} ");
    n--;
    if (n > 0)  reverseNumbers(n);
}
reverseNumbers(10);