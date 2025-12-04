using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private FoodDAO() { }

        public List<Food> GetListFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Food WHERE idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
