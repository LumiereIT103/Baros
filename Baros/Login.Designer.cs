namespace Baros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cNum_tb = new TextBox();
            contactNum = new Label();
            pass_tb = new TextBox();
            passWord = new Label();
            loginlbl = new Label();
            clear2_btn = new Button();
            signin_Btn = new Button();
            exit = new Label();
            signUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // cNum_tb
            // 
            cNum_tb.BackColor = Color.FromArgb(246, 180, 71);
            cNum_tb.BorderStyle = BorderStyle.FixedSingle;
            cNum_tb.Cursor = Cursors.IBeam;
            cNum_tb.ForeColor = Color.FromArgb(24, 25, 56);
            cNum_tb.Location = new Point(136, 108);
            cNum_tb.Multiline = true;
            cNum_tb.Name = "cNum_tb";
            cNum_tb.Size = new Size(216, 28);
            cNum_tb.TabIndex = 13;
            cNum_tb.TextChanged += fullname_txtb_TextChanged;
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Location = new Point(136, 88);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(96, 15);
            contactNum.TabIndex = 12;
            contactNum.Text = "Contact Number";
            // 
            // pass_tb
            // 
            pass_tb.BackColor = Color.FromArgb(246, 180, 71);
            pass_tb.BorderStyle = BorderStyle.FixedSingle;
            pass_tb.Cursor = Cursors.IBeam;
            pass_tb.ForeColor = Color.FromArgb(24, 25, 56);
            pass_tb.Location = new Point(136, 159);
            pass_tb.Multiline = true;
            pass_tb.Name = "pass_tb";
            pass_tb.Size = new Size(216, 28);
            pass_tb.TabIndex = 9;
            pass_tb.TextChanged += pass_tb_TextChanged;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Location = new Point(136, 139);
            passWord.Name = "passWord";
            passWord.Size = new Size(60, 15);
            passWord.TabIndex = 8;
            passWord.Text = "Password ";
            // 
            // loginlbl
            // 
            loginlbl.AutoSize = true;
            loginlbl.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlbl.Location = new Point(337, 46);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(102, 29);
            loginlbl.TabIndex = 7;
            loginlbl.Text = "Sign In";
            // 
            // clear2_btn
            // 
            clear2_btn.BackColor = Color.FromArgb(246, 180, 71);
            clear2_btn.FlatStyle = FlatStyle.Flat;
            clear2_btn.ForeColor = Color.FromArgb(24, 25, 56);
            clear2_btn.Location = new Point(136, 202);
            clear2_btn.Name = "clear2_btn";
            clear2_btn.Size = new Size(100, 35);
            clear2_btn.TabIndex = 15;
            clear2_btn.Text = "Clear";
            clear2_btn.UseVisualStyleBackColor = false;
            clear2_btn.Click += clear2_btn_Click;
            // 
            // signin_Btn
            // 
            signin_Btn.BackColor = Color.FromArgb(24, 25, 56);
            signin_Btn.FlatAppearance.BorderSize = 0;
            signin_Btn.FlatStyle = FlatStyle.Flat;
            signin_Btn.ForeColor = Color.FromArgb(246, 180, 71);
            signin_Btn.Location = new Point(252, 202);
            signin_Btn.Name = "signin_Btn";
            signin_Btn.Size = new Size(100, 35);
            signin_Btn.TabIndex = 14;
            signin_Btn.Text = "Sign In";
            signin_Btn.UseVisualStyleBackColor = false;
            signin_Btn.Click += signin_Btn_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(216, 251);
            exit.Name = "exit";
            exit.Size = new Size(52, 24);
            exit.TabIndex = 16;
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // signUpLogo
            // 
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(419, 88);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(317, 300);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 17;
            signUpLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(signUpLogo);
            Controls.Add(exit);
            Controls.Add(clear2_btn);
            Controls.Add(signin_Btn);
            Controls.Add(cNum_tb);
            Controls.Add(contactNum);
            Controls.Add(pass_tb);
            Controls.Add(passWord);
            Controls.Add(loginlbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cNum_tb;
        private Label contactNum;
        private TextBox contact_txtb;
        private Label contact_lbl;
        private TextBox pass_tb;
        private Label passWord;
        private Label loginlbl;
        private Button clear2_btn;
        private Button signin_Btn;
        private Label exit;
        private PictureBox signUpLogo;
    }
}