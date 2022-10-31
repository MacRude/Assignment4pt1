

using DataLayer;

var ds = new DataService();

var categories = ds.GetCategories();

foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}