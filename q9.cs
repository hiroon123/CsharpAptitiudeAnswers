int[] arr = { 4, 9, 7, 1, 2, 8 };
for(int i = 0; i < arr.Length-1; i++)
{
    int temp = arr[0];
    arr[0] = arr[i+1];
    arr[i+1] = temp;
}
for(int x=0; x < arr.Length; x++)
{
    Console.Write(arr[x] +" ");
}