using System.Linq;
using System.Collections;
using core_api.Models;

namespace core_api.Classes
{
    public interface IListManager
    {
         IQueryable<Item> FindItemsByDescription(string description, int pageIndex, int pageSize);
    }
}