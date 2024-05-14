namespace ChurchClassesManagementSystem
{
    partial class Finances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finances));
            TitheTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            FinanceDGV = new DataGridView();
            panel1 = new Panel();
            label10 = new Label();
            pictureBox10 = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            button5 = new Button();
            button3 = new Button();
            PnlNav = new Panel();
            btnSettings = new Button();
            button2 = new Button();
            button1 = new Button();
            btnContactUs = new Button();
            btnCalendar = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel7 = new Panel();
            label9 = new Label();
            pictureBox9 = new PictureBox();
            lblTotal = new Label();
            ClassIdCb = new ComboBox();
            OfferingTb = new TextBox();
            ClassNameCb = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)FinanceDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // TitheTb
            // 
            TitheTb.Location = new Point(615, 84);
            TitheTb.Name = "TitheTb";
            TitheTb.Size = new Size(100, 23);
            TitheTb.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 66);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 46;
            label1.Text = "Class Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(751, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 46;
            label2.Text = "Offering Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 66);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 46;
            label3.Text = "Tithe Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 66);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 46;
            label4.Text = "Class Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DarkRed;
            DeleteBtn.ForeColor = SystemColors.ControlLight;
            DeleteBtn.Location = new Point(684, 138);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(99, 31);
            DeleteBtn.TabIndex = 48;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.DarkRed;
            EditBtn.ForeColor = SystemColors.ControlLight;
            EditBtn.Location = new Point(532, 138);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(99, 31);
            EditBtn.TabIndex = 49;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkRed;
            AddBtn.ForeColor = SystemColors.ControlLight;
            AddBtn.Location = new Point(383, 138);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(99, 31);
            AddBtn.TabIndex = 50;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // FinanceDGV
            // 
            FinanceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FinanceDGV.Location = new Point(263, 191);
            FinanceDGV.Name = "FinanceDGV";
            FinanceDGV.RowTemplate.Height = 25;
            FinanceDGV.Size = new Size(652, 327);
            FinanceDGV.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 44);
            panel1.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(54, 9);
            label10.Name = "label10";
            label10.Size = new Size(76, 18);
            label10.TabIndex = 7;
            label10.Text = "Finances";
            // 
            // pictureBox10
            // 
            pictureBox10.Dock = DockStyle.Left;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.ImeMode = ImeMode.NoControl;
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 44);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(421, 9);
            label6.Name = "label6";
            label6.Size = new Size(190, 19);
            label6.TabIndex = 1;
            label6.Text = "Mvama Church Classes";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(PnlNav);
            panel6.Controls.Add(btnSettings);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(btnContactUs);
            panel6.Controls.Add(btnCalendar);
            panel6.Controls.Add(btnAnalytics);
            panel6.Controls.Add(btnDashboard);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 533);
            panel6.TabIndex = 53;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 432);
            button5.Name = "button5";
            button5.Size = new Size(181, 42);
            button5.TabIndex = 46;
            button5.Text = "Resources";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 390);
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
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 348);
            button2.Name = "button2";
            button2.Size = new Size(181, 42);
            button2.TabIndex = 44;
            button2.Text = "Virtual Class";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 306);
            button1.Name = "button1";
            button1.Size = new Size(181, 42);
            button1.TabIndex = 44;
            button1.Text = "Events";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnContactUs
            // 
            btnContactUs.Dock = DockStyle.Top;
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.White;
            btnContactUs.Image = (Image)resources.GetObject("btnContactUs.Image");
            btnContactUs.Location = new Point(0, 264);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(181, 42);
            btnContactUs.TabIndex = 44;
            btnContactUs.Text = "Teachers";
            btnContactUs.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContactUs.UseVisualStyleBackColor = true;
            btnContactUs.Click += btnContactUs_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.Location = new Point(0, 222);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(181, 42);
            btnCalendar.TabIndex = 44;
            btnCalendar.Text = "Attendances";
            btnCalendar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
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
            btnAnalytics.Text = "Students";
            btnAnalytics.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
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
            // panel7
            // 
            panel7.Controls.Add(label9);
            panel7.Controls.Add(pictureBox9);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(181, 138);
            panel7.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(54, 119);
            label9.Name = "label9";
            label9.Size = new Size(72, 16);
            label9.TabIndex = 44;
            label9.Text = "Welcome";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(21, 22);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(135, 96);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 43;
            pictureBox9.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(263, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 16);
            lblTotal.TabIndex = 54;
            lblTotal.Text = "Total Amount: ???";
            // 
            // ClassIdCb
            // 
            ClassIdCb.FormattingEnabled = true;
            ClassIdCb.Items.AddRange(new object[] { "1", "2", "3", "4" });
            ClassIdCb.Location = new Point(315, 84);
            ClassIdCb.Name = "ClassIdCb";
            ClassIdCb.Size = new Size(121, 23);
            ClassIdCb.TabIndex = 55;
            // 
            // OfferingTb
            // 
            OfferingTb.Location = new Point(751, 84);
            OfferingTb.Name = "OfferingTb";
            OfferingTb.Size = new Size(100, 23);
            OfferingTb.TabIndex = 45;
            // 
            // ClassNameCb
            // 
            ClassNameCb.FormattingEnabled = true;
            ClassNameCb.Items.AddRange(new object[] { "Yapadela", "Lausonyezo", "Lapafupi", "Sunday School" });
            ClassNameCb.Location = new Point(458, 84);
            ClassNameCb.Name = "ClassNameCb";
            ClassNameCb.Size = new Size(121, 23);
            ClassNameCb.TabIndex = 55;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(816, 524);
            button4.Name = "button4";
            button4.Size = new Size(99, 25);
            button4.TabIndex = 56;
            button4.Text = "Export to Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 577);
            Controls.Add(button4);
            Controls.Add(ClassNameCb);
            Controls.Add(ClassIdCb);
            Controls.Add(lblTotal);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(FinanceDGV);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OfferingTb);
            Controls.Add(TitheTb);
            Name = "Finances";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finances";
            Load += Finances_Load;
            ((System.ComponentModel.ISupportInitialize)FinanceDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox TitheTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridView FinanceDGV;
        private Panel panel1;
        private Label label10;
        private PictureBox pictureBox10;
        private Label label6;
        private Panel panel6;
        private Button button5;
        private Button button3;
        private Panel PnlNav;
        private Button btnSettings;
        private Button button2;
        private Button button1;
        private Button btnContactUs;
        private Button btnCalendar;
        private Button btnAnalytics;
        private Button btnDashboard;
        private Panel panel7;
        private Label label9;
        private PictureBox pictureBox9;
        private Label lblTotal;
        private ComboBox ClassIdCb;
        private TextBox OfferingTb;
        private ComboBox ClassNameCb;
        private Button button4;
    }
}