using Lucy_SalesManagement;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;

string connectionString = "server=VU-LAPTOP\\SQLEXPRESS ;database=Lucy_SalesData;uid=sa;pwd=12345;TrustServerCertificate = True";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

// Câu 1: Truy vấn toàn bộ danh mục

int customerid = 1;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == customerid);
if (cust != null)
{
    Console.WriteLine($"Customer ID: {cust.CustomerID}");
}
else
{
    Console.WriteLine($"Customer with ID {customerid} not found.");
}

// Cầu 2 : Lọc ra danh sách các hóa đơn của khách hàng tìm thấy
if (cust!= null)
{
    Console.WriteLine("Hóa đơn của khách hàng :");
    foreach (var order in cust.Orders)
    {
        Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate.ToString("d/M/yyyy")}");
    }
}

//Cầu 3 : bổ sung thêm 1 cột hiện thị trị giá của hóa đơn

if (cust != null)
{
    Console.WriteLine("Hóa đơn của khách hàng :");
    foreach (var od in cust.Orders)
    {

        decimal money = od.Order_Details.Sum(odd => odd.Quantity * odd.UnitPrice - (decimal)odd.Discount * odd.Quantity * odd.UnitPrice);
        Console.WriteLine($"Order ID: {od.OrderID}, Order Date: {od.OrderDate.ToString("d/M/yyyy")}" 
            +"\t" +"Total price: " + money);
    }
}