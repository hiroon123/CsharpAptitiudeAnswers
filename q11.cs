int x = 285;
int sum = 0;
while (x > 0)
{
    int mod = x % 10;
    sum += mod;
    x /= 10;
}
Console.WriteLine(sum);