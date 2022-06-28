string str = "never odd or even";
        string revStr = "";
        char[] charArr = str.ToCharArray();
        for(int i = charArr.Length-1;i>=0;i--){
            revStr += charArr[i];
        }
        Console.WriteLine(revStr);