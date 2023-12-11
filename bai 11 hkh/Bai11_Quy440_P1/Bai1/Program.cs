using static System.Console;
namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brands = new List<Brand>()
{
 new Brand{ID = 1, Name = "Vingroup"},
 new Brand{ID = 2, Name = "Samsung"},
 new Brand{ID = 3, Name = "FPT"},
};
            var products = new List<Product>()
{
 new Product(1,"O to", 400, new string[] {"Do","Trang","Den"}, 1),
 new Product(2,"Dien thoai",400, new string[] {"Den", "Xanh"}, 2),
 new Product(3,"May giat", 500, new string[] {"Trang"}, 2),
 new Product(4,"Tu lanh", 200, new string[] {"Trang", "Xam"}, 2),
 new Product(5,"Laptop", 300, new string[] {"Xam", "Den", "Do"}, 3),
 new Product(6,"Dieu hoa", 500, new string[] {"Trang"}, 2),
 new Product(7,"Xe may", 600, new string[] {"Trang"}, 1),
};

            // Bài 2.1
            WriteLine("-----Bài 2.1-----");
            var ketqua = from product in products
                         select product;
            //thực thi truy vấn để lấy dữ liệu
            foreach (var product in ketqua)
                WriteLine(product.ToString());

            // Bài 2.2
            WriteLine("\n-----Bài 2.2-----");
            var ketqua2 = products.Select(product => product.Name);
            foreach (var name in ketqua2) WriteLine(name);

            // Bài 2.3
            WriteLine("\n-----Bài 2.3-----");
            var ketqua3 = from product in products
                          select new
                          {
                              ten = product.Name.ToUpper(),
                              mausac = string.Join(',', product.Colors)
                          };
            foreach (var item in ketqua3)
                WriteLine(item.ten + " - " + item.mausac);

            // Bài 2.4
            WriteLine("\n-----Bài 2.4-----");
            var ketqua4 = from product in products
                          where product.Price == 400
                          select product;
            foreach (var product in ketqua4)
                WriteLine(product.ToString());

            // Bài 2.5
            WriteLine("\n-----Bài 2.5-----");
            var ketqua5 = from product in products
                          where (product.Price >= 500 && product.Price < 600) || product.Name.Contains('e')
                          select product;
            foreach (var product in ketqua5)
                WriteLine(product.ToString());


            // Bài 2.6.1
            WriteLine("\n-----Bài 2.6.1-----");
            var ketqua6 = from product in products
                          where product.Price <= 400
                          orderby product.Price descending
                          select product;
            foreach (var product in ketqua6)
                WriteLine($"{product.Name} - {product.Price}");

            // Bài 2.6.2
            WriteLine("\n-----Bài 2.6.2-----");
            var ketqua62 = from product in products
                           where product.Price <= 400
                           orderby product.Price, product.Name descending
                           select product;
            foreach (var product in ketqua)
                WriteLine($"{product.Name} - {product.Price}");

            // Bài 2.7
            WriteLine("\n-----Bài 2.7-----");
            var ketqua7 = from product in products
                          where product.Price <= 500
                          group product by product.Brand;
            foreach (var group in ketqua7)
            {
                WriteLine(group.Key);
                foreach (var product in group)
                {
                    WriteLine($" {product.Name} - {product.Price}");
                }
            }


            // Bài 2.8
            WriteLine("\n-----Bài 2.8-----");
            var ketqua8 = from product in products
                          join brand in brands on product.Brand equals brand.ID
                          select new
                          {
                              name = product.Name,
                              brand = brand.Name,
                              price = product.Price
                          };
            foreach (var item in ketqua8)
            {
                WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }
        }
    }
}
