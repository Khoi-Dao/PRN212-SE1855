using DemoLINQ2SQL;
using System.Security.Cryptography;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=VU-LAPTOP\\SQLEXPRESS ;database=MyStore;uid=sa;pwd=12345;TrustServerCertificate = True";
MyStoreDataContext context = new  MyStoreDataContext(connectionString);
// Câu 1 truy vấn toàn bộ danh mục
var dsdm = context.Categories.ToList();
Console.WriteLine("List of Categories");
dsdm.ForEach ( x=>
Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));

// Câu 2 Dùng querySyntax để lọc ra toàn bộ sp
// lấy hết

var dsp = from p in context.Products
                    select p;
Console.WriteLine("List of Products");
foreach (var p in dsp)
{
    Console.WriteLine($"{p.ProductID}\t{p.ProductName}\t{p.UnitPrice}\t{p.UnitsInStock}");
}

//Câu 3: Tìm danh mục khi biết mã danh mục
int categoryid = 3;
Category cate = context.Categories.FirstOrDefault(c => c.CategoryID == categoryid);
if (cate == null)
{
    Console.WriteLine($"Can't find Category ID");
}
else
{
    Console.WriteLine($"CategoryID found :{categoryid}");
    Console.WriteLine(cate.CategoryID+"\t" + cate.CategoryName);
}
//Câu 4: Lọc ra TOP 3 sản phẩm có giá lớn nhất

var top3Products = context.Products.OrderByDescending
    (p => p.UnitPrice).Take(3).ToList();

Console.WriteLine("Top 3 Products with highest price: ");
foreach ( var p in top3Products)
{
    Console.WriteLine($"{p.ProductID}\t{p.ProductName}\t{p.UnitPrice}\t{p.UnitsInStock}");
}
// Câu 5 thêm mới 1 danh mục
//Category c1 = new Category();
//c1.CategoryName = "Universe Cosmic Gundam figurine";
//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();

// Câu 6: Sửa tên danh mục
// Tìm danh mục
// tìm thấy thì sửa chửa
//Category c9 = context.Categories.FirstOrDefault(c => c.CategoryID == 9);
//if (c9 != null)
//{
//    c9.CategoryName = "Gundam Universe Cosmic";
//    context.SubmitChanges();
//}

//câu 7 xóa danh mục kih biết mã danh mục
//if (c9 != null)
//{
//    context.Categories.DeleteOnSubmit(c9);
//    context.SubmitChanges();
//}
//câu 8 : xóa tất cả danh mục chưa có bất kỳ sản phẩm nào

//var list_empty_product = context.Categories
//    .Where(c => c.Products.Count == 0).ToList();

//context.Categories.DeleteAllOnSubmit(list_empty_product);
//context.SubmitChanges();

//Câu 9: Thêm nhiều danh mục cùng 1 lúc

List<Category> list_cate = new List<Category>();
list_cate.Add(new Category { CategoryName = "Gundam Universe Cosmic" });
list_cate.Add(new Category { CategoryName = "Gundam Cosmic Era" });
list_cate.Add(new Category { CategoryName = "Gundam AD" });
list_cate.Add(new Category { CategoryName = "Gundam Calamity Era" });
context.Categories.InsertAllOnSubmit(list_cate);
context.SubmitChanges();