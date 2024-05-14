namespace ChurchClassesManagementSystem
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgressBar = new ProgressBar();
            label2 = new Label();
            Percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ScriptureLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(126, 24);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 0;
            label1.Text = "Mvama CCAP Classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProgressBar
            // 
            MyProgressBar.BackColor = SystemColors.Control;
            MyProgressBar.ForeColor = Color.DodgerBlue;
            MyProgressBar.Location = new Point(1, 253);
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.Size = new Size(478, 10);
            MyProgressBar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(12, 227);
            label2.Name = "label2";
            label2.Size = new Size(159, 22);
            label2.TabIndex = 0;
            label2.Text = "Loading Module";
            label2.Click += label2_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Percentage.ForeColor = Color.Blue;
            Percentage.Location = new Point(177, 228);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(26, 23);
            Percentage.TabIndex = 0;
            Percentage.Text = "%";
            Percentage.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ScriptureLbl
            // 
            ScriptureLbl.AutoSize = true;
            ScriptureLbl.BackColor = Color.PaleGreen;
            ScriptureLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ScriptureLbl.Location = new Point(44, 201);
            ScriptureLbl.Name = "ScriptureLbl";
            ScriptureLbl.Size = new Size(298, 17);
            ScriptureLbl.TabIndex = 3;
            ScriptureLbl.Text = "Daily Readings Daily Readings Daily Readings";
            ScriptureLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(488, 276);
            Controls.Add(ScriptureLbl);
            Controls.Add(MyProgressBar);
            Controls.Add(pictureBox1);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar MyProgressBar;
        private Label label2;
        private Label Percentage;
        private System.Windows.Forms.Timer timer1;
        private Label ScriptureLbl;
    }
}