using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int idCategory;
        private float price;

        public Food(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idCategory"];
            this.price = float.Parse(row["price"].ToString());
        }
        public Food(int iD, string name, int idCategory, float price)
        {
            this.iD = iD;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
