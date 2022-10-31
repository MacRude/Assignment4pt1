using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

using var db = new NorthwindContext();

//foreach (var category in db.Categories.Where(x => x.Name.Contains("Co")))
//{
//    Console.WriteLine(category.Name);
//}

foreach (var product in db
             .Products
             .Include(x => x.Category)
             .Where(x => x.Category.Name.Contains("a"))
             .Take(5).OrderBy(x => x.Name))
{
    Console.WriteLine($"Productname: {product.Name}, Category: {product.Category.Name}");
}
//Order exercises
//Ex 1
foreach (var order in db.Orders.Where(x => x.OrderId.Equals(10500)))
{
    Console.WriteLine($"CustomerID: {order.CustomerId}, EmployeeID: {order.EmployeeId}," +
        $" RequiredDate: {order.RequiredDate}, OrderDate: {order.OrderDate}," +
        $" ShipName: {order.ShipName}, ShipDate: {order.ShipDate}," +
        $" Freight: {order.Freight}, ShipAddress: {order.ShipAddress}," +
        $" ShipCity: {order.ShipCity}, ShipPostalCode: {order.ShipPostalCode}," +
        $" ShipCountry: {order.ShipCountry}");
}
//Ex 2
foreach (var order in db.Orders.Where(x => x.ShipName.Contains("Ernst Handel")).Take(1))
{
    Console.WriteLine($"OrderID: {order.OrderId}, ShipDate: {order.ShipDate}," +
        $" ShipName: {order.ShipName}, ShipCity: {order.ShipCity}");
}


//Ex 3
foreach (var order in db.Orders.Where(x => x.ShipName.Contains("Ernst Handel")))
{
    Console.WriteLine($"OrderID: {order.OrderId}, ShipDate: {order.ShipDate}," +
        $" ShipName: {order.ShipName}, ShipCity: {order.ShipCity}");
}

//Order details exercises
//Ex 4


//var cat = new Category { Id = 101, Name = "Test" };
//db.Categories.Add(cat);

//var cat = db.Categories.Find(101);
//cat.Description = "sdæfslfdfjlsd";

//var cat = db.Categories.Find(101);
//db.Categories.Remove(cat);




//var cat = new Category { Id = 101, Name = "Test" };
//db.Categories.Add(cat);

//db.SaveChanges();

foreach (var category in db.Categories)
{
    Console.WriteLine(category.Name);
}



