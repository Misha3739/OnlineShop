using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OnlineShop.Data
{
    public class Product
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public string Category { get; set; }

        public long CategoryId { get; set; }

    }

}
