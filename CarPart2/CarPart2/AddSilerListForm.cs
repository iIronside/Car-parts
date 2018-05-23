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
    public partial class AddSilerListForm : Form
    {
        SqlConnection sqlCon1; // строка подключения
        string idInvoice;

        public AddSilerListForm(string invoiceID, SqlConnection sqlConnection)
        {
            sqlCon1 = sqlConnection;
            idInvoice = invoiceID;
            InitializeComponent();
        }

        private void AddSilerListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoCarPartShop2DataSet.Запчасть". При необходимости она может быть перемещена или удалена.
            this.запчастьTableAdapter.Fill(this.autoCarPartShop2DataSet.Запчасть);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmdIsertCarPart = new SqlCommand();
            cmdIsertCarPart.CommandType = CommandType.Text;
            //comText


            string comText = "insert into Список_продаж([Код_запчасти], [IDНакладной_продаж], [Количество_запчастей]) values('" + код_запчастиComboBox.Text + "', '" + idInvoice + "', '" + textBox1.Text + "')";
            //Сохранение данных
            try
            {
                cmdIsertCarPart.CommandText = comText;
                cmdIsertCarPart.Connection = sqlCon1;
                cmdIsertCarPart.ExecuteNonQuery();
                MessageBox.Show("Детали были добавлены");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
