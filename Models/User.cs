using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFlabDay2.Models
{
    public class User
    {
        [Key]
        public int User_id { get; set; }
        public string? User_name { get; set; }
        public int? User_password { get; set; }
        public string? User_email { get; set; }
        public string? User_photo { get; set; }
        public int? User_age { get; set;}
        public string? User_add { get; set;}
        public virtual List<News>? News { get; set; } = new List<News>();
        
    }
}
