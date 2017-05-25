using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class NewsPicture
    {
        [Key]
        public int id { get; set; }

        public int picId { get; set; }
        public int newsId { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

        [ForeignKey("picId")]
        public virtual Picture Picture { get; set; }
        [ForeignKey("newsId")]
        public virtual News News { get; set; }
    }
}