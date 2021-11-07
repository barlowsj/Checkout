using Microsoft.Extensions.Configuration;
using System.IO;

namespace Checkout.Library.Product
{
    public abstract class ProductBase
    {
        public IConfiguration Config { get; set; }
        public int Quantity { get; set; }
        public abstract int UnitPrice { get; }
        public abstract int PromotionQuantity { get; }
        public abstract int PromotionPrice { get; }
        public abstract double OrderTotal { get; }

        public double OrderPrice()
        {
            return UnitPrice * Quantity;
        }

        public ProductBase()
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var basePath = path.Substring(0, path.IndexOf("Checkout\\") + ("Checkout\\").Length);
            Config = new ConfigurationBuilder()
                .AddJsonFile($"{basePath}Checkout.Library\\productdata.json")
                .Build();
        }



    }
}
