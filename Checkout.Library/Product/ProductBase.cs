using Microsoft.Extensions.Configuration;
using System.IO;

namespace Checkout.Library.Product
{
    public abstract class ProductBase
    {
        public IConfiguration Config { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; private set; }
        public int PromotionQuantity { get; private set; }
        public int PromotionPrice { get; private set; }
        public decimal OrderTotal { get { return OrderPrice(); } }

        public virtual decimal Promotion()
        {
            return 0;
        }

        public decimal OrderPrice()
        {
            var orderPrice = Promotion();

            return orderPrice > 0 ? orderPrice : UnitPrice * Quantity;
        }

        public ProductBase()
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var basePath = path.Substring(0, path.IndexOf("Checkout\\") + ("Checkout\\").Length);
            Config = new ConfigurationBuilder()
                .AddJsonFile($"{basePath}Checkout.Library\\productdata.json")
                .Build();
        }

        internal void PopulateProductValues(string unitPriceKey, string productAPromQuantKey, string productAPromPriceKey)
        {
            UnitPrice = int.Parse(Config.GetSection(unitPriceKey).Value);
            PromotionQuantity = int.Parse(Config.GetSection(productAPromQuantKey).Value);
            PromotionPrice = int.Parse(Config.GetSection(productAPromPriceKey).Value);

        }

    }
}
