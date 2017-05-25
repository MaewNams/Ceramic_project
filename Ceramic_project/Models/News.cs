using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class News
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public int newsTypeId { get; set; }

        [InverseProperty("News")]
        public virtual ICollection<NewsPicture> NewsPictures { get; set; }
    }
}