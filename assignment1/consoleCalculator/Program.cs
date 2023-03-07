// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input the first num");
string fn = Console.ReadLine();
int f = Int32.Parse(fn);
Console.WriteLine("Please input the second num");
string sn = Console.ReadLine();
int s = Int32.Parse(sn);
int result = 0;
Console.WriteLine("input the operator");
string op = Console.ReadLine();
switch (op)
{
    case "+":
        result = f + s;
        break;
    case "-":
        result = f - s;
        break;
    case "*":
        result = f * s;
        break;
    case "/":
        result = f / s;
        break;
    default:
        Console.WriteLine("Not a operator");
        break;
}
Console.WriteLine("The result is" + result);