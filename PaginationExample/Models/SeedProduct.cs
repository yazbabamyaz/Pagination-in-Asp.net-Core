namespace PaginationExample.Models
{
    public static class SeedProduct
    {
        public static List<Product> GetAll() 
        {
            List<Product> products = new()
            {
                new Product {Id=1, Name="Product 1", Price=100},
                new Product {Id=2, Name="Product 2", Price=200},
                new Product {Id=3, Name="Product 3", Price=300},
                new Product {Id=4, Name="Product 4", Price=400},
                new Product {Id=5, Name="Product 5", Price=500},
                new Product {Id=6, Name="Product 6", Price=600},
                new Product {Id=7, Name="Product 7", Price=700},
                new Product {Id=8, Name="Product 8", Price=800},
                new Product {Id=9, Name="Product 9", Price=900},
                new Product {Id=10, Name="Product 10", Price=1000},
                new Product {Id=11, Name="Product 11", Price=2000},
                new Product {Id=12, Name="Product 12", Price=3000}
            };
            return products;
        }
    }
}
