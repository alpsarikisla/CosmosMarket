using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosMos_Market
{
    public partial class UserLogin : Form
    {
        bool girisVar = false;
        DataModel dm = new DataModel();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_userName.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                User u = dm.UserLogin(tb_userName.Text, tb_password.Text);
                if (u != null)
                {
                    girisVar = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı", "Sistem Mesajı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Şifre boş bırakılamaz", "Sistem Mesajı");
            }
        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (girisVar == false)
            {
                Application.Exit();
            }
        }
    }
}
