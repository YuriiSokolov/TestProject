using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connectStr);
        DataTable result = new DataTable();

        private void Main_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            string query = "Select * from Document";
            SqlDataAdapter sdaSelectFromDocument = new SqlDataAdapter(query, sqlCon);
            sdaSelectFromDocument.Fill(result);

            dataGVFromDocument.DataSource = result;
            sqlCon.Close();
        }

        private void btnResultCancel_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> columns = CheckParams();

                if (columns.Count != 0)
                {
                    dataGVFromDocument.Columns.Clear();
                    ResultWithParams(columns);
                }
                else
                {
                    dataGVFromDocument.Columns.Clear();
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from Document", sqlCon);
                    result = new DataTable();
                    sda.Fill(result);
                    sqlCon.Close();
                    dataGVFromDocument.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public List<string> CheckParams()
        {
            List<string> result = new List<string>();

            if(checkBoxDate.Checked)
            {
                result.Add("Date");
            }
            if (checkBoxOrganization.Checked)
            {
                result.Add("Organization");
            }
            if (checkBoxManager.Checked)
            {
                result.Add("Manager");
            }
            if (checkBoxCountry.Checked)
            {
                result.Add("Country");
            }
            if (checkBoxCity.Checked)
            {
                result.Add("City");
            }

            return result;
        }

        public void ResultWithParams(List<string> columnNames)
        {
            string query = string.Empty;
            string columns = string.Empty;

            for(int i = 0; i < columnNames.Count; i++)
            {
                if (i < (columnNames.Count - 1))
                {
                    columns += columnNames[i] + ", ";
                }
                else
                {
                    columns += columnNames[i];
                }
            }

            query = string.Format("Select {0}, Sum([Count]) as 'Количество', Sum([Sum]) as 'Сумма' From Document Group by {0}", columns);

            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            result = new DataTable();
            sda.Fill(result);

            dataGVFromDocument.DataSource = result;

            sqlCon.Close();
        }
    }
}
