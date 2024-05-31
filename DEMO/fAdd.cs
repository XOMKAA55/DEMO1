using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class fAdd : Form
    {

        DB DB = new DB();
        public fAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.oppenConnection();
            //проверка на заполнение 
            if(!string.IsNullOrWhiteSpace(dateTimePicker1.Text) &&
                !string.IsNullOrWhiteSpace(oborud_tb.Text) &&
                !string.IsNullOrWhiteSpace(tip_broke_tb.Text) &&
                !string.IsNullOrWhiteSpace(_description_tb.Text) &&
                !string.IsNullOrWhiteSpace(client_tb.Text))
           { 

            string query = $"INSERT INTO application (data_application, oborud, tip_broke, _description, client, stat) Values " +
                $"( @data_application, @oborud, @tip_broke, @_description, @client, @stat)";
            SqlCommand command = new SqlCommand(query, DB.connection);
            command.Parameters.AddWithValue("@stat", "Новое");
            command.Parameters.AddWithValue("@data_application", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@oborud", oborud_tb.Text);
            command.Parameters.AddWithValue("@tip_broke", tip_broke_tb.Text);
            command.Parameters.AddWithValue("@_description", _description_tb.Text);
            command.Parameters.AddWithValue("@client", client_tb.Text);
                command.ExecuteNonQuery();

              MessageBox.Show("Запись успешно добавленна!" ,"Успех",MessageBoxButtons.OK);
            
            Close();
            }
            else

                MessageBox.Show("Не все поля заполнины!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void fAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
