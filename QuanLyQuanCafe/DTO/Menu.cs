using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public Menu(DataRow row)
        {
            this.foodName = row["name"].ToString();
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"]);
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"]);
        }
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
