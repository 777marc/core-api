using System.Linq;
using core_api.Data;
using core_api.Models;

namespace core_api.Classes
{
    public class ListManager : IListManager
    {
        DataContext _dc = new DataContext();

        public IQueryable<Item> GetAllItems(int pageIndex = 1, int pageSize = 5)
        {
            var res = (from item in _dc.Items
                       select item).Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return res.AsQueryable();
        }
        public IQueryable<Item> FindItemsByDescription(string description, int pageIndex = 1, int pageSize = 5)
        {
            var res = (from item in _dc.Items
                      where item.Description.Contains(description)
                      select item).Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return res.AsQueryable();
        }
    }   
}