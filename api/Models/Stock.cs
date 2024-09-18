using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // For databases

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; } // prop + TAB; to uniquely identify the data
        public string Symbol { get; set; } = string.Empty; // word; putting string.Empty to not get a "null reference errors"
        public string CompanyName { get; set; } = string.Empty; 

        [Column(TypeName = "decimal(18,2)")] // for database ,to set the column to the monetary amount
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18,2)")] // for database ,to set the column to the monetary amount
        public decimal LastDiv { get; set; }

        public string Industry  { get; set; } = string.Empty;
        public long MarketCap { get; set; } 
        public List<Comment> Comments { get; set; } = new List<Comment>();
        
    }
}