//* hãy cài đặt hàm tính tuổi vào lớp employee
using OOP2;
using OOP2_Reuse_As_Library;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee e1 = new FulltimeEmployee();
e1.Name = "Athrun";
e1.Id = 3;
e1.IdCard = "125";
e1.BirthDate = new DateTime(1996, 5, 20);
Console.WriteLine("Thông tin của Athrun");
Console.WriteLine(e1);
//Console.WriteLine($"Tuổi của Athrun là: {e1.TinhTuoi()}");
Console.WriteLine("Tuổi của Athrun là: " +e1.TinhTuoi());
