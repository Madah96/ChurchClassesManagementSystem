namespace ChurchClassesManagementSystem
{
    partial class frmAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalytics));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            button3 = new Button();
            PnlNav = new Panel();
            btnSettings = new Button();
            btnContactUs = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel9 = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            btnLoad = new Button();
            dtFromDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dtToDate = new DateTimePicker();
            label3 = new Label();
            lblTotal = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            dtFromDate1 = new DateTimePicker();
            dtToDate1 = new DateTimePicker();
            btnLoadStudents = new Button();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 41);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(52, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 1;
            label2.Text = "Analytics";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(button3);
            panel8.Controls.Add(PnlNav);
            panel8.Controls.Add(btnSettings);
            panel8.Controls.Add(btnContactUs);
            panel8.Controls.Add(btnAnalytics);
            panel8.Controls.Add(btnDashboard);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 41);
            panel8.Name = "panel8";
            panel8.Size = new Size(181, 536);
            panel8.TabIndex = 43;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 264);
            button3.Name = "button3";
            button3.Size = new Size(181, 42);
            button3.TabIndex = 45;
            button3.Text = "Main Menu";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(0, 193);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
            PnlNav.TabIndex = 43;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 607);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(181, 42);
            btnSettings.TabIndex = 44;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            btnContactUs.Dock = DockStyle.Top;
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.White;
            btnContactUs.Image = (Image)resources.GetObject("btnContactUs.Image");
            btnContactUs.Location = new Point(0, 222);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(181, 42);
            btnContactUs.TabIndex = 44;
            btnContactUs.Text = "Registration";
            btnContactUs.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContactUs.UseVisualStyleBackColor = true;
            btnContactUs.Click += btnContactUs_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.Image = (Image)resources.GetObject("btnAnalytics.Image");
            btnAnalytics.Location = new Point(0, 180);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.RightToLeft = RightToLeft.No;
            btnAnalytics.Size = new Size(181, 42);
            btnAnalytics.TabIndex = 44;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(0, 138);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(181, 42);
            btnDashboard.TabIndex = 44;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label6);
            panel9.Controls.Add(pictureBox4);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(181, 138);
            panel9.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 97);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 44;
            label6.Text = "Admin";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(52, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Magenta;
            btnLoad.Location = new Point(365, 138);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 44;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtFromDate
            // 
            dtFromDate.Format = DateTimePickerFormat.Short;
            dtFromDate.Location = new Point(365, 77);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(132, 23);
            dtFromDate.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(281, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(595, 301);
            dataGridView1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 77);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 47;
            label1.Text = "From date";
            // 
            // dtToDate
            // 
            dtToDate.Format = DateTimePickerFormat.Short;
            dtToDate.Location = new Point(365, 109);
            dtToDate.Name = "dtToDate";
            dtToDate.Size = new Size(132, 23);
            dtToDate.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 109);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 47;
            label3.Text = "To date";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(281, 475);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 16);
            lblTotal.TabIndex = 47;
            lblTotal.Text = "Total records. ???";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(744, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(281, 50);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 49;
            label4.Text = "Attendance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(675, 44);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 49;
            label5.Text = "Class";
            // 
            // dtFromDate1
            // 
            dtFromDate1.Format = DateTimePickerFormat.Short;
            dtFromDate1.Location = new Point(744, 76);
            dtFromDate1.Name = "dtFromDate1";
            dtFromDate1.Size = new Size(132, 23);
            dtFromDate1.TabIndex = 45;
            // 
            // dtToDate1
            // 
            dtToDate1.Format = DateTimePickerFormat.Short;
            dtToDate1.Location = new Point(744, 103);
            dtToDate1.Name = "dtToDate1";
            dtToDate1.Size = new Size(132, 23);
            dtToDate1.TabIndex = 45;
            // 
            // btnLoadStudents
            // 
            btnLoadStudents.BackColor = Color.Magenta;
            btnLoadStudents.Location = new Point(744, 132);
            btnLoadStudents.Name = "btnLoadStudents";
            btnLoadStudents.Size = new Size(75, 23);
            btnLoadStudents.TabIndex = 50;
            btnLoadStudents.Text = "Students";
            btnLoadStudents.UseVisualStyleBackColor = false;
            btnLoadStudents.Click += btnLoadStudents_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(675, 77);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 47;
            label7.Text = "From date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(675, 109);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 47;
            label8.Text = "To date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(584, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 100);
            panel2.TabIndex = 51;
            // 
            // button1
            // 
            button1.Location = new Point(763, 470);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 52;
            button1.Text = "Export to Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 577);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(btnLoadStudents);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dtToDate1);
            Controls.Add(dtFromDate1);
            Controls.Add(dtToDate);
            Controls.Add(dtFromDate);
            Controls.Add(btnLoad);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analytics";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Button button3;
        private Panel PnlNav;
        private Button btnSettings;
        private Button btnContactUs;
        private Button btnAnalytics;
        private Button btnDashboard;
        private Panel panel9;
        private Label label6;
        private PictureBox pictureBox4;
        private Button btnLoad;
        private DateTimePicker dtFromDate;
        private DataGridView dataGridView1;
        private Label label1;
        private DateTimePicker dtToDate;
        private Label label3;
        private Label lblTotal;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private DateTimePicker dtFromDate1;
        private DateTimePicker dtToDate1;
        private Button btnLoadStudents;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private Button button1;
    }
}