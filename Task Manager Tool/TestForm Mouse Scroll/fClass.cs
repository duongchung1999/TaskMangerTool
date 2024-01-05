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
using System.Threading;

namespace TestForm_Mouse_Scroll
{
    public partial class fClass : Form
    {
        private UIAdaptiveSize uias;
        public fClass()
        {
            InitializeComponent();
        }
        
        private void fClass_Load(object sender, EventArgs e)
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
            timer1.Start();
            Form1.HomeFlag = false;
        }

        bool flag1 = false;
        private void fClass_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1.HomeFlag = true;
           // this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.HomeFlag == true)
            {
               // Form1.HomeFlag = false;
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHW_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson("HW");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson("SW");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson("AE");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMyTask_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask("MyTask");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnImprove_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask("提案");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask("Notification");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
