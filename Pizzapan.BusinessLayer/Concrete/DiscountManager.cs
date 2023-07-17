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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public string CreateDiscountCouponCode(string coupon)
        {
            Random rnd = new Random();
            char[] harf = new char[4]; ;
            string cc = "";
            string rr = "";
            for (int i = 0; i < 4; i++)
            {
                int kod = rnd.Next(65, 91);
                harf[i] += Convert.ToChar(kod);
                cc += harf[i].ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                int a = rnd.Next(0, 9);
                rr += a;
            }
            coupon = cc + rr.ToString();
            return coupon;
        }

        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public List<Discount> TGetAll()
        {
            return _discountDal.GetAll();
        }

        public Discount TGetById(int id)
        {
            return _discountDal.Get(id);
        }

        public void TRemove(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
