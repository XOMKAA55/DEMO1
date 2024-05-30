using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DEMO
{

    enum RoWstate
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class fMain : Form
    {
       

        //подключение бд к форме
        DB db = new DB();
        int selectedRow;
        public fMain()
        {
            InitializeComponent();
        }

        private void dtgvCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //загрузка данных в комбо бокс
       
       
        private void Form1_Load(object sender, EventArgs e)
        {
           checkRole(persanalDate.roles.ToLower());
            CreateColums();
            RefreshDataGrid(dtgvCostumers);
            dtgvCostumers.ClearSelection();

        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from application where concat " +
                $"(numb_application,data_application,oborud,tip_broke,_description,client,stat) like '%" + searh_tb.Text + "%' ";

            SqlCommand com = new SqlCommand(searchString, db.GetConnection());

            db.oppenConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void CreateColums()
        {
            dtgvCostumers.Columns.Add("numb_application", "Номер заявки");
            dtgvCostumers.Columns.Add("data_application", "дата объявления");
            dtgvCostumers.Columns.Add("oborud", "оборудование");
            dtgvCostumers.Columns.Add("tip_broke", "тип не исправности");
            dtgvCostumers.Columns.Add("_description", "описание проблемы");
            dtgvCostumers.Columns.Add("client", "клиент");
            dtgvCostumers.Columns.Add("stat", "статус заявки");
            
            dtgvCostumers.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            object[] values = new object[record.FieldCount];
            record.GetValues(values);
            dgw.Rows.Add(values);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querySring = $"select * from application";

            SqlCommand command = new SqlCommand(querySring, db.GetConnection());

            db.oppenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        
            private void Close_B_Click(object sender, EventArgs e)
        {
            Close();
        }



        private string checkRole(string role)
        {
            switch (role)
            {
                case ("admin"):
                    btnDell.Enabled=false;
                    MessageBox.Show($"Добро пожаловать {persanalDate.login}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return role;
                case ("user"):
                    btnAdd.Enabled = false;
                    MessageBox.Show($"Добро пожаловать {persanalDate.login}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return role;
                
                default:
                    
                    MessageBox.Show("Учетная запись некорректна.\rОбратитесь в тех. поддержку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return role;
            }
        }
        //загрузка данных в текст боксы

        private void dtgvCostumers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvCostumers.Rows[e.RowIndex];

                // Получаем значения из строки
                string numb_application = selectedRow.Cells["numb_application"].Value.ToString();
                string data_application = selectedRow.Cells["data_application"].Value.ToString();
                string oborud = selectedRow.Cells["oborud"].Value.ToString();

                string tip_broke = selectedRow.Cells["tip_broke"].Value.ToString();
                string _description = selectedRow.Cells["_description"].Value.ToString();
                string client = selectedRow.Cells["client"].Value.ToString();
                string stat = selectedRow.Cells["stat"].Value.ToString();


                // Устанавливаем значение для ComboBox
                stat_cb.Text = stat;
                // Устанавливаем значения в контролы
                numb_application_tb.Text = numb_application;
                dateTimePicker1.Text = data_application;
                oborud_tb.Text = oborud;
                tip_broke_tb.Text = tip_broke;
                _description_tb.Text = _description;
                client_tb.Text = client;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dtgvCostumers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvCostumers.SelectedRows[0];

                int Id = Convert.ToInt32(selectedRow.Cells["numb_application"].Value);

                string query = "UPDATE application SET  data_application = @data_application," +
                    " oborud = @oborud, tip_broke = @tip_broke, _description = @_description, client = @client, stat = @stat WHERE numb_application = @numb_application";
                db.oppenConnection();
                SqlCommand sqlCommand = new SqlCommand(query, db.connection);


                sqlCommand.Parameters.AddWithValue("@stat", stat_cb.Text);
                sqlCommand.Parameters.AddWithValue("@data_application", this.dateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@oborud", oborud_tb.Text);
                sqlCommand.Parameters.AddWithValue("@tip_broke", tip_broke_tb.Text);
                sqlCommand.Parameters.AddWithValue("@_description", _description_tb.Text);
                sqlCommand.Parameters.AddWithValue("@client", client_tb.Text);
                
                // Добавление значения идентификатора заявки
                sqlCommand.Parameters.AddWithValue("@numb_application", Id);
                
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    RefreshDataGrid(dtgvCostumers);
                    MessageBox.Show("Данные успешно обновлены.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
                finally
                {
                    db.closeConnection();
                }
                
                
            }
            else
                MessageBox.Show("Выберите заявку для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (dtgvCostumers.SelectedRows.Count > 0)
            {
                int requestId = (int)dtgvCostumers.SelectedRows[0].Cells["numb_application"].Value;
                DeleteVacationRequest(requestId);
                RefreshDataGrid(dtgvCostumers);
                MessageBox.Show("Запись успешно удаленна!");
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteVacationRequest(int requestId)
        {

            db.oppenConnection();
            string query = "DELETE FROM application WHERE numb_application = @RequestId";
            SqlCommand command = new SqlCommand(query, db.connection);
            command.Parameters.AddWithValue("@RequestId", requestId);
            command.ExecuteNonQuery();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAdd fAdd = new fAdd();
            fAdd.ShowDialog();
            RefreshDataGrid(dtgvCostumers);
        }

        private void searh_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dtgvCostumers);
        }
    }
}
