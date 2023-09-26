using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public class pruduct_1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
    }

    public class GetCRUD
    {
        private List<pruduct_1> productlist;
        public GetCRUD()
        {
            productlist = new List<pruduct_1>()
            {
            new pruduct_1 { Id = 1, Name = "Laptop", Price = 36000, Company = "HP" },
            new pruduct_1 { Id = 2, Name = "Laptop", Price = 39000, Company = "Dell" }
            };
        }
        public List<pruduct_1> GetProducts()
        {
            return productlist;
        }
        public pruduct_1 GetProductbyId(int id)
        {
            pruduct_1 product = new pruduct_1();
            foreach (pruduct_1 p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        public void AddProduct(pruduct_1 p)
        {
            productlist.Add(p);
        }
        public void UpdateProduct(pruduct_1 p)
        {
            foreach (pruduct_1 item in productlist)
            {

                if (item.Id == p.Id)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;

                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (pruduct_1 item in productlist)
            {
                if (item.Id == id)
                {
                    productlist.Remove(item);
                    break;
                }

            }

        }
    }
}
