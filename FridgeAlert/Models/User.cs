using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace FridgeAlert.Models;

    [Table("UserData")]
public class User
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [SQLite.MaxLength(32), Unique]
    public string UserName { get; set; }
    [MinLength(12)]
    public string Password { get; set; }
    public bool SaveLogin { get; set; }
}
