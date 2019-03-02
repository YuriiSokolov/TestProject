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
    public partial class ShipmentForm : Form
    {
        public ShipmentForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connectStr);
        DataTable managerWork = new DataTable();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            string org = txtOrg.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;
            string count = txtCount.Text;
            string sum = txtSum.Text;

            bool thisMonth = false;

            if (org != string.Empty && city != string.Empty && country != string.Empty && count != string.Empty && sum != string.Empty)
            {
                if (FirstShipment(managerWork) == true)
                {
                    InsertIntoTable(date, org, city, country, count, sum);
                }
                else if(ShipmentInThisMonth(int.Parse(sum), out thisMonth) == true)
                {
                    InsertIntoTable(date, org, city, country, count, sum);
                }
                else if(thisMonth == true)
                {
                    MessageBox.Show("Ошибка: Недопустимая сумма отгрузки!");
                }
                else if(ShipmentInLastMonth(int.Parse(sum)) == true)
                {
                    InsertIntoTable(date, org, city, country, count, sum);
                }
                else
                {
                    MessageBox.Show("Ошибка: Недопустимая сумма отгрузки!");
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Заполните все строки!");
            }
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {
            string query = string.Format("Select * from Document Where Manager = '{0}'", User.name);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(managerWork);
            sqlCon.Close();
        }

        public bool ShipmentInThisMonth(int currentSum, out bool thisMonth)
        {
            bool result = false;

            thisMonth = true;

            DataTable rows = new DataTable();

            DateTime date = new DateTime();
            date = DateTime.Now;

            string query = string.Format("Select AVG([Sum]) as 'AVG' From Document Where Manager = '{0}' AND Date LIKE '%{1}%{2}'",
                User.name, date.Month.ToString(), date.Year.ToString());

            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            sda.Fill(rows);
            sqlCon.Close();

            if (rows.Rows[0]["AVG"] == null)
            {
                result = false;
                thisMonth = false;
            }
            if(thisMonth != false && rows.Rows[0]["AVG"] != null)
            {
                int avarageSum = Convert.ToInt32(rows.Rows[0]["AVG"]);

                thisMonth = true;

                //MessageBox.Show(avarageSum.ToString());

                if (currentSum <= avarageSum + 500)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool ShipmentInLastMonth(int currentSum)
        {
            bool result = false;

            DateTime date = new DateTime();
            date = DateTime.Now;

            DataTable rows = new DataTable();

            int index = -1;

            do {
                date = date.AddMonths(index);

                string query = string.Format("Select AVG([Sum]) as 'AVG' From Document Where Manager = '{0}' AND Date LIKE '%{1}%{2}'",
                User.name, date.Month.ToString(), date.Year.ToString());

                sqlCon.Open();

                SqlDataAdapter sqa = new SqlDataAdapter(query, sqlCon);
                sqa.Fill(rows);

                sqlCon.Close();

                index--;
            } while ((rows == null && rows.Rows.Count == 0));

            if (rows.Rows[0]["AVG"] == null)
            {
                result = false;
            }
            else
            {
                int avarageSum = Convert.ToInt32(rows.Rows[0]["AVG"]);

                //MessageBox.Show(avarageSum.ToString());

                if (currentSum <= avarageSum + 500)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public bool FirstShipment(DataTable managerWork)
        {
            bool result = false;

            if(managerWork.Rows.Count == 0)
            {
                result = true;
            }

            return result;
        }

        public void InsertIntoTable(DateTime date, string org, string city, string country, string count, string sum)
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO Document([Date], Organization, City, Country, Manager, [Count], [Sum]) " +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})",
                date.ToShortDateString(), org, city, country, User.name, count, sum);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            txtCity.Clear();
            txtOrg.Clear();
            txtSum.Clear();
            txtCount.Clear();
            txtCountry.Clear();

            MessageBox.Show("Новая отгрузка добавлена в таблицу!");
        }
    }
}
