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
    public partial class Form1 : Form
    {
        private UIAdaptiveSize uias;
        public static bool HomeFlag { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }
        public string[] GetDllInfo()
        {
            string dllname = "DLL 名称       ：MEVN_TeamWork_Manager";
            string dllfunction = "Dll功能说明 ：弹出窗体，串口调试";
            string dllVersion = "当前Dll版本：23.05.31.0";
            string dllChangeInfo = "Dll改动信息：";
            string dllChangeInfo1 = "23.05.31.0：第一版";
            string dllChangeInfo2 = "----：第二版";



            string[] info = { dllname, dllfunction,
                dllVersion,
                dllChangeInfo,
                dllChangeInfo1,
                dllChangeInfo2
            };


            return info;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HomeFlag = false;
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
            try
            {
                LoadData();
            }
            catch
            {

            }
        }
        bool flag1 = false;
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void LoadData()
        {
            foreach(string info in GetDllInfo())
            {
                info.Split('：');
            }
            btnDepartment1.Text = "TE";
            btnDepartment2.Text = "EE";
            btnDepartmen3.Text = "PE";
            btnDepartmen4.Text = "ME";
            btnDepartmen5.Text = "PKG";
            DisplayControlButton(btnDepartment1);
            DisplayControlButton(btnDepartment2);
            DisplayControlButton(btnDepartmen3);
            DisplayControlButton(btnDepartmen4);
            DisplayControlButton(btnDepartmen5);
            DisplayControlButton(btnDepartment6);
        }
        private void DisplayControlButton(Button btn)
        {
            if (btn.Text.Contains("部门"))
            {
                btn.Enabled = false;
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.DarkOrange;
                btn.Hide();
            }
        }
        private void btnDepartment1_Click(object sender, EventArgs e)
        {
            if (btnDepartment1.Text.Contains("TE"))
            {
                fClass f = new fClass();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                fListPerson f = new fListPerson(btnDepartment1.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnDepartment2_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson(btnDepartment2.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDepartmen3_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson(btnDepartmen3.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDepartmen4_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson(btnDepartmen4.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDepartmen5_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson(btnDepartmen5.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDepartment6_Click(object sender, EventArgs e)
        {
            fListPerson f = new fListPerson(btnDepartment6.Text);
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
