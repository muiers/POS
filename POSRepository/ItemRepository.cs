using POSData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRepository
{
    public class ItemRepository
    {
        private POSEntities _db;

        //Database instance
        public ItemRepository()
        {
            _db = new POSEntities();
        }

        //Add Item
        public void AddItem(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
        }
        
        //Remove Item
        public void RemoveItem(int itemId)
        {
            var item = _db.Items.FirstOrDefault(a => a.ItemId == itemId);

            if (item != null)
            {
                _db.Items.Remove(item);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Item not found.");
            }
        }
       
        //Update Item
        public Item UpdateItem(Item item)
        {
            return null;
        }
        
        //Get by ID from Item
        public Item GetItem(int itemId)
        {
            return _db.Items.FirstOrDefault(a => a.ItemId == itemId);
        }

        //Get All Items
        public List<Item> GetItems()
        {
            return _db.Items.ToList();
        }
    }
}
