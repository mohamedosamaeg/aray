// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// declation of array
int[] Ages = new int[5]; // data type + [] meaning array + array name = new [ count of values ]
Ages = new int[] { 1, 2, 3, 4, 5 };

string value = "User1";
string value2 = "User2";
string value3 = "User3";
string value4 = "User4";
string value5 = "User5";
Console.WriteLine("Write Your User Number (From 1 To 5)");
Console.ReadLine();

string[] values = new string[] { "value  ","  value2 ", "  value3 ","value4","value5" };
Console.WriteLine("Write Your Password");
string Password = Console.ReadLine();
switch (Password.ToLower())
{
    case "mohamed":
        Console.WriteLine("70% correct");
        break;
    case "mohamed66":
        Console.WriteLine("80% correct");
        break;
    case "mohamed662002":
        Console.WriteLine("100% correct");
        break;
    default:
        Console.WriteLine("0% correct");
        break;
}