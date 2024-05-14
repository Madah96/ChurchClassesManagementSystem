namespace ChurchClassesManagementSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            StNameTb = new TextBox();
            label5 = new Label();
            StGenCb = new ComboBox();
            label3 = new Label();
            DOBPicker = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            ClassCb = new ComboBox();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            BlockBtn = new Button();
            StudentDGV = new DataGridView();
            label7 = new Label();
            AddressTb = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            button6 = new Button();
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
            button4 = new Button();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 42);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(380, 12);
            label8.Name = "label8";
            label8.Size = new Size(190, 19);
            label8.TabIndex = 8;
            label8.Text = "Mvama Church Classes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(64, 10);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 1;
            label2.Text = "Students";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(14, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // StNameTb
            // 
            StNameTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            StNameTb.Location = new Point(317, 73);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(138, 23);
            StNameTb.TabIndex = 7;
            StNameTb.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(316, 51);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Name";
            // 
            // StGenCb
            // 
            StGenCb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StGenCb.FormattingEnabled = true;
            StGenCb.Items.AddRange(new object[] { "Male", "Female" });
            StGenCb.Location = new Point(317, 138);
            StGenCb.Name = "StGenCb";
            StGenCb.Size = new Size(138, 25);
            StGenCb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(317, 116);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // DOBPicker
            // 
            DOBPicker.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DOBPicker.Format = DateTimePickerFormat.Short;
            DOBPicker.Location = new Point(521, 73);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(148, 23);
            DOBPicker.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(521, 51);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(521, 120);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Class";
            // 
            // ClassCb
            // 
            ClassCb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClassCb.FormattingEnabled = true;
            ClassCb.Items.AddRange(new object[] { "Yapadela", "Lausonyezo", "Lapafupi", "Sunday School" });
            ClassCb.Location = new Point(521, 142);
            ClassCb.Name = "ClassCb";
            ClassCb.Size = new Size(138, 25);
            ClassCb.TabIndex = 8;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.DarkRed;
            SaveBtn.ForeColor = SystemColors.ControlLight;
            SaveBtn.Location = new Point(315, 173);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(99, 31);
            SaveBtn.TabIndex = 10;
            SaveBtn.Text = "Add";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.DarkRed;
            EditBtn.ForeColor = SystemColors.ControlLight;
            EditBtn.Location = new Point(464, 173);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(99, 31);
            EditBtn.TabIndex = 10;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DarkRed;
            DeleteBtn.ForeColor = SystemColors.ControlLight;
            DeleteBtn.Location = new Point(616, 173);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(99, 31);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // BlockBtn
            // 
            BlockBtn.BackColor = Color.DarkRed;
            BlockBtn.ForeColor = SystemColors.ControlLight;
            BlockBtn.Location = new Point(763, 173);
            BlockBtn.Name = "BlockBtn";
            BlockBtn.Size = new Size(99, 31);
            BlockBtn.TabIndex = 10;
            BlockBtn.Text = "Back";
            BlockBtn.UseVisualStyleBackColor = false;
            BlockBtn.Click += button4_Click;
            // 
            // StudentDGV
            // 
            StudentDGV.BackgroundColor = SystemColors.ActiveCaption;
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDGV.Location = new Point(246, 247);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.RowTemplate.Height = 25;
            StudentDGV.Size = new Size(655, 282);
            StudentDGV.TabIndex = 11;
            StudentDGV.ColumnHeadersBorderStyleChanged += StudentDGV_ColumnHeadersBorderStyleChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(480, 220);
            label7.Name = "label7";
            label7.Size = new Size(151, 24);
            label7.TabIndex = 1;
            label7.Text = "List of Students";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTb.Location = new Point(721, 94);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(131, 69);
            AddressTb.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(720, 73);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 21;
            label1.Text = "Address";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(button6);
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
            panel6.Location = new Point(0, 42);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 535);
            panel6.TabIndex = 44;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(0, 474);
            button6.Name = "button6";
            button6.Size = new Size(181, 42);
            button6.TabIndex = 47;
            button6.Text = "Finances";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(802, 220);
            button4.Name = "button4";
            button4.Size = new Size(99, 25);
            button4.TabIndex = 45;
            button4.Text = "Export to Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(246, 535);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 16);
            lblTotal.TabIndex = 48;
            lblTotal.Text = "Total records: ???";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 577);
            Controls.Add(lblTotal);
            Controls.Add(button4);
            Controls.Add(panel6);
            Controls.Add(AddressTb);
            Controls.Add(label1);
            Controls.Add(StudentDGV);
            Controls.Add(label7);
            Controls.Add(BlockBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(DOBPicker);
            Controls.Add(ClassCb);
            Controls.Add(StGenCb);
            Controls.Add(StNameTb);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox StNameTb;
        private Label label5;
        private ComboBox StGenCb;
        private Label label3;
        private DateTimePicker DOBPicker;
        private Label label4;
        private Label label6;
        private ComboBox ClassCb;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button BlockBtn;
        private DataGridView StudentDGV;
        private Label label7;
        private TextBox AddressTb;
        private Label label1;
        private Label label8;
        private Panel panel6;
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblTotal;
        private Button button6;
    }
}