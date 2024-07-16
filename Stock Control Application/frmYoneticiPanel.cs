using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Control_Application
{
    public partial class frmYoneticiPanel : Form
    {
        internal string kid;

        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProductsList frmProductsList = new frmProductsList();
            frmProductsList.Show();
        }
    }
}
