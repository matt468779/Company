using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    internal class MaterialReceiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string from { get; set; }
        public DateTime date { get; set; }
        public User purchaser { get; set; }
        public User approvedBy { get; set; }
        public User receivedBy { get; set; }
        public virtual List<ItemQuantity> itemQuantities { get; set; }

    }
}
