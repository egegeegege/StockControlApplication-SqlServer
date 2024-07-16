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
    public partial class frmAddProduct : Form
    {
        ProjectDbContext Database = new ProjectDbContext();

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btn_ımage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                PB_.Image = new Bitmap(open.FileName);
                filename.Text = open.FileName;
            }
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            string base64;
            using (Image image = PB_.Image.Clone() as Image)
            {
                base64 = ConvertBase64(image);
            }

            Product product = new Product()
            {
                ProductName = txt_product.Text,
                Category = cmb_category.Text,
                Quantity = (int)Convert.ToUInt32(txt_qantity.Text),
                Supplier = txt_supplier.Text,
                Description = txt_description.Text,
                Price = (int)Convert.ToUInt32(txt_price.Text),
                ImageUrl = base64,
                AktifMi = false,
            };
            Database.Products.Add(product);
            Database.SaveChanges();
            MessageBox.Show("Product registration successfully created");

        }

        private string ConvertBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
