using System.Text;
Console.OutputEncoding = Encoding.UTF8;
void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Phương Trình vô số nghiệm");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Phương trình không có nghiệm");
    }
    else
    {
        Console.WriteLine($"Phương Trình có nghiệm là x = {-b / a}");
    }

    Console.ReadLine();
}

void second_degree_solution(double a, double b, double c)
{
    if (a == 0)
    {
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("vô nghiệm");
        }else if (delta == 0)
        {
            Console.WriteLine($"phương trình có nghiệm kép x1 = x2 = {-b / (2 * a)} ");
        }
        else
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"phương trình có 2 nghiệm phân biệt x1 = {x1} và x2 = {x2}");
        }
    }
    Console.ReadLine();
}



Console.WriteLine("Phương Trình Bậc 2: ax^2 +bx +c = 0 ");
Console.Write("Nhập a: ");
var a = double.Parse(Console.ReadLine());
Console.Write("Nhập b: ");
var b = double.Parse(Console.ReadLine());
Console.Write("Nhập c: ");
var c = double.Parse(Console.ReadLine());

second_degree_solution(a, b, c);