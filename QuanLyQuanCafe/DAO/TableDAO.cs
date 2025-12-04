using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public static int TableWidth = 85;
        public static int TableHeight = 85;
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            //Select * from Table
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            //set data from data table to table list
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
