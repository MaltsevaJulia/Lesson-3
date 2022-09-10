// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();

    return value;
}

string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

string str = Prompt("введите число");
string strrev = ReverseString(str);

if (str == strrev)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}


