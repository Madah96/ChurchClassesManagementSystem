namespace ChurchClassesManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 34);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 19);
            label1.TabIndex = 1;
            label1.Text = "Mvama Church Classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(24, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(324, 271);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 45;
            label4.Text = "Reset";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 146, 249);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(305, 98);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 45;
            label3.Text = "LOGIN";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnameTb.Location = new Point(239, 141);
            UnameTb.Name = "UnameTb";
            UnameTb.PlaceholderText = "Username";
            UnameTb.Size = new Size(216, 23);
            UnameTb.TabIndex = 46;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.Location = new Point(239, 200);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.PlaceholderText = "Password";
            PasswordTb.Size = new Size(216, 23);
            PasswordTb.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(296, 229);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 47;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 411);
            Controls.Add(button1);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private Button button1;
        private System.Windows.Forms.Timer sessionTimer;
        private System.Windows.Forms.Timer timer1;
        // private System.Windows.Forms.Timer sessionTimer;
    }
}