using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class ProductSet
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int picId { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

        [ForeignKey("picId")]
        public virtual Picture Picture { get; set; }


        [InverseProperty("ProductSet")]
        public virtual ICollection<Product> Products { get; set; }
    }
}