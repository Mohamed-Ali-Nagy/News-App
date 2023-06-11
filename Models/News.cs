using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFlabDay2.Models
{
    public class News
    {
        [Key]
        public int News_id { get; set; }
        public string? News_title { get; set; }
        public string? News_reff { get; set; }
        public string? News_desc { get; set; }
        public string? News_photo { get; set; }
        public DateTime? News_date { get; set; }
        [ForeignKey("User")]
        public int? User_id { get; set; }
        [ForeignKey("Category")]
        public int? Cat_id { get; set; }

        public virtual User? User { get; set; }
        public virtual category? Category { get; set; }
    }
}
