using App4.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App4.Data
{
   public class DataBaseInitAndTransactions
    {
        readonly SQLiteAsyncConnection database;

        public DataBaseInitAndTransactions(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ItemsAttributes>().Wait();
        }

        public Task<List<ItemsAttributes>> GetItemsAsync()
        {
            return database.Table<ItemsAttributes>().ToListAsync();
        }

        public Task<List<ItemsAttributes>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<ItemsAttributes>("SELECT * FROM [ItemsAttributes] WHERE [Done] = 0");
        }

        public Task<ItemsAttributes> GetItemAsync(int id)
        {
            return database.Table<ItemsAttributes>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ItemsAttributes item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(ItemsAttributes item)
        {
            return database.DeleteAsync(item);
        }
    }
}
