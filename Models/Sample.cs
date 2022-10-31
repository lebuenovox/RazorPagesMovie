using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }
                
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MyValue { get; set; }

    }
}
