using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connectStr);

        int enterCount = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text.Trim();
            string passwordHash = ComputeSha256Hash(txtPass.Text.Trim());

            if (login != string.Empty && txtPass.Text != string.Empty)
            {

                string query = string.Format("Select * From [Authorization] Where Login = '{0}'", login);

                DataTable userInfo = new DataTable();

                try
                {
                    sqlCon.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                    sda.Fill(userInfo);

                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (passwordHash == userInfo.Rows[0]["Password"].ToString())
                {
                    if (Convert.ToInt32(userInfo.Rows[0]["Ban"]) != 1)
                    {
                        User.name = userInfo.Rows[0]["Name"].ToString();

                        if (Convert.ToInt32(userInfo.Rows[0]["Admin"]) == 0)
                        {
                            User.isAdmin = false;
                        }
                        else
                        {
                            User.isAdmin = true;
                        }

                        Main mainForm = new Main();
                        mainForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: Вы забаненны обратитесь к администратору!");
                    }
                }
                else
                {
                    if (enterCount < 2)
                    {
                        MessageBox.Show("Ошибка: Неверный пароль!");
                        enterCount++;
                    }
                    else
                    {
                        SqlCommand sqlCmd = sqlCon.CreateCommand();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.CommandText = string.Format("UPDATE [Authorization] SET Ban=1 WHERE Login='{0}'", login);

                        sqlCon.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCon.Close();

                        MessageBox.Show("Ошибка: Вы забаненны обратитесь к администратору!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Вы не выбрали Логин, или не ввели Пароль!");
            }
        }

        static public string ComputeSha256Hash(string rawData)
        { 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = BitConverter.ToString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData)));

                Regex re = new Regex("-");

                hash = re.Replace(hash, "");

                return hash;
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
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
    }
}
