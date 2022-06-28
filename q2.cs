  string str1 = "never odd or even";
        str1 = str1.Replace(" ",string.Empty);
        string revStr1 = "";
        string str2 = "book is life";
        str2 = str2.Replace(" ",string.Empty);
        string revStr2 = "";
        char[] charArr1 = str1.ToCharArray();
        char[] charArr2 = str2.ToCharArray();
        
        for(int i = charArr1.Length-1;i>=0;i--){
            revStr1 += charArr1[i];
        }
        
        for(int i = charArr2.Length-1;i>=0;i--){
            revStr2 += charArr2[i];
        }
        
        if(str1==revStr1){
            Console.WriteLine("String 1 is a Palindrome");
        }
        else{
            Console.WriteLine("String 1 is NOT a Palindrome");
        }
        if(str2==revStr2){
            Console.WriteLine("String 2 is a Palindrome");
        }
        else{
            Console.WriteLine("String 2 is NOT a Palindrome");
        }