using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string lastName = "Đào";
string midName = "Nguyên";
string firstName = "Khôi";

//string fullname = lastName + " " + midName + " " + firstName;
//StringBuilder sb = new StringBuilder();
//sb.Append(lastName);
//sb.Append(" ");
//sb.Append(midName);
//sb.Append(" ");
//sb.Append(firstName);
//Console.WriteLine(sb.ToString());
Console.WriteLine($"{lastName} {midName} {firstName}");