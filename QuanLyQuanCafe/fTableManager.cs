using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Globalization;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Click += btn_Click;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.PaleVioletRed;
                        break;
                }
                flpTable.Controls.Add(btn);
            }

        }
        // Show bill by table id
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            //Get Bill Info <- BillID <- TableID
            List<Menu> listMenu = MenuDAO.Instance.GetListMenuByTable(id);
            //total price of bill
            float totalPrice = 0;
            // Add item to ListView
            foreach (Menu item in listMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice; // calculate total price
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture; // set culture to vietnamese
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }


        #endregion

        #region Events
        private void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int idFood = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            // If there is no bill, create a new bill
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            // If there is a bill, just add food to bill
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Get Table Info
            Table table = lsvBill.Tag as Table;
            // Get Bill ID
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho " + table.Name + " không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Checkout
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }
        #endregion
    }
}
