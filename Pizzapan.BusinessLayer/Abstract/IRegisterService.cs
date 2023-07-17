using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Abstract
{
    public interface IRegisterService
    {
        void SendMail(string mail,string subject,string body);
    }
}
