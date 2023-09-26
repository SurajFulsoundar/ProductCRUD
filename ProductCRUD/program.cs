using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    internal class program
    {
        static void Main(string[] args)
        {
            GetCRUD crud = new GetCRUD();
            int no = 0;
            do
            {

                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<pruduct_1> list = crud.GetProducts();
                        Console.WriteLine("Id \t Name \t Price \t Company");
                        foreach (pruduct_1 p in list)
                        {
                            Console.WriteLine($"{p.Id} \t {p.Name}\t {p.Price}\t {p.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Id want to display");
                        int id = Convert.ToInt32(Console.ReadLine());
                        pruduct_1 p1 = crud.GetProductbyId(id);
                        Console.WriteLine("Id \t Name \t   Price \t   Company");
                        Console.WriteLine($"{p1.Id} \t{p1.Name} \t{p1.Price} \t{p1.Company}");
                        break;
                    case 3:
                        pruduct_1 p2 = new pruduct_1();
                        Console.WriteLine("Enter product id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name");
                        p2.Company = Console.ReadLine();
                        crud.AddProduct(p2);
                        Console.WriteLine("product saved..");
                        break;
                    case 4:

                        pruduct_1 p3 = new pruduct_1();
                        Console.WriteLine("Enter product id");
                        p3.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p3.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p3.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name");
                        p3.Company = Console.ReadLine();
                        crud.UpdateProduct(p3);
                        Console.WriteLine("product updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter the product id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id2);
                        Console.WriteLine($"{id2} product deleted..");

                        break;

                }
                Console.WriteLine("Press 1 for contine");
                no = Convert.ToInt32(Console.ReadLine());

            }
            while (no == 1);

        }
    }
}
