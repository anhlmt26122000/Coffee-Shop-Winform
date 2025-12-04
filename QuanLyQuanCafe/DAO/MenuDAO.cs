using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.name, bi.count, f.price, bi.count * f.price AS totalPrice " +
                           "FROM Bill AS b, BillInfo AS bi, Food AS f " +
                           "WHERE b.id = bi.idBill AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
