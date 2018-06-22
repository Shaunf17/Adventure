using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
    }

    public class Sword : Item
    {
        public Sword()
        {
            Id = 1;
            Name = "Sword";
            Weight = 5;
            Description = "Basic sword. Rather unimpressive really";
        }
    }

    public class ItemList
    {
        List<Item> ItemsList = new List<Item>();

        public ItemList()
        {
            ItemsList.Add(new Sword { });
        }

        //public void CreateItemList()
        //{
        //    ItemsList.Add(new Sword { });
        //}

        public Item Find(int Id)
        {
            Item item = ItemsList.Find(i => i.Id == Id);

            return item;
        }

    }
}
