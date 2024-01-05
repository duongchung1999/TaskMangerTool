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
    public partial class fListTask : Form
    {
        UIAdaptiveSize uias;
        string action;
        public fListTask(string action)
        {
            this.action = action;
            InitializeComponent();
        }

        private void fListTask_Load(object sender, EventArgs e)
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
            //panel1.Enabled = true;
        }
        bool flag1 = false;
        private void fListTask_Resize(object sender, EventArgs e)
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
            if (!(action.Contains("提案") || action.Contains("Notification") || action.Contains("MyTask")))
            {
                StaffTask();
            }
            else if ((action.Contains("提案")))
            {
                Improve();
            }
            else if ((action.Contains("Notification")))
            {
                Notification();
            }
            else MyTask();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form1.HomeFlag = true;
        }

        int CountTask = 0;
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            fAddTask f = new fAddTask(label1.Text);
            //this.Hide();
            f.ShowDialog();
            if (f.flagSave)
            {
                MessageBox.Show("OK");
                LoadData();
            }
           // this.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fAddTask f = new fAddTask("Update");
            //this.Hide();
            f.ShowDialog();
            if (f.flagSave)
            {
                MessageBox.Show("OK");
                LoadData();
            }
        }
        private void Notification()
        {
            btnAddTask.Hide();
            label1.Text = "通知";
            btnNotification.Enabled = false;
            btnMyTask.Enabled = true;
            btnImprove.Enabled = true;
            btnNotification.BackColor = Color.Gray;
            btnMyTask.BackColor = Color.DarkOrange;
            btnImprove.BackColor = Color.DarkOrange;
        }
        private void Improve()
        {
            btnAddTask.Show();
            label1.Text = "提案改善";
            btnNotification.Enabled = true;
            btnMyTask.Enabled = true;
            btnImprove.Enabled = false;
            btnNotification.BackColor = Color.DarkOrange;
            btnMyTask.BackColor = Color.DarkOrange;
            btnImprove.BackColor = Color.Gray;
        }
        private void MyTask()
        {
            btnAddTask.Show();
            label1.Text = "My Task";
            btnNotification.Enabled = true;
            btnMyTask.Enabled = false;
            btnImprove.Enabled = true;
            btnNotification.BackColor = Color.DarkOrange;
            btnMyTask.BackColor = Color.Gray;
            btnImprove.BackColor = Color.DarkOrange;
        }
        private void StaffTask()
        {
            btnAddTask.Hide();
            label1.Text = action + "的任务";
            btnNotification.Enabled = true;
            btnMyTask.Enabled = true;
            btnImprove.Enabled = true;
            btnNotification.BackColor = Color.DarkOrange;
            btnMyTask.BackColor = Color.DarkOrange;
            btnImprove.BackColor = Color.DarkOrange;
        }
        private void btnNotification_Click(object sender, EventArgs e)
        {
            Notification();
            action = "Notification";
            LoadData();
        }

        private void btnImprove_Click(object sender, EventArgs e)
        {
            Improve();
            action = "提案";
            LoadData();
        }

        private void btnMyTask_Click(object sender, EventArgs e)
        {
            MyTask();
            action = "MyTask";
            LoadData();
        }

        
    }
}
