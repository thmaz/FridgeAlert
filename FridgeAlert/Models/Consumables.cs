using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAlert.Models
{
    class Consumables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiresOn { get; set; } 
        public bool IsDrink{ get; set; }
        public bool IsFood { get; set; }
    }
}
