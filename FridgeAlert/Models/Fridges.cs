using FridgeAlert.Data;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace FridgeAlert.Models
{
    [Table("Fridges")]
    public class Fridges : TableData
    {
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }
        public int Amount { get; set; }
        public string PurchaseDate { get; set; }
        public bool isDrink { get; set; }
    }
}
