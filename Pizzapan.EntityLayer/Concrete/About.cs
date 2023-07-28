using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubDescription { get; set; }
        public string LeftImageUrl { get; set; }
        public string RightImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public bool Status { get; set; }
    }
}
