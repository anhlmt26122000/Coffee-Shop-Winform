using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;

        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.iD = iD;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.iD = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];
            var dataCheckoutTemp = row["dateCheckOut"];
            if (dataCheckoutTemp.ToString() != "")
                this.dateCheckOut = (DateTime?)dataCheckoutTemp;
            this.status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
