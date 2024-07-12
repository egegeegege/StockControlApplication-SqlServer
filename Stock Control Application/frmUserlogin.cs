using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Control_Application.Orm.Context;
using Stock_Control_Application.Orm.Entity;

namespace Stock_Control_Application
{
    public partial class frmUserlogin : Form
    {
        ProjectDbContext DataBase = new ProjectDbContext();
        string TC = "";
        string Password = "";
        int id;

        public frmUserlogin()
        {
            InitializeComponent();
        }

        private void linl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup frmSignup = new frmSignup();
            frmSignup.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_TC.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Boş girmeyiniz.");
                return; // burada kullanıcın boş girip girmediğini kontrol etirdim G
            }

            List<User> use = new List<User>();
            use = DataBase.Users.Where(y => y.TC == txt_TC.Text).ToList();

            foreach (User user in use) 
            {
                TC = user.TC.ToString();
                Password = user.Password.ToString();
                id = user.ID;
            }
            if (TC == txt_TC.Text) 
            {
                 
                if (Password == txt_Password.Text)
                {
                    MessageBox.Show("Hoşgeldiniz");
                    frmYoneticiPanel yoneticiPanel = new frmYoneticiPanel();
                    yoneticiPanel.kid = id.ToString();
                    yoneticiPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre hatalı");
                }

            }
            else
            {
                MessageBox.Show("TC Hatalı");
            }
        }
    }
}

