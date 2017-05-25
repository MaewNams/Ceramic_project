using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class Picture
    {
        public int id { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public DateTime createDate { get; set; }

        [InverseProperty("Picture")]
        public virtual ICollection<ProductPicture> ProductPictures { get; set; }

        [InverseProperty("Picture")]
        public virtual ICollection<NewsPicture> NewsPictures { get; set; }
    }
}