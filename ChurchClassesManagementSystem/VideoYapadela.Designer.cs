namespace ChurchClassesManagementSystem
{
    partial class VideoYapadela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoYapadela));
            button1 = new Button();
            label1 = new Label();
            BackBtn = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel5 = new Panel();
            label8 = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 74;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(334, 57);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 73;
            label1.Text = "Munthu Odala Ndiye Otani";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = SystemColors.MenuHighlight;
            BackBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLight;
            BackBtn.Location = new Point(742, 52);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(95, 27);
            BackBtn.TabIndex = 72;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(56, 85);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(781, 445);
            axWindowsMediaPlayer1.TabIndex = 71;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox10);
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(908, 44);
            panel5.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(54, 9);
            label8.Name = "label8";
            label8.Size = new Size(77, 18);
            label8.TabIndex = 7;
            label8.Text = "VideoFile";
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(421, 9);
            label11.Name = "label11";
            label11.Size = new Size(190, 19);
            label11.TabIndex = 1;
            label11.Text = "Mvama Church Classes";
            // 
            // VideoYapadela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 545);
            Controls.Add(panel5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "VideoYapadela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VideoYapadela";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button BackBtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel5;
        private Label label8;
        private PictureBox pictureBox10;
        private Label label11;
    }
}