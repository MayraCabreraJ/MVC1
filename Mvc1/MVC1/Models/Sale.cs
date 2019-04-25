using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Sale
    {

        [Key]
        public int SaleID { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
       [ForeignKey("Client")]
        public int ClientId { get; set; }
        [Required]
        public DateTime Date { get; set; }
       public virtual Product Product { get; set; }
        public virtual Client Client { get; set; }
    }
}