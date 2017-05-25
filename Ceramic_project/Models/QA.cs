using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seramic_project.Models
{
    public class QA
    {
        public int id { get; set; }
        public string answer { get; set; }
        public string question  { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}