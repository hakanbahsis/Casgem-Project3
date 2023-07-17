﻿using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Abstract
{
    public interface IDiscountService:IGenericService<Discount>
    {
        string CreateDiscountCouponCode(string coupon);
    }
}
