using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstrac
{
    //interfacenin operasyonları "public" dir
    public interface IProductDal //interface ,ürün ,katman kodu
    {//veri tabanına
        List<Product> GetAll(); //"GetAll" hepsini getir demek    
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
