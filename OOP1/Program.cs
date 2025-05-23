using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//tạo 1 đối tưởng danh mục:

Employee e1 = new Employee();
//Gán giá trị cho các thuộc tính


e1.Id = 1;
e1.IdCard = "096042065340";
e1.Name = "Đào Nguyên Khôi";
e1.Email = "khoi.dao2411@gmail.com";
e1.Phone = "0904096480";
//Xuất dữ liệu
e1.PrintInfo();
//truy xuất từng property
Console.WriteLine("=========================================");
Console.WriteLine($"ID của e1 = {e1.Id}"); //Gọi getter Property Id
Console.WriteLine($"ID Card của e1 = {e1.IdCard}"); // Gọi getter Property IdCard
Console.WriteLine($"Name của e1 = {e1.Name}"); // Gọi getter Property Name

//Ta cũng có thể khởi tạo đối tượng và các giá trị của thuộc tính như sau:

Employee e2 = new Employee()
{
    Id = 2,
        IdCard = "096042065340",
        Name = "Đào Nguyên Khôi",
        Email = "khoi.dao2411@gmail.com",
        Phone = "0904096480"
};
Console.WriteLine("=========================================");
e2.PrintInfo();

Employee e3 = new Employee(3,"23215","Long","long11@gmail.com","53532532532");
//gọi hàm xuất thông tin
e3.PrintInfo();
//hoặc tự động gọi tostring() khi đối tượng được in ra
Console.WriteLine(e3);

//thử dùng contructor mặt định không có đối số
Employee e4 = new Employee();
Console.WriteLine(e4);

Customer c1 = new Customer()
{
    Id = "C001",
    Name = "Nguyễn Văn A",
    Email = "dfa@abc",
    Phone = "0909090909",
    Address = "Hà Nội"
};
c1.PrintInfo();
c1.Address = "Hà Giang";
c1.Phone = "0987654321";
Console.WriteLine("Thông tin sau khi chỉnh sửa:");
c1.PrintInfo();