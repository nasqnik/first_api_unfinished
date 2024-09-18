using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now.ToUniversalTime(); // whenever the comments is created it will be set to the actual time
        public int? StockId { get; set; } // the key
        public Stock? Stock { get; set; } // navigation property
    }
}