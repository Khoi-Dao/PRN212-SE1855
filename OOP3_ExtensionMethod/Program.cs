using OOP3_ExtensionMethod;
using System.ComponentModel;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
//Console.WriteLine("Tổng từ 1 đến {0} là: {1}", n1, MyUtils.Tongtu1toiN(n1));
Console.WriteLine("Tổng từ 1 tới 5= " + n1.Tongtu1toiN());
int n2 = 10;
Console.WriteLine("Tổng từ 1 tới 10= " + n2.Tongtu1toiN());
Console.WriteLine("Tổng từ 1 tới 10= " + 100.Tongtu1toiN());

//Console.WriteLine("Tổng của {0} và {1} là: {2}", n1, n2, n1.Cong(n2));
Console.WriteLine("Tổng của 2 số 10+20 ="+10.Cong(20));

//*viết 1 hàm trả về các số nguyên tố từ 1 tới n
//*bổ sung 1 hàm tạo ngẫu nhiên giá trị in bất kỳ

int[] arr = new int[8];
arr.taoMang();
Console.WriteLine("Mảng trước khi sấp xếp:");
arr.xuatMang();
arr.SapxepTangDan();
Console.WriteLine("Mảng sau khi sấp xếp:");
arr.xuatMang();
