int x = 285;
int count = 0;
for(int i = 2; i < x; i++)
{
    if (x % i == 0)
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine(x + " is  a prime number!");
}
else
{
    Console.WriteLine(x + " is NOT a prime number!");
}