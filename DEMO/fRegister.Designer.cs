namespace DEMO
{
    partial class fRegister
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
            this.btLogin = new System.Windows.Forms.Button();
            this.register_L = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLogin.Location = new System.Drawing.Point(130, 277);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(121, 55);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Registr";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // register_L
            // 
            this.register_L.AutoSize = true;
            this.register_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_L.Location = new System.Drawing.Point(139, 119);
            this.register_L.Name = "register_L";
            this.register_L.Size = new System.Drawing.Size(96, 39);
            this.register_L.TabIndex = 4;
            this.register_L.Text = "Вход";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(84, 227);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(209, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(84, 182);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(209, 22);
            this.tbReg.TabIndex = 3;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.register_L);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbReg);
            this.Name = "fRegister";
            this.Text = "fRegister";
            this.Load += new System.EventHandler(this.fRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label register_L;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbReg;
    }
}