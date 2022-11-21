using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace RazorPagesMovie.Dto
{
    public class SampleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }       
        public decimal MyValue { get; set; }
    }
}
