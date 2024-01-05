using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm_Mouse_Scroll
{
    public partial class fAddTask : Form
    {
        public bool flagSave = false;
        string task;
        public fAddTask(string task)
        {
            this.task = task;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("发送给Leader跟配合者", "提醒", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                flagSave = true;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAddTask_Load(object sender, EventArgs e)
        {
            flagSave = false;
            if (task.Contains("提案"))
            {
                label1.Text = "添加提案改善";
            }
            if (task.Contains("My Task"))
            {
                label1.Text = "添加任务";
            }
            if (task.Contains("Update"))
            {
                label1.Text = "更新任务";
            }
        }

        private void rtbTask1_Click(object sender, EventArgs e)
        {
            if (rtbTask1.Text.Contains("输入任务"))
            {
                rtbTask1.Text = "";
            }
        }
    }
}
