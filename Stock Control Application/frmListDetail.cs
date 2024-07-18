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
        public int kid;

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
            List<Salle> salles = new List<Salle>();
            salles = db.Salles.ToList();
            bool urunsatılık = false;

            foreach (Salle salle in salles)
            {
                if (salle.ProductID == id)
                {
                    urunsatılık = true;
                }
            }

            if (urunsatılık)
            {
                MessageBox.Show("bu id ye ait satılmış bir ürün zaten var");
            }
            else
            {
                Salle salle = new Salle()
                {
                    ProductID = id,
                    AlisTarihi = DateTime.Now,
                    AktifMi = true,    
                    TeslimTarihi = DateTime.Now,
                    UserID = int.Parse(kid),
                };

                db.Salles.Add(salle);
                db.SaveChanges();
                MessageBox.Show("ürün başarıyla satın alınmıştır");
                this.Hide();
            }
        }
    }
}
