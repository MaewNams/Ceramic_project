using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int setId{ get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

        [ForeignKey("setId")]
        public virtual ProductSet ProductSet { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<ProductPicture> ProductPictures { get; set; }
    }
}