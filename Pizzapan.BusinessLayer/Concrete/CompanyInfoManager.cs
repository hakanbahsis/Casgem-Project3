using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class CompanyInfoManager : ICompanyInfoService
    {
        private readonly ICompanyInfoDal _companyInfoDal;

        public CompanyInfoManager(ICompanyInfoDal companyInfoDal)
        {
            _companyInfoDal = companyInfoDal;
        }

        public void TAdd(CompanyInfo entity)
        {
            _companyInfoDal.Add(entity);
        }

        public List<CompanyInfo> TGetAll()
        {
            return _companyInfoDal.GetAll();
        }

        public CompanyInfo TGetById(int id)
        {
           return _companyInfoDal.Get(id);
        }

        public void TRemove(CompanyInfo entity)
        {
            _companyInfoDal.Delete(entity);
        }

        public void TUpdate(CompanyInfo entity)
        {
            _companyInfoDal.Update(entity);
        }
    }
}
