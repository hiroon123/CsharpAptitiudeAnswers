int[] arr = { 4, 9, 7, 1, 2, 8 };
int first = int.MinValue, second = int.MinValue;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] > first)
    {
        second = first;
        first = arr[i];
    }
    else if(arr[i]>second && arr[i] != first)
    {
        second = arr[i];
    }
}
Console.WriteLine("Second Largest No: " + second);