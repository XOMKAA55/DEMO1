using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class fRegister : Form
    {

        DB DB = new DB();
        public fRegister()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var loginUser = tbReg.Text;
            var passUser = tbPassword.Text;
            var roles = "user";
            //Проверка пустых полей
            if (tbReg.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                DB.oppenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //Поиск в БД таких же логина и пароля
                var query = $"select login,Password from Accs where login = '{loginUser}' and Password = '{passUser}'";
                var querycommand = new SqlCommand(query, DB.GetConnection());
                adapter.SelectCommand = querycommand;
                adapter.Fill(table);
                //Если совпадений не найдено
                if (table.Rows.Count == 0)
                {//Добавляем новую запись
                    string querystring = $"insert into Accs(login, Password, roles) values ('{loginUser}','{passUser}','{roles}')";

                    SqlCommand command = new SqlCommand(querystring, DB.GetConnection());
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                        logincs login_F = new logincs();
                        this.Hide();
                        login_F.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Аккаунт уже существует!");
                }
                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
        }

        private void fRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
