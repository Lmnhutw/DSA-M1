//Bai 1 Input
  string greeting;
  Console.WriteLine("Nhap HelloWorld");
  greeting = Console.ReadLine();
  Console.WriteLine(greeting);  

//Bai 1-1 Output
 Console.WriteLine("Hello World");  

 //Bai 2

 string a = "HelloWorld";
 Console.WriteLine(a);

 //Bai 3

 string firstLetter = "Hello";
 string c = " ";
 string lastLetter = "World";
 Console.WriteLine(firstLetter + c + lastLetter);


 //Bai 4

Console.WriteLine(CombineStrings(firstLetter, c, lastLetter));
    
    static string CombineStrings(string str1, string str2, string str3)
    {
        return string.Concat(str1, str2, str3);
    }
