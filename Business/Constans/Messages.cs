using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductnameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime= "Sistem Bakımda";
        internal static string ProductsListed="Ürünler Listelendi";
        internal static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameError = "Aynı isimde ürün verilemez";
        internal static string CategoriesLimitedError = "Kategori limiti aşıldı";
    }
}
