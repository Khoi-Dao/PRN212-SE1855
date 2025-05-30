using DemoAliasAndClone;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Student s1 = new Student();
s1.Id = 1;
s1.Name = "Alice";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Bob";

// Lúc này trên thanh Ram sẽ cấp phát 2 ô nhớ
// cho s1 và s2 quản lý
// ==> s1 đổi giá trị không liên uqan gì tới s2 vì
//s1 và s2 đang quản lý 2 ô nhớ khác nhau

s1 = s2;

//ta viết lệnh s1=s2
// Tuy nhiên về bản chất nó hoạt động như nhau:
//s1 trỏ tới vùng nhớ mà s2  đang quản lý
// chứ không phải s1 bằng s2
// có 2 tình huống xảy ra:
// (1) ô nhớ bên s2 giờ
//có thêm s1 quản lý ==> alias (>= 2 đối tượng quản lý)
// chỉ cần 1 đối tướng bị  đổi thì các đối tượng khác đều bị đổi
s2.Name="Charlie";
Console.WriteLine(s1.Name); 
// Id: 2, Name: Charlie
//(2) ô nhớ lúc trước s1 quản lý giờ không còn đối tượng nào quản lý 
// thì lúc này HĐH tự động thu hồi ô nhớ: Automatic Garbage Collection
//tức là ta không thể truy suất để lấy lại giá trị s1 có id - 1 , name Alice
