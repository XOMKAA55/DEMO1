namespace DEMO
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvCostumers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.numb_application_tb = new System.Windows.Forms.TextBox();
            this.oborud_tb = new System.Windows.Forms.TextBox();
            this.tip_broke_tb = new System.Windows.Forms.TextBox();
            this.client_tb = new System.Windows.Forms.TextBox();
            this._description_tb = new System.Windows.Forms.TextBox();
            this.stat_cb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searh_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCostumers
            // 
            this.dtgvCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCostumers.Location = new System.Drawing.Point(0, 9);
            this.dtgvCostumers.Name = "dtgvCostumers";
            this.dtgvCostumers.RowHeadersWidth = 51;
            this.dtgvCostumers.RowTemplate.Height = 24;
            this.dtgvCostumers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCostumers.Size = new System.Drawing.Size(586, 251);
            this.dtgvCostumers.TabIndex = 0;
            this.dtgvCostumers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCostumers_CellClick);
            this.dtgvCostumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCostumers_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(592, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(592, 71);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(196, 23);
            this.btnDell.TabIndex = 2;
            this.btnDell.Text = "Удалить";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(592, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // numb_application_tb
            // 
            this.numb_application_tb.Location = new System.Drawing.Point(12, 266);
            this.numb_application_tb.Name = "numb_application_tb";
            this.numb_application_tb.Size = new System.Drawing.Size(100, 22);
            this.numb_application_tb.TabIndex = 4;
            // 
            // oborud_tb
            // 
            this.oborud_tb.Location = new System.Drawing.Point(12, 322);
            this.oborud_tb.Name = "oborud_tb";
            this.oborud_tb.Size = new System.Drawing.Size(100, 22);
            this.oborud_tb.TabIndex = 6;
            // 
            // tip_broke_tb
            // 
            this.tip_broke_tb.Location = new System.Drawing.Point(12, 350);
            this.tip_broke_tb.Name = "tip_broke_tb";
            this.tip_broke_tb.Size = new System.Drawing.Size(100, 22);
            this.tip_broke_tb.TabIndex = 7;
            // 
            // client_tb
            // 
            this.client_tb.Location = new System.Drawing.Point(12, 406);
            this.client_tb.Name = "client_tb";
            this.client_tb.Size = new System.Drawing.Size(100, 22);
            this.client_tb.TabIndex = 8;
            // 
            // _description_tb
            // 
            this._description_tb.Location = new System.Drawing.Point(12, 378);
            this._description_tb.Name = "_description_tb";
            this._description_tb.Size = new System.Drawing.Size(100, 22);
            this._description_tb.TabIndex = 9;
            // 
            // stat_cb
            // 
            this.stat_cb.FormattingEnabled = true;
            this.stat_cb.Items.AddRange(new object[] {
            "В работе",
            "Ожидание",
            "Выполнина"});
            this.stat_cb.Location = new System.Drawing.Point(218, 266);
            this.stat_cb.Name = "stat_cb";
            this.stat_cb.Size = new System.Drawing.Size(121, 24);
            this.stat_cb.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // searh_tb
            // 
            this.searh_tb.Location = new System.Drawing.Point(595, 9);
            this.searh_tb.Name = "searh_tb";
            this.searh_tb.Size = new System.Drawing.Size(193, 22);
            this.searh_tb.TabIndex = 12;
            this.searh_tb.TextChanged += new System.EventHandler(this.searh_tb_TextChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searh_tb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stat_cb);
            this.Controls.Add(this._description_tb);
            this.Controls.Add(this.client_tb);
            this.Controls.Add(this.tip_broke_tb);
            this.Controls.Add(this.oborud_tb);
            this.Controls.Add(this.numb_application_tb);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvCostumers);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCostumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCostumers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox numb_application_tb;
        private System.Windows.Forms.TextBox oborud_tb;
        private System.Windows.Forms.TextBox tip_broke_tb;
        private System.Windows.Forms.TextBox client_tb;
        private System.Windows.Forms.TextBox _description_tb;
        private System.Windows.Forms.ComboBox stat_cb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox searh_tb;
    }
}

