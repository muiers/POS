using POSData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRepository
{
    public class ItemCategoryRepository
    {
        private POSEntities _db;

        //Database instance
        public ItemCategoryRepository()
        {
            _db = new POSEntities();
        }

        //Add Item Category
        public void AddItemCategory(ItemCategory itemCategory)
        {
            _db.ItemCategories.Add(itemCategory);
            _db.SaveChanges();
        }

        //Remove Item Category
        public void RemoveItemCategory(int itemCategoryId)
        {
            var itemCategory = _db.ItemCategories.FirstOrDefault(a => a.ItemCategoryId == itemCategoryId);

            if (itemCategory != null)
            {
                _db.ItemCategories.Remove(itemCategory);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Item category not found.");
            }
        }

        //Update Item Category
        public ItemCategory UpdateItemCategory(ItemCategory itemCategory)
        {
            return null;
        }

        //Get by ID from Item Category
        public ItemCategory GetItemCategory(int itemCategoryId)
        {
            return _db.ItemCategories.FirstOrDefault(a => a.ItemCategoryId == itemCategoryId);
        }

        //Get All Item Category
        public List<ItemCategory> GetItemCategory()
        {
            return _db.ItemCategories.ToList();
        }
    }
}
