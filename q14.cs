int[,] arr = new int[2,6] { { 5, 7, 4, 1, 9, 2 }, { 4, 9, 7, 1, 2, 8 } };
int[] resArr = new int[12];
int m = 0;
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 6; j++)
    {
        resArr[m++] = arr[i, j];
    }
}
for(int x = 0; x < resArr.Length; x++)
{
    Console.Write(resArr[x] + " ");
}
