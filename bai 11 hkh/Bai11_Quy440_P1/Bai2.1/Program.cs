
namespace Bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ketqua = from product in products
                         select product;
            //thực thi truy vấn để lấy dữ liệu
            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());

        }
    }
}
