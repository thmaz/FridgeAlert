using FridgeAlert.Data;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace FridgeAlert.Models
{
    [Table("Consumables")]
    public class Consumables : TableData
    {
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public bool IsDrink { get; set; }
        public bool IsFood { get; set; }
        [ForeignKey(typeof(Fridges))]
        public int FridgeId { get; set; }
    }
}
