﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrac
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
