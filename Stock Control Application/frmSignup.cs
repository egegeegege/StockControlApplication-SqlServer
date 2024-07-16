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
    public partial class frmSignup : Form
    {
        ProjectDbContext DataBase = new ProjectDbContext();
        public frmSignup()
        {
            InitializeComponent();
        }

        private void linl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserlogin frmUserlogin = new frmUserlogin();
            frmUserlogin.Show();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            List<User> use = new List<User>();
            use = DataBase.Users.ToList();
            bool Kullanicivar = false;

            foreach (User user in use)
            {
                if (user.TC == txt_TC.Text)
                {
                    Kullanicivar = true;
                }
            }

            if (Kullanicivar)
            {
                MessageBox.Show("Bu TC ile daha önce kayıtlı bir kullanıcı mevcut");
            }

            else
            {
                User user = new User()
                {
                    TC = txt_TC.Text,
                    Username = txt_username.Text,
                    Telefon = txt_phonenumber.Text,
                    Password = txt_Password.Text,
                    Email = txt_email.Text,
                    Sifre ="1",
                    AktifMi = true
                };

                DataBase.Users.Add(user);
                DataBase.SaveChanges();
                MessageBox.Show("Kayıt başarıyla oluşturuldu");
                this.Hide();
            }
        }
    }
}
