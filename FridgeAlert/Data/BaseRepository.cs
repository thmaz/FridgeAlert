using SQLiteNetExtensions.Extensions;
using SQLite;

namespace FridgeAlert.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
    {
        SQLiteConnection connection;
        public string? StatusMessage { get; set; }

        public BaseRepository()
        {
            connection = new SQLiteConnection(
                Constants.DatabasePath,
                Constants.flags);
            connection.CreateTable<T>();
        }

        public void DeleteEntitiesWithChildren(T entity)
        {
            try
            {
                connection.Delete(entity, true);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }

        public List<T> GetEntitiesWithChildren()
        {
            try
            {
                return connection.GetAllWithChildren<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public T GetEntity(int id)
        {
            try
            {
                return connection.Table<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void SaveEntityWithChildren(T? entity, bool recursive = false)
        {
            try
            {
                connection.InsertWithChildren(entity, recursive);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }   
        }
    }
}
