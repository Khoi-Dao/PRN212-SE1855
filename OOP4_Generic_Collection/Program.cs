using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*
 *  Sử dụng generic list để quản lý nhân sự
 *  thự hiện đầy đủ tính năng CRUD
 *  C-Create -> thêm mới nhân sự
 *  R-Read/Retrieve -> Đọc :truy vấn , tìm kiếm, sấp xếp....
 *  U-Update --> chỉnh sửa dữ liệu
 *  D-Delete -- Xóa dữ liệu
 */

// Cấu 1 liên quan tới C - Create
//Dùng list để tạo 5 employy trong đó 4 employee là chín thức và 1 employ là thời vụ

List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Akira";
e1.IdCard = "123";
e1.BirthDate = new DateTime(1996, 11, 24);
employees.Add(e1);
FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 2;
e2.Name = "Athrun";
e2.IdCard = "124";
e2.BirthDate = new DateTime(1996, 6, 25);
employees.Add(e2);
FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 3;
e3.Name = "Shinn";
e3.IdCard = "125";
e3.BirthDate = new DateTime(1998, 12, 12);
employees.Add(e3);
FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 4;
e4.Name = "Yzak";
e4.IdCard = "126";
e4.BirthDate = new DateTime(1996, 12, 25);
employees.Add(e4);
ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 5;
e5.Name = "Nicole";
e5.IdCard = "127";
e5.workingHours = 2;
e5.BirthDate = new DateTime(1996, 9, 25);
employees.Add(e5);

//câu 2 : R -> Xuất toàn bộ nhân sự:
// Cách 1
Console.WriteLine("Cách 1/Danh sách nhân sự:");
employees.ForEach(e => Console.WriteLine(e));
// Cách 2 
Console.WriteLine("Cách 2/Danh sách nhân sự:");
foreach ( var e in employees)
{
    Console.WriteLine(e);
}

// câu 3 : R -> lọc ra nhân sự chính thức và tính tổng lương
//cách 1: dùng cách thông thường:
List<FulltimeEmployee> fe_list = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        //fe_list.Add((FulltimeEmployee)e);
        fe_list.Add(e as FulltimeEmployee);
    }
}
Console.WriteLine("Danh sách nhân sự chính thức:");
foreach (var e in fe_list)
{
    Console.WriteLine(e);
}

//cách 2 dùng các extension method của hệ thống:
List<FulltimeEmployee> fe_list2 = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("Danh sách nhân sự chính thức:");
fe_list2.ForEach(e => Console.WriteLine(e));

//Tổng lương
double sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Tổng lương nhân sự chính thức: " + sum_salary);

//Câu 4 : R-> sấp xếp danh sách nhân sự theo ngày tháng năm sinh
for (int i =  0; i < employees.Count; i++)
{
    for (int j = i +1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.BirthDate > ej.BirthDate)
        {
            
            employees[i] = ej;
            employees[j] = ei;
            //switch their birthdate
        }
    }
}
Console.WriteLine("Danh sách nhân sự sắp xếp theo ngày tháng năm sinh:");
employees.ForEach(e=> Console.WriteLine(e));

// bổ sung sửa và xóa