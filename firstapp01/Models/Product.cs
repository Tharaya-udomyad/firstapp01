namespace firstapp01.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //กำหนดค่าเริ่มต้นเป็นค่าว่าง
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
