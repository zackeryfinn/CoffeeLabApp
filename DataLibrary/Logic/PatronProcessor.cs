using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class PatronProcessor
    {
        public static int CreatePatron(string firstName, string lastName, string email)
        {
            Patrons data = new Patrons
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            string sql = @"insert into dbo.Patrons (FirstName, LastName, Email)
                        values (@FirstName, @LastName, @Email);";

            return SqlDataAccess.SaveData(sql, data);
            
        }

        public static List<Patrons> LoadPatrons()
        {
            string sql = @"select PatronID, FristName, LastName, Email
                        from dbo.Patrons;";

            return SqlDataAccess.LoadData<Patrons>(sql);
        }
    }
}
