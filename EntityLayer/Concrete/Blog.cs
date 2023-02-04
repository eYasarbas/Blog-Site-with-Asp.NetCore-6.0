using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public String BlogTitle { get; set; }
        public String BlogContent { get; set; }
        public String BlogImage { get; set; }
        public String BlogThumbnailImage { get; set; }
        public DateTime BlogDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}