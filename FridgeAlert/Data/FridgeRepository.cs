//using FridgeAlert.Data;
//using FridgeAlert.Models;
//using SQLite;

//namespace sqlite
//{
//    public class FridgeRepository
//    {
//        SQLiteConnection connection;
//        public string? StatusMessage { get; set; }

//        public FridgeRepository()
//        {
//            connection = new SQLiteConnection(
//                //Constants.DatabasePath,
//                Constants.flags);
//            connection.CreateTable<Fridges>();
//        }

//        public void AddOrUpdate(Fridges fridges)
//        {
//            int result = 0;
//            try
//            {
//                if (fridges.Id != 0)
//                {
//                    result = connection.Update(fridges);
//                    StatusMessage = $"{result} Rows updated";
//                }
//                else
//                {
//                    result = connection.Insert(fridges);
//                    StatusMessage = $"{result} Rows(s) added";

//                }
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//        }

//        public List<Fridges> GetAll()
//        {
//            try
//            {
//                return connection.Table<Fridges>().ToList();
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//            return null;
//        }

//        public Fridges? Get(int id)
//        {
//            try
//            {
//                return connection.Table<Fridges>().FirstOrDefault(x => x.Id == id);
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//            return null;
//        }

//        public void Delete(int fridgeId)
//        {
//            try
//            {
//                Fridges fridges = Get(fridgeId);
//                connection.Delete(fridges);

//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//        }
//    }
//}
