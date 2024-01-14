using FridgeAlert.Data;
using SQLite;

namespace FridgeAlert.Models
{
    [Table("Groceries")]
    public class Groceries : TableData
    {
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }

        public int Amount { get; set; }

    }
}
