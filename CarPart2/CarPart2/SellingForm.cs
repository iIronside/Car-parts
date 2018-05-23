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
    public partial class SellingForm : Form
    {
        SqlConnection sqlCon; // строка подключения

        List<string> NameList = new List<string>();
        List<string> SurnameList = new List<string>();
        List<string> worckNameList = new List<string>();
        List<string> worckSurnameList = new List<string>();


        public SellingForm(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoCarPartShop2DataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.autoCarPartShop2DataSet.Покупатели);
            SqlDataReader fillReader = null;
            SqlCommand commandShow = new SqlCommand(); // класс выполняет комады к БД

            int numRow = 0;
            try
            {
                commandShow.CommandText = "SELECT * FROM Покупатели"; // Заполнение имён покупателей
                commandShow.Connection = sqlCon;
                fillReader = commandShow.ExecuteReader();
                // считывание строк в список
                while (fillReader.Read())
                {
                    NameList.Add(fillReader[1].ToString());
                    SurnameList.Add(fillReader[2].ToString());
                    ++numRow;
                }

                foreach (string str in NameList)
                {
                    comboBox1.Items.Add(str);

                }

                foreach (string str in SurnameList)
                {
                    comboBox2.Items.Add(str);
                }
                fillReader.Close();

                // Заполнение имён сотрудников
                commandShow.CommandText = "SELECT * FROM Cотрудники"; // where IDДолжности = (SELECT IDДолжности FROM Должности WHERE Название _должности = 'Продавец')";
                fillReader = commandShow.ExecuteReader();
                // считывание строк в список
                numRow = 0;
                while (fillReader.Read())
                {
                    worckNameList.Add(fillReader[1].ToString());
                    worckSurnameList.Add(fillReader[2].ToString());
                    ++numRow;
                }

                foreach (string str in worckNameList)
                {
                    comboBox3.Items.Add(str);

                }

                foreach (string str in worckSurnameList)
                {
                    comboBox4.Items.Add(str);
                }
                fillReader.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fillReader != null)
                    fillReader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cusID;
            string worksID;
            SqlDataReader sqlReaderID = null;

            SqlCommand cmdID = new SqlCommand();
            cmdID.Connection = sqlCon;
            cmdID.CommandType = CommandType.Text;
            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
                {

                    string comText = "select IDПокупателя from Покупатели Where Имя = '" + comboBox1.Text + "' AND Фамилия = '" + comboBox2.Text + "'";
                    cmdID.CommandText = comText;
                    sqlReaderID = cmdID.ExecuteReader();// ExecuteNonQuery();
                    sqlReaderID.Read();
                    cusID = sqlReaderID[0].ToString();
                    //MessageBox.Show(cusID);

                    sqlReaderID.Close();

                    comText = "select [IDCотрудника] from [Cотрудники] Where Имя = '" + comboBox3.Text + "' AND Фамилия = '" + comboBox4.Text + "'";
                    cmdID.CommandText = comText;
                    sqlReaderID = cmdID.ExecuteReader();// ExecuteNonQuery();
                    sqlReaderID.Read();
                    worksID = sqlReaderID[0].ToString();
                    //MessageBox.Show(worksID);

                    sqlReaderID.Close();
                    //INSERT INTO Накладная_продаж(Дата_поступления, [IDПокупателя], IDCотрудника) VALUES('07-05-2017', 2, 5) SELECT SCOPE_IDENTITY()
                    DateTime curDate = DateTime.Now;
                    comText = "insert into Накладная_продаж(Дата_поступления, [IDПокупателя], IDCотрудника) values ('" + curDate + "', " + cusID + ", " + worksID + ") SELECT SCOPE_IDENTITY()";
                    cmdID.CommandText = comText;
                    sqlReaderID = cmdID.ExecuteReader();
                    sqlReaderID.Read();
                    string idInvoice = sqlReaderID[0].ToString();

                    AddSilerListForm selListForm = new AddSilerListForm(idInvoice, sqlCon);
                    selListForm.Show();
                    //idInvoice = sqlReaderID[0].ToString();
                    //MessageBox.Show(idInvoice);

                }
                else
                {
                    MessageBox.Show("Не все поля выбраны!", "Моя ошибка", MessageBoxButtons.OK);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Нет соответствующего имени и фамилии", exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReaderID != null)
                    sqlReaderID.Close();
            }
        }
    }
}
