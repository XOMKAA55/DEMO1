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

            if(dateTimePicker1.Text != null)
           { 

            string query = $"INSERT INTO application (data_application, oborud, tip_broke, _description, client, stat) Values " +
                $"( @data_application, @oborud, @tip_broke, @_description, @client, @stat)";
            SqlCommand command = new SqlCommand(query, DB.connection);
            command.Parameters.AddWithValue("@stat", stat_cb.Text);
            command.Parameters.AddWithValue("@data_application", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@oborud", oborud_tb.Text);
            command.Parameters.AddWithValue("@tip_broke", tip_broke_tb.Text);
            command.Parameters.AddWithValue("@_description", _description_tb.Text);
            command.Parameters.AddWithValue("@client", client_tb.Text);
                command.ExecuteNonQuery();

              MessageBox.Show("Запись успешно добавленна!");
            
            Close();
            }
            else
                MessageBox.Show("ошибка в дате");


        }
    }
}
