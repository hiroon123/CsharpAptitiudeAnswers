string str = "apron";
for(int i = 0; i < str.Length; i++)
{
    for(int j = i; j < str.Length;j++)
    {
       Console.WriteLine(str.Substring(i, j - i+1));
    }
}
