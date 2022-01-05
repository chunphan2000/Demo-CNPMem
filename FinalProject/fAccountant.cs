using FinalProject.DAO;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class fAccountant : Form
    {
        public fAccountant()
        {
            InitializeComponent();

            loadReceptList();
            LoadAddButton();
            LoadCategory();
       
        }

        #region Method
        void LoadCategory()
        {
            List<GoodsCategory> listCategory = GoodsCategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadGoodsListByCategoryID(int id)
        {
            List<Goods> listGoods = GoodsDAO.Instance.GetGoodsByCategoryID(id);
            cbGoods.DataSource = listGoods;
            cbGoods.DisplayMember = "Name";
        }
        void LoadAddButton()
        {
            List<Add> tableList = AddDAO.Instance.LoadAddList();

            foreach (Add item in tableList)
            {
                Button btn = new Button() { Width = AddDAO.TableWidth, Height = AddDAO.TableHeight };
                btn.Text = "Add" ;
                btn.Click += btn_Click;
                btn.Tag = item;

                flpAdd.Controls.Add(btn);
            }
        }
        void ShowImport(int id)
        {
            IsvImport.Items.Clear();
            List<Menuu> listImportInfor = MenuuDAO.Instance.GetListMenuByAdd(id);
            foreach (Menuu item in listImportInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());


                IsvImport.Items.Add(lsvItem);
            }

        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int addID = ((sender as Button).Tag as Add).ID;
            ShowImport(addID);
        }
        void loadReceptList()
        {
            //string query = "SELECT * FROM dbo.IMPORT_BILLINFOR";
            //DAO.DataProvider dataProvider = new DAO.DataProvider();

            //dtgv1.DataSource = dataProvider.ExcuteQuery(query);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPMDataSet.ACCOUNTANT' table. You can move, or remove it, as needed.
           //this.aCCOUNTANTTableAdapter.Fill(this.cNPMDataSet.ACCOUNTANT);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        #endregion

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            GoodsCategory selected = cb.SelectedItem as GoodsCategory;
            id = selected.ID;

            LoadGoodsListByCategoryID(id);
        }

        private void btnAddToImport_Click(object sender, EventArgs e)
        {
            /*Table table = IsvImport.Tag as Table;

            int iDImport = ImportDAO.Instance.GetUncheckImportIDByAddID(table.ID);
            int foodID = (cbGoods.SelectedItem as Goods).ID;
            int count = (int)nmFoodCount.Value;

            if (iDImport == -1)
            {
                ImportDAO.Instance.InsertBill(table.ID);
                ImportInforDAO.Instance.InsertBillInfo(ImportDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                ImportInforDAO.Instance.InsertBillInfo(iDImport, foodID, count);
            }

            ShowImport(table.ID);*/
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }

   
}
