using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class CompanyInfo
    {
        public int CompanyInfoId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string OpenningDay { get; set; }
        public string OpenningHours { get; set; }
        public string MapInfo { get; set; }
    }
}
