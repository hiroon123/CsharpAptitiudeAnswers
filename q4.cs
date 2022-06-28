string str = "never odd or even";
string result = string.Empty;
string[] words = str.Split(' ');
for(int i = 0; i < words.Length; i++)
{
    string revStr = "";
    char[] charArr = words[i].ToCharArray();
    for (int j = charArr.Length - 1; j >= 0; j--)
    {
        revStr += charArr[j];
    }
    result += revStr + ' ';
}
Console.WriteLine(result);