using FridgeAlert.Data;
using FridgeAlert.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite
{
    public class UserRepository
    {
        SQLiteConnection connection;
        public string? StatusMessage { get; set; }

        public UserRepository()
        {
            connection = new SQLiteConnection(
                Constants.DatabasePath,
                Constants.flags);
            connection.CreateTable<User>();
        }

        public void AddOrUpdate(User User)
        {
            int result = 0;
            try
            {
                if (User.Id != 0)
                {
                    result = connection.Update(User);
                    StatusMessage = $"{result} Rows updated";
                }
                else
                {
                    result = connection.Insert(User);
                    StatusMessage = $"{result} Rows(s) added";

                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return connection.Table<User>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public User? Get(int id)
        {
            try
            {
                return connection.Table<User>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void Delete(int UserId)
        {
            try
            {
                User User = Get(UserId);
                connection.Delete(User);

            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
        }
    }
}
