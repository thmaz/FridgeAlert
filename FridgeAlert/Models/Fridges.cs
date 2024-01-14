using SQLite;

namespace FridgeAlert.Models
{
    [Table("Fridges")]
    public class Fridges
    {
        [PrimaryKey]
        public int Id { get; set; }
        [Column("name"), Indexed]
        public string Name { get; set; }
    }
}
