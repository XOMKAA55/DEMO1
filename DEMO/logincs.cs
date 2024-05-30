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
    public partial class logincs : Form
    {
        DB DB = new DB();
        public logincs()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var passwoed = tbPassword.Text;

            var PI = new persanalDate();
            if (PI.SetPersonalData(login, passwoed))
            {
                var mainForm = new fMain();
                mainForm.Show();
                this.Hide();
                DB.oppenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
               
            }

            else
            {
                MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void register_L_Click(object sender, EventArgs e)
        {
            fRegister fRegister = new fRegister();
            fRegister.Show();
        }
    }
}
