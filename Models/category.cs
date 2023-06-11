using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFlabDay2.Models
{
    public class category
    {
        [Key]
        public int St_id { get; set; }
        public string? St_name { get; set; }
        public string? St_desc { get; set; }
        public virtual List<News>? News { get; set; } = new List<News>();

    }
}
