
string str = "never odd or even";
str = str.Replace(" ", string.Empty);
while (str.Length > 0)
{
    Console.Write(str[0] + " = ");
    int count = 0;
    for(int i=0; i<str.Length; i++)
    {
        if (str[0] == str[i])
        {
            count++;
        }
    }
    Console.WriteLine(count);
    str = str.Replace(str[0].ToString(), string.Empty);
}
