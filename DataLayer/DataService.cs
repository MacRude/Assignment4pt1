using DataLayer.Model;
using System.Reflection.Metadata.Ecma335;

namespace DataLayer
{
    public class DataService
    {
        public IList<Category> GetCategories()
            {
            using var db = new NorthwindContext();
            
            return db.Categories.ToList();
            }
    }
}