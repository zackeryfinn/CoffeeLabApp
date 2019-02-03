using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class ItemProcessor
    {
        public static int CreateItem(string name, string description, int quantity, float price)
        {
            Items data = new Items
            {
                Name = name,
                Description = description,
                Quantity = quantity,
                Price = price
            };

            string sql = @"insert into dbo.Items (Name, Description, Quantity, Price)
                        values (@Name, @Description, @Quantity, @Price);";

            return SqlDataAccess.SaveData(sql, data);
            
        }

        public static List<Items> LoadItems()
        {
            string sql = @"select ItemID, Name, Description, Quantity, Price
                        from dbo.Items;";

            return SqlDataAccess.LoadData<Items>(sql);
        }
    }
}
