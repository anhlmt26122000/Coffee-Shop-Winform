using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM Account WHERE UserName = @username AND PassWord = @password";
            object[] parameter = new object[] { username, password };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameter);
            return result.Rows.Count > 0;
        }
    }
}
