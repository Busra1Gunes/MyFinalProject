using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel.Design;

namespace ConsoleUI
{
    class Program
    {
        //Dto Data Transformation Object
        //SOLID
        //Open Closed  Princeple
        private static void Main(string[] args)
        {
            ProductTest();
            // CategroryTest();

        }

        private static void CategroryTest()
        {
            CategoryManager categorymanager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categorymanager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

                }

            }
            else 
            {
                Console.WriteLine(result.Message); 
            }

        }
    }

}
