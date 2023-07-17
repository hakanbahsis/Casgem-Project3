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
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void TAdd(ProductImages entity)
        {
            _productImageDal.Add(entity);
        }

        public List<ProductImages> TGetAll()
        {
            return _productImageDal.GetAll();
        }

        public ProductImages TGetById(int id)
        {
           return _productImageDal.Get(id);
        }

        public void TRemove(ProductImages entity)
        {
            _productImageDal.Delete(entity);
        }

        public void TUpdate(ProductImages entity)
        {
           _productImageDal.Update(entity);
        }
    }
}
