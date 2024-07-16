using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Control_Application.Orm.Context;
using Stock_Control_Application.Orm.Entity;

namespace Stock_Control_Application
{
    public partial class frmListDetail : Form
    {
        public int id;
        public string base64Image;

        ProjectDbContext db = new ProjectDbContext();

        public frmListDetail()
        {
            InitializeComponent();
        }

        private void frmListDetail_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = db.Products.Where(a => a.ID == id).ToList();

            foreach (var product in products)
            {
                lbl_category.Text = product.Category.ToString();
                lbl_description.Text = product.Description.ToString();
                lbl_price.Text = product.Price.ToString();
                lbl_Productname.Text = product.ProductName.ToString();
                lbl_quantity.Text = product.Quantity.ToString();
                lbl_supplier.Text = product.Supplier.ToString();
                pb_ımage.Image = ConvertBase64ToImage(product.ImageUrl);
            }
        }

        private Image ConvertBase64ToImage(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            Product arabaVarmi = db.Products.Where(a => a.ID == id && a.AktifMi == true).FirstOrDefault();
            Product arabalar = db.Products.Where(a => a.ID == id).FirstOrDefault();

            if (arabaVarmi != null)
            {
                MessageBox.Show("Seçtiğiniz araba şuan kiralık durumda");
            }
            else
            {
                Salle salles = new Salle
                {
                    ProductID = id,
                    AktifMi = false,
                    AddDate = DateTime.Now,
                    AlisTarihi = DateTime.Now,
                    TeslimTarihi = DateTime.Now,
                    UserID = id, //hata burada 
                };

                arabalar.AktifMi = true;
                db.Salles.Add(salles);
                db.SaveChanges();
                MessageBox.Show("Araç Kiralandı");
                this.Hide();
            }
        }


       
    }
}
