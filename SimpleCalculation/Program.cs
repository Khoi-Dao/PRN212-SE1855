//nhap vao a ,b  phep toan

using System.Text;



void do_calculate (double a ,double b, string userInput)
{
    switch (userInput)
    {
        case "+":
            Console.WriteLine($"Tổng là = {a + b}");
            break;
        case "-":
            Console.WriteLine($"hiệu là = {a - b}");
            break;
        case "*":
            Console.WriteLine($"Tích là = {a * b}");
            break;
        case "/":
            if (b != 0)
                Console.WriteLine($"Thương là {a / b}");
            else
                Console.WriteLine("Không thể chia cho 0");
            break;
        default:
            Console.WriteLine("Phép toán không hợp lệ");
            break;
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phép Toán Cơ Bản");
Console.Write("Nhập a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhập b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("nhập vào phép toán: + - * /");
string userInput = Console.ReadLine();
do_calculate(a, b, userInput);
Console.ReadLine();