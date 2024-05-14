namespace ChurchClassesManagementSystem
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            label7 = new Label();
            BackBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            TDOB = new DateTimePicker();
            SubCb = new ComboBox();
            TGenCb = new ComboBox();
            TAddTb = new TextBox();
            label1 = new Label();
            TnameTb = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            TPhoneTb = new TextBox();
            TeacherDGV = new DataGridView();
            panel6 = new Panel();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
            PnlNav = new Panel();
            btnSettings = new Button();
            button2 = new Button();
            button1 = new Button();
            btnContactUs = new Button();
            btnCalendar = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel7 = new Panel();
            label10 = new Label();
            pictureBox9 = new PictureBox();
            button4 = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(408, 246);
            label7.Name = "label7";
            label7.Size = new Size(158, 24);
            label7.TabIndex = 13;
            label7.Text = "List of Teachers";
            label7.Click += label7_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.DarkRed;
            BackBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLight;
            BackBtn.Location = new Point(671, 195);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 27);
            BackBtn.TabIndex = 27;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DarkRed;
            DeleteBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ControlLight;
            DeleteBtn.Location = new Point(541, 195);
            DeleteBtn.Margin = new Padding(3, 2, 3, 2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 27);
            DeleteBtn.TabIndex = 26;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.DarkRed;
            EditBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.ControlLight;
            EditBtn.Location = new Point(408, 195);
            EditBtn.Margin = new Padding(3, 2, 3, 2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 27);
            EditBtn.TabIndex = 25;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkRed;
            AddBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ControlLight;
            AddBtn.Location = new Point(278, 195);
            AddBtn.Margin = new Padding(3, 2, 3, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 27);
            AddBtn.TabIndex = 24;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // TDOB
            // 
            TDOB.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TDOB.Format = DateTimePickerFormat.Short;
            TDOB.Location = new Point(408, 147);
            TDOB.Margin = new Padding(3, 2, 3, 2);
            TDOB.Name = "TDOB";
            TDOB.Size = new Size(130, 23);
            TDOB.TabIndex = 23;
            // 
            // SubCb
            // 
            SubCb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SubCb.FormattingEnabled = true;
            SubCb.Items.AddRange(new object[] { "Yapadela", "Yapafupi", "yausonyezo", "Sunday School" });
            SubCb.Location = new Point(709, 70);
            SubCb.Margin = new Padding(3, 2, 3, 2);
            SubCb.Name = "SubCb";
            SubCb.Size = new Size(121, 25);
            SubCb.TabIndex = 22;
            // 
            // TGenCb
            // 
            TGenCb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TGenCb.FormattingEnabled = true;
            TGenCb.Items.AddRange(new object[] { "Male", "Female" });
            TGenCb.Location = new Point(408, 70);
            TGenCb.Margin = new Padding(3, 2, 3, 2);
            TGenCb.Name = "TGenCb";
            TGenCb.Size = new Size(121, 25);
            TGenCb.TabIndex = 21;
            // 
            // TAddTb
            // 
            TAddTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TAddTb.Location = new Point(551, 70);
            TAddTb.Margin = new Padding(3, 2, 3, 2);
            TAddTb.Multiline = true;
            TAddTb.Name = "TAddTb";
            TAddTb.Size = new Size(115, 99);
            TAddTb.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(549, 52);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 17;
            label1.Text = "Address";
            // 
            // TnameTb
            // 
            TnameTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TnameTb.Location = new Point(262, 70);
            TnameTb.Margin = new Padding(3, 2, 3, 2);
            TnameTb.Name = "TnameTb";
            TnameTb.Size = new Size(121, 23);
            TnameTb.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(709, 52);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 16;
            label6.Text = "Subjects";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(408, 129);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(408, 52);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(53, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 1;
            label2.Text = "Teachers";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(262, 52);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 18;
            label5.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 40);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(380, 11);
            label9.Name = "label9";
            label9.Size = new Size(190, 19);
            label9.TabIndex = 8;
            label9.Text = "Mvama Church Classes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(262, 129);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 17;
            label8.Text = "Phone";
            // 
            // TPhoneTb
            // 
            TPhoneTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TPhoneTb.Location = new Point(264, 147);
            TPhoneTb.Margin = new Padding(3, 2, 3, 2);
            TPhoneTb.Name = "TPhoneTb";
            TPhoneTb.Size = new Size(115, 23);
            TPhoneTb.TabIndex = 20;
            // 
            // TeacherDGV
            // 
            TeacherDGV.BackgroundColor = SystemColors.ActiveCaption;
            TeacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDGV.Location = new Point(199, 272);
            TeacherDGV.Margin = new Padding(3, 2, 3, 2);
            TeacherDGV.Name = "TeacherDGV";
            TeacherDGV.RowTemplate.Height = 25;
            TeacherDGV.Size = new Size(740, 294);
            TeacherDGV.TabIndex = 28;
            TeacherDGV.CellContentClick += TeacherDGV_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(button6);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button5);
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
            panel6.Location = new Point(0, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 569);
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
            button6.Location = new Point(0, 432);
            button6.Name = "button6";
            button6.Size = new Size(181, 42);
            button6.TabIndex = 50;
            button6.Text = "Finances";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            button3.TabIndex = 49;
            button3.Text = "Main Menu";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 396);
            button5.Name = "button5";
            button5.Size = new Size(181, 42);
            button5.TabIndex = 48;
            button5.Text = "Resources";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            panel7.Controls.Add(label10);
            panel7.Controls.Add(pictureBox9);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(181, 138);
            panel7.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(54, 119);
            label10.Name = "label10";
            label10.Size = new Size(72, 16);
            label10.TabIndex = 44;
            label10.Text = "Welcome";
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
            button4.Location = new Point(843, 245);
            button4.Name = "button4";
            button4.Size = new Size(96, 27);
            button4.TabIndex = 47;
            button4.Text = "Export to Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(220, 578);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 16);
            lblTotal.TabIndex = 48;
            lblTotal.Text = "Total records: ???";
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 609);
            Controls.Add(lblTotal);
            Controls.Add(button4);
            Controls.Add(panel6);
            Controls.Add(TeacherDGV);
            Controls.Add(label7);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(TDOB);
            Controls.Add(SubCb);
            Controls.Add(TGenCb);
            Controls.Add(TPhoneTb);
            Controls.Add(label8);
            Controls.Add(TAddTb);
            Controls.Add(label1);
            Controls.Add(TnameTb);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Teachers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button BackBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DateTimePicker TDOB;
        private ComboBox SubCb;
        private ComboBox TGenCb;
        private TextBox TAddTb;
        private Label label1;
        private TextBox TnameTb;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel1;
        private Label label8;
        private TextBox TPhoneTb;
        private DataGridView TeacherDGV;
        private Label label9;
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
        private Label label10;
        private PictureBox pictureBox9;
        private Button button4;
        private Button button5;
        private Button button3;
        private Label lblTotal;
        private Button button6;
    }
}