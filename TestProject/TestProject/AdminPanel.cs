using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connectStr);

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            string query = "Select Login From [Authorization]";
            DataTable logins = new DataTable();
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(logins);

            sqlCon.Close();

            comboBoxLogin.DataSource = logins;
            comboBoxLogin.DisplayMember = "Login";
        }

        private void btnCreateManager_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != string.Empty && txtName.Text != string.Empty && txtPass.Text != string.Empty)
            {
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("INSERT INTO [Authorization] (Name, Login, Password) values('{0}', '{1}', '{2}')",
                    txtName.Text, txtLogin.Text, Authorization.ComputeSha256Hash(txtPass.Text));

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();

                txtLogin.Clear();
                txtPass.Clear();
                txtName.Clear();

                MessageBox.Show("Новый менеджер добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка: Заполните все строки!");
            }
        }

        private void btnIsAdmin_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;

            string query = string.Format("Select * from [Authorization] Where Login = '{0}'", login);
            DataTable userInfo = new DataTable();

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(userInfo);

            sqlCon.Close();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
      
            if(Convert.ToInt32(userInfo.Rows[0]["Admin"]) == 0)
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Admin=1 WHERE Login='{0}'", login);
                MessageBox.Show(string.Format("{0} теперь Администратор!", login));
            }
            else
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Admin=0 WHERE Login='{0}'", login);
                MessageBox.Show(string.Format("{0} теперь НЕ Администратор!", login));
            }
            
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;

            string query = string.Format("Select * from [Authorization] Where Login = '{0}'", login);
            DataTable userInfo = new DataTable();

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(userInfo);

            sqlCon.Close();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            if (Convert.ToInt32(userInfo.Rows[0]["Ban"]) == 0)
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Ban=1 WHERE Login='{0}'", login);
                MessageBox.Show(string.Format("Вы забанили: {0}!", login));
            }
            else
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Ban=0 WHERE Login='{0}'", login);
                MessageBox.Show(string.Format("Вы розбанили: {0}!", login));
            }

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;

            string query = string.Format("Select * from [Authorization] Where Login = '{0}'", login);
            DataTable userInfo = new DataTable();

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(userInfo);

            sqlCon.Close();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            if (txtNewLogin.Text != string.Empty)
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Login='{1}' WHERE Login='{0}'", login, txtNewLogin.Text);
            }

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show(string.Format("Вы изменили Логин: {0} на новый Логин: {1}!", login, txtNewLogin.Text));
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;

            string query = string.Format("Select * from [Authorization] Where Login = '{0}'", login);
            DataTable userInfo = new DataTable();

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(userInfo);

            sqlCon.Close();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            if (txtNewLogin.Text != string.Empty)
            {
                sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Password='{1}' WHERE Login='{0}'", login, Authorization.ComputeSha256Hash(txtNewPass.Text));
            }

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show(string.Format("Вы изменили пароль для {0} на новый!", login));
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;

            string query = string.Format("Select * from [Authorization] Where Login = '{0}'", login);
            DataTable userInfo = new DataTable();

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(userInfo);

            sqlCon.Close();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = string.Format("Delete from [Authorization] WHERE Login='{0}'", login);

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show(string.Format("Вы удалили менеджера {0}!", login));
        }
    }
}
