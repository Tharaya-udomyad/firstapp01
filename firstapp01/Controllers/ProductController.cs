using Microsoft.AspNetCore.Mvc;
using firstapp01.Models;
namespace firstapp01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int page=1)
        {
            var Product1 = new Models.Product
            {
                Id = 1,
                Name = "Potato Lay",
                Price = 20.00m,
                Quantity = 100
            };
            var Product2 = new Models.Product
            {
                Id = 02,
                Name = "Lays",
                Price = 22.00m,
                Quantity = 120
            };

            var Product3 = new Models.Product
            {
                Id = 03,
                Name = "Kurkure",
                Price = 10.00m,
                Quantity = 200
            };
            var Product4 = new Models.Product
            {
                Id = 04,
                Name = "coca cola",
                Price = 10.00m,
                Quantity = 200
            };
            var Product5 = new Models.Product
            {
                Id = 05,
                Name = "Oreo",
                Price = 10.00m,
                Quantity = 200
            };
            var Product6 = new Models.Product
            {
                Id = 06,
                Name = "Sandwish",
                Price = 10.00m,
                Quantity = 200
            };
            var Product7 = new Models.Product
            {
                Id = 07,
                Name = "Milk",
                Price = 10.00m,
                Quantity = 200
            };
            var Product8 = new Models.Product
            {
                Id = 08,
                Name = "Kitkat",
                Price = 10.00m,
                Quantity = 200
            };
            var Product9 = new Models.Product
            {
                Id = 09,
                Name = "M&M",
                Price = 10.00m,
                Quantity = 200
            };

            //var Product = new List<Models.Product> { Product1, Product2, Product3, Product4, Product5, Product6, Product7 };
            var Product = new List<Models.Product>();
            Product.Add(Product1);
            Product.Add(Product2);
            Product.Add(Product3);
            Product.Add(Product4);
            Product.Add(Product5);
            Product.Add(Product6);
            Product.Add(Product7);
            Product.Add(Product8);


            //return View(Product);
            //var products = new List<Product>();
            //for (int i = 1; i <= 20; i++)
            //{
            //    products.Add(new Product { Id = i, Name = $"Product {i}", Price = 100 * i, Quantity = ... });
            //}

            // 2. กำหนดขนาดของ Pagination
            int pageSize = 3; // ต้องการแสดงหน้าละกี่รายการ (เช่น 5 รายการต่อหน้า)
            int totalItems = Product.Count;
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // 3. ใช้ LINQ Skip และ Take เพื่อดึงข้อมูลเฉพาะหน้าที่ต้องการ
            var pagedProducts = Product
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // 4. ส่งข้อมูลสำหรับการทำปุ่ม Pagination ไปที่ View
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(pagedProducts);
        }
    }
}