namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new() { Id = 1, Name = "Product 1", Price = 100, Stock = 15 },
            new() { Id = 2, Name = "Product 2", Price = 200, Stock = 45 },
            new() { Id = 3, Name = "Product 3", Price = 300, Stock = 25 },
        };

        public List<Product> GetAll() => _products;
        public void Add(Product product) => _products.Add(product);
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == id);
            if (hasProduct is null)
            {
                throw new Exception($"Bu Id({id}) ye sahip bir ürün yok.");
            }
            _products.Remove(hasProduct);
        }
        public void Update(Product product)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (hasProduct is null)
            {
                throw new Exception($"Bu Id({product.Id}) ye sahip bir ürün yok.");
            }
            hasProduct.Name = product.Name;
            hasProduct.Price = product.Price;
            hasProduct.Stock = product.Stock;

            var index = _products.FindIndex(p => p.Id == product.Id);
            _products[index] = hasProduct;
        }
    }
}