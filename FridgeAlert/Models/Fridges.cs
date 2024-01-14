using FridgeAlert.Data;
using SQLite;

namespace FridgeAlert.Models
{
    [Table("Fridges")]
    public class Fridges : TableData
    {
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }
    }
}
