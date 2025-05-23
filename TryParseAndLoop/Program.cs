//nhập vào 1 số lớn hơn hoặc = 0
// nếu nhập sai yêu cầu nhập lại

using System.Text;

string userInput;
Console.OutputEncoding = Encoding.UTF8;
do
{
    Console.Write("Nhập vào 1 số lớn hơn hoặc = 0: ");
    userInput = Console.ReadLine();
    if (int.TryParse(userInput, out int n) && n <= 0)
    {
        Console.WriteLine("Số bạn nhập là: số âm" );
        
    }
    else if (!int.TryParse(userInput, out n) )
    {
        Console.WriteLine("dữ liệu nhập không phải là số" );
    }
    else
    {
        Console.WriteLine("Nhập sai, vui lòng nhập lại!");
    }
} while (!int.TryParse(userInput, out int number) || number < 0);