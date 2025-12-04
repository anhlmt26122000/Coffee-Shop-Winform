using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = @id AND status = 0", new object[] { id });
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { idTable });
        }

        public void CheckOut(int idBill)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_CheckOut @idBill", new object[] { idBill });
        }
    }
}
