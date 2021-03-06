using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPages.DataBaseModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Cost { get; set; }
        [Required]
        public int Count { get; set; }
        public string FilePath { get; set; }
    }
}
