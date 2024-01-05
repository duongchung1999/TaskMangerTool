
namespace TestForm_Mouse_Scroll
{
    partial class fListTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnMyTask = new System.Windows.Forms.Button();
            this.btnImprove = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(9, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 43);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "List Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Navy;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(737, 19);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(58, 39);
            this.btnAddTask.TabIndex = 22;
            this.btnAddTask.Text = "添加";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(735, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 39);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNotification.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Location = new System.Drawing.Point(406, 9);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(195, 39);
            this.btnNotification.TabIndex = 15;
            this.btnNotification.Text = "通知";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnMyTask
            // 
            this.btnMyTask.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMyTask.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMyTask.ForeColor = System.Drawing.Color.White;
            this.btnMyTask.Location = new System.Drawing.Point(4, 9);
            this.btnMyTask.Name = "btnMyTask";
            this.btnMyTask.Size = new System.Drawing.Size(195, 39);
            this.btnMyTask.TabIndex = 17;
            this.btnMyTask.Text = "个人任务";
            this.btnMyTask.UseVisualStyleBackColor = false;
            this.btnMyTask.Click += new System.EventHandler(this.btnMyTask_Click);
            // 
            // btnImprove
            // 
            this.btnImprove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImprove.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImprove.ForeColor = System.Drawing.Color.White;
            this.btnImprove.Location = new System.Drawing.Point(205, 9);
            this.btnImprove.Name = "btnImprove";
            this.btnImprove.Size = new System.Drawing.Size(195, 39);
            this.btnImprove.TabIndex = 16;
            this.btnImprove.Text = "提案改善";
            this.btnImprove.UseVisualStyleBackColor = false;
            this.btnImprove.Click += new System.EventHandler(this.btnImprove_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnImprove);
            this.panel10.Controls.Add(this.btnMyTask);
            this.panel10.Controls.Add(this.btnNotification);
            this.panel10.Controls.Add(this.btnHome);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 384);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(800, 52);
            this.panel10.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(793, 310);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(673, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // fListTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "fListTask";
            this.Text = "fListTask";
            this.Load += new System.EventHandler(this.fListTask_Load);
            this.Resize += new System.EventHandler(this.fListTask_Resize);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnMyTask;
        private System.Windows.Forms.Button btnImprove;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}