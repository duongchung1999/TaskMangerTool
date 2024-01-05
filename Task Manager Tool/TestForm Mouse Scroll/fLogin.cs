using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerryTest.Entity;
using SQL_Test;

namespace TestForm_Mouse_Scroll
{
    public partial class fLogin : Form
    {
        UIAdaptiveSize uias;
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            uias = new UIAdaptiveSize
            {
                Width = Width,
                Height = Height,
                FormsName = this.Text,
                X = Width,
            };
            uias.SetInitSize(this);
            flag1 = true;
            this.WindowState = FormWindowState.Maximized;
            label1.Focus();
            lbLoginCheck.Hide();
        }
        bool flag1 = false;

        private void fLogin_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void txbUser_Click(object sender, EventArgs e)
        {
            if(txbUser.Text == "用户名")
            {
                txbUser.Text = "";
            }
            if(txbPassword.Text == "")
            {
                txbPassword.Text = "密码";
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "用户名";
            }
            if (txbPassword.Text == "密码")
            {
                txbPassword.Text = "";
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void Refresh()
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "用户名";
            }
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "密码";
                txbPassword.UseSystemPasswordChar = false;
            }
        }
        private void fLogin_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Refresh();
            CheckUser();
        }
        private void CheckUser()
        {
            var user = txbUser.Text;
            var password = txbPassword.Text;
            if (LoadUser(user, password))
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else lbLoginCheck.Show();
        }
        private bool LoadUser(string user, string password)
        {
            if (!(user.Contains("91204127")))
                return false;
            return true;
        }

    }
}
