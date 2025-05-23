using System.Text;

double a;
double b;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương Trình Bậc 1");
Console.Write("Nhập a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Nhập b: ");
b = double.Parse(Console.ReadLine());
if ( a == 0 && b == 0)
{
    Console.WriteLine("Phương Trình vô số nghiệm");
} else if (a == 0 && b != 0)
{
    Console.WriteLine("Phương trình không có nghiệm");
} else
{
    Console.WriteLine($"Phương Trình có nghiệm là x = {-b / a}");
}

Console.ReadLine();