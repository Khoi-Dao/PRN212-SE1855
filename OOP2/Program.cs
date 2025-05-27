
using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee Akira = new FulltimeEmployee();
{
    Akira.Id = 1;
    Akira.IdCard = "123";
    Akira.Name = "Akira";
    Akira.BirthDate = new DateTime(1996, 11, 24);
    
}
Console.WriteLine($"Thông tin nhân viên {Akira.Name}:");
Console.WriteLine($"Lương của nhân viên {Akira.Name} là: {Akira.calSalary()}\t,Id là: {Akira.Id},Id card là: {Akira.IdCard}, năm sinh là {Akira.BirthDate}");

ParttimeEmployee Shinn = new ParttimeEmployee();
{
    Shinn.Id = 2;
    Shinn.IdCard = "124";
    Shinn.Name = "Shinn";
    Shinn.BirthDate = new DateTime(1998, 5, 15);
    Shinn.workingHours = 20; // Giả sử làm việc 20 giờ
}
Console.WriteLine($"Thông tin nhân viên {Shinn.Name}:");
Console.WriteLine($"Lương của nhân viên {Shinn.Name} là: " +
    $"{Shinn.calSalary()},\n Id là: {Shinn.Id}, \nId card là: {Shinn.IdCard}, \nnăm sinh là {Shinn.BirthDate}, \nsố giờ làm việc là: {Shinn.workingHours}");
Console.WriteLine("Sử dụng ToString()");
Console.WriteLine(Akira);
Console.WriteLine(Shinn);