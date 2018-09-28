using System.Collections.Generic;
using core_api.Models;

namespace core_api.Data
{
    public class DataContext
    {
        public List<Item> Items { get; set; }

        public DataContext()
        {
            Items = new List<Item>();

            Items.Add(new Item(1,"name1",1,"desc1"));
            Items.Add(new Item(2,"name2",2,"desc2"));
            Items.Add(new Item(3,"name3",3,"desc3"));
            Items.Add(new Item(4,"name4",4,"desc4"));
        }
    }
}