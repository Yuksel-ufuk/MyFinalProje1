using DataAccess.Abstrac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret.InMemory
{   
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _Products;          //bu class için global
        public InMemoryProductDal()
        {
            //oracle,sql server, postgres, mongodb verikaynagından geliyor gibi ekleme yapılıyor
            _Products = new List<Product> //Ürünleri barındıran liste
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
                
        }
        public void Add(Product product)
        {
            _Products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ -Language Integrated Query // liste bazlı yapıları SQL gibi fitrelemek için
            //"=>" Lambda deniliyor 
            Product productToDelete = _Products.SingleOrDefault(p=>p.ProductId ==product.ProductId);  // tek basına referans tipi silmez  //9 satır yukarıdakı " foreach (var p in _Products)" bunu içeriyor
            //                                 .Metot    (isim"p"=>".ProductId ==product.ProductId"); kural demek silme kuşulu
            // bu tür operasyonlarda "LINQ" kulanılmalı 
            _Products.Remove(productToDelete); 
        }

        public List<Product> GetAll()
        {
            return _Products; //"return _Products;" veri tabanını oldugu gibi döndürmek 
        }
        public void Update(Product product)
        {
            //gönderdigim ürün Idi sine sahip olan listedeki ürünü bul demek
            Product productToUpdate = _Products.SingleOrDefault(p => p.ProductId == product.ProductId);  // tek basına referans tipi silmez  //9 satır yukarıdakı " foreach (var p in _Products)" bunu içeriyor
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _Products.Where(p => p.CategoryId == categoryId).ToList();
        }       
    }
}
