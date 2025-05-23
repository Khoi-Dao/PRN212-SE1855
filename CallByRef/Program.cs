void function1 (int n)
{
    n = 8;
    Console.WriteLine($"n inside into function: {n}");
}
void function2(ref int n)
{
    n = 8;
    Console.WriteLine($"n inside into function: {n}");
}
void function3(out int n)
{
    n = 8;
    Console.WriteLine($"n inside into function: {n}");
}
int n = 5;

Console.WriteLine($"n before entering into function: {n}");



string userinput;
Console.Write("Enter your choice: ");
userinput = Console.ReadLine();
switch (userinput)
{
    case "ref":
        function2(ref n);
        break;
    case "out":
        function3(out n);
        break;
    default:
        function1(n);
        break;
}
Console.WriteLine($"n after entering into function: {n}");
