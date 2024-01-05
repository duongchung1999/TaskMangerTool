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

namespace TestForm_Mouse_Scroll
{
    public partial class fListPerson : Form
    {
        private UIAdaptiveSize uias;
        string Department = "";
        public fListPerson(string Department)
        {
            this.Department = Department;
            InitializeComponent();
        }

        private void fListPerson_Load(object sender, EventArgs e)
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
            LoadData();
        }

        bool flag1 = false;

        private void fListPerson_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1.HomeFlag = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.HomeFlag == true)
            {
                //Form1.HomeFlag = false;
                timer1.Enabled = false;
                this.Close();
            }
        }
        private void LoadData()
        {
            if(Department == "HW")
            {
                label1.Text = "TE 硬体";
                btnPerson1.Text = "阮文雄";
            }
            if (Department == "SW")
            {
                label1.Text = "TE 软体";
                btnPerson1.Text = "范事东阳";
                btnPerson2.Text = "Notification";
                btnPerson3.Text = "提案改善";
            }
            if (Department == "AE")
            {
                label1.Text = "TE 声学";
            }
            if(!(Department.Contains("HW")|| Department.Contains("SW")|| Department.Contains("AE")))
            {
                label1.Text = Department;
            }
            ControlDisplayButton(btnPerson1);
            ControlDisplayButton(btnPerson2);
            ControlDisplayButton(btnPerson3);
            ControlDisplayButton(btnPerson4);
            ControlDisplayButton(btnPerson5);
            ControlDisplayButton(btnPerson6);
            ControlDisplayButton(btnPerson7);
            ControlDisplayButton(btnPerson8);
        }
        private void ControlDisplayButton(Button btn)
        {
            if (btn.Text.Contains("Person"))
            {
                btn.Enabled = false;
                btn.Hide();
            }
        }

        private void btnPerson1_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson1.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson2_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson2.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson3_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson3.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson4_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson4.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson5_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson5.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnPerson6_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson6.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson7_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson7.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPerson8_Click(object sender, EventArgs e)
        {
            fListTask f = new fListTask(btnPerson8.Text);
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
