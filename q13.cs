int[] arr = { 4, 9, 7, 1, 2, 8 };
int first = int.MinValue, second = int.MinValue, third= int.MinValue;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] > first)
    {
        third = second;
        second = first;
        first = arr[i];
    }
    else if(arr[i]>second && arr[i] != first)
    {
        third = second;
        second = arr[i];
    }
    else if(arr[i]>third && arr[i]!= second)
    {
        third = arr[i];
    }
}
Console.WriteLine("Second Largest No: " + third);