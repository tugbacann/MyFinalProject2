﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServise
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max); //bu fiyat aralığındaki ürünleri göster.
        List<ProductDetailDto> GetProductDetails();


    }
}
