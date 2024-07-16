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
using Stock_Control_Application.Orm.Context;

namespace Stock_Control_Application
{
    public partial class frmProductsList : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public string kid;
        public int id;
        public string ImageBase64;
        ProjectDbContext db = new ProjectDbContext();
        public frmProductsList()
        {
            InitializeComponent();
        }

        void verigetir()
        {
            baglanti = new SqlConnection("Server=.;Initial Catalog=StockControlApplication;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Products", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv_productList.DataSource = tablo;
            baglanti.Close();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            verigetir();
            dgv_productList.DefaultCellStyle.BackColor = Color.LightBlue;
            dgv_productList.DefaultCellStyle.ForeColor = Color.Black;
            dgv_productList.DefaultCellStyle.Font = new Font("Arial", 10);

            dgv_productList.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
            dgv_productList.Columns[0].HeaderCell.Style.ForeColor = Color.White;

            dgv_productList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv_productList.EnableHeadersVisualStyles = false;

            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_productList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmListDetail frmListDetail = new frmListDetail();
            frmListDetail.kid = kid;
            id = int.Parse(dgv_productList.CurrentRow.Cells[0].Value.ToString());
            ImageBase64 = db.Products.Where(a => a.ID == id).First().ImageUrl.ToString();
            frmListDetail.id = id;
            frmListDetail.base64Image = ImageBase64;
            frmListDetail.Show();
        }
    }
}
