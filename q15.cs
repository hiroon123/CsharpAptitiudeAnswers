int[] arr = { 4, 9, 7, 1, 2, 8 };
int[,] resArr = new int[2, 3];

int m = 0;
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 3; j++)
    {
        resArr[i,j] = arr[m++];
    }
}
for (int x = 0; x < 2; x++)
{
    Console.Write("{");
    for (int y = 0; y < 3; y++)
    {
        Console.Write(resArr[x, y] + " ");
    }
    Console.Write("} ");
}