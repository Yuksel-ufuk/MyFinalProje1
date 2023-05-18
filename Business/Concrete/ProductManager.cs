using Business.Abstrac;
using DataAccess.Abstrac;
using DataAccess.Concret.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi varmı?
            return _ProductDal.GetAll();
        }
    }
}
