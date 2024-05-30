namespace DEMO
{
    partial class fAdd
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stat_cb = new System.Windows.Forms.ComboBox();
            this._description_tb = new System.Windows.Forms.TextBox();
            this.client_tb = new System.Windows.Forms.TextBox();
            this.tip_broke_tb = new System.Windows.Forms.TextBox();
            this.oborud_tb = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // stat_cb
            // 
            this.stat_cb.FormattingEnabled = true;
            this.stat_cb.Items.AddRange(new object[] {
            "В работе",
            "Ожидание",
            "Выполнина"});
            this.stat_cb.Location = new System.Drawing.Point(88, 236);
            this.stat_cb.Name = "stat_cb";
            this.stat_cb.Size = new System.Drawing.Size(121, 24);
            this.stat_cb.TabIndex = 17;
            // 
            // _description_tb
            // 
            this._description_tb.Location = new System.Drawing.Point(88, 180);
            this._description_tb.Name = "_description_tb";
            this._description_tb.Size = new System.Drawing.Size(100, 22);
            this._description_tb.TabIndex = 16;
            // 
            // client_tb
            // 
            this.client_tb.Location = new System.Drawing.Point(88, 208);
            this.client_tb.Name = "client_tb";
            this.client_tb.Size = new System.Drawing.Size(100, 22);
            this.client_tb.TabIndex = 15;
            // 
            // tip_broke_tb
            // 
            this.tip_broke_tb.Location = new System.Drawing.Point(88, 152);
            this.tip_broke_tb.Name = "tip_broke_tb";
            this.tip_broke_tb.Size = new System.Drawing.Size(100, 22);
            this.tip_broke_tb.TabIndex = 14;
            // 
            // oborud_tb
            // 
            this.oborud_tb.Location = new System.Drawing.Point(88, 124);
            this.oborud_tb.Name = "oborud_tb";
            this.oborud_tb.Size = new System.Drawing.Size(100, 22);
            this.oborud_tb.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(78, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 62);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stat_cb);
            this.Controls.Add(this._description_tb);
            this.Controls.Add(this.client_tb);
            this.Controls.Add(this.tip_broke_tb);
            this.Controls.Add(this.oborud_tb);
            this.Name = "fAdd";
            this.Text = "fAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox stat_cb;
        private System.Windows.Forms.TextBox _description_tb;
        private System.Windows.Forms.TextBox client_tb;
        private System.Windows.Forms.TextBox tip_broke_tb;
        private System.Windows.Forms.TextBox oborud_tb;
        private System.Windows.Forms.Button btnAdd;
    }
}