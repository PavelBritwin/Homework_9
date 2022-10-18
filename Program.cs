// Task68
int funcAnkerman(int m, int n)
{
    if (m == 0) return n+1;
    if ((n == 0) && (m > 0)) return funcAnkerman(m-1, 1);
    return funcAnkerman(m - 1, funcAnkerman(m, n - 1));
}
Console.WriteLine(funcAnkerman(3, 2));