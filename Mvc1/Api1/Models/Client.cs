using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api1.Models
{
    public class Client
   {
  
    
    [Required]
        public int ClientId { get; set; }
        public string Name { get; set; }
    public string Email { get; set; }

}
}