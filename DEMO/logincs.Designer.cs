namespace DEMO
{
    partial class logincs
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.login_L = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.register_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(98, 201);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(209, 22);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 246);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(209, 22);
            this.tbPassword.TabIndex = 1;
            // 
            // login_L
            // 
            this.login_L.AutoSize = true;
            this.login_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_L.Location = new System.Drawing.Point(153, 138);
            this.login_L.Name = "login_L";
            this.login_L.Size = new System.Drawing.Size(96, 39);
            this.login_L.TabIndex = 1;
            this.login_L.Text = "Вход";
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLogin.Location = new System.Drawing.Point(144, 296);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(121, 55);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Войти";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // register_L
            // 
            this.register_L.AutoSize = true;
            this.register_L.Location = new System.Drawing.Point(157, 354);
            this.register_L.Name = "register_L";
            this.register_L.Size = new System.Drawing.Size(94, 16);
            this.register_L.TabIndex = 3;
            this.register_L.Text = "нет аккаунта";
            this.register_L.Click += new System.EventHandler(this.register_L_Click);
            // 
            // logincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.register_L);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.login_L);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Name = "logincs";
            this.Text = "logincs";
            this.Load += new System.EventHandler(this.logincs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label login_L;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label register_L;
    }
}