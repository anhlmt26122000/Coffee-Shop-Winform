using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;

        public BillInfo(DataRow row)
        {
            this.iD = (int)row["iD"];
            this.billID = (int)row["idbill"];
            this.foodID = (int)row["idfood"];
            this.count = (int)row["count"];
        }
        public BillInfo(int iD, int billID, int foodID, int count)
        {
            this.iD = iD;
            this.billID = billID;
            this.foodID = foodID;
            this.count = count;
        }

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
