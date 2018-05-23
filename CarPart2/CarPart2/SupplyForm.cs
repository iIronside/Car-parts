using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarPart2
{
    public partial class SupplyForm : Form
    {
        SqlConnection sqlCon; // строка подключения

        public SupplyForm(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoCarPartShop2DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.autoCarPartShop2DataSet.Поставщик);

        }
        
        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoCarPartShop2DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            try
            {

                SqlCommand comAddInvSup = new SqlCommand();
                comAddInvSup.CommandText = "INSERT into Накладная_поставки([IDПоставщика]) values('" + имя_компанииComboBox.SelectedValue + "' ) SELECT SCOPE_IDENTITY()";
                comAddInvSup.Connection = sqlCon;
                comAddInvSup.CommandType = CommandType.Text;
                sqlReader = comAddInvSup.ExecuteReader();
                sqlReader.Read();


                string id = sqlReader[0].ToString();
               
                //MessageBox.Show("Накладная была создана");
                SuplayListForm supList = new SuplayListForm(sqlCon, id);
                supList.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
