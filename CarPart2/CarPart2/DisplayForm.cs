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
    public partial class DisplayForm : Form
    {
        SqlConnection sqlCon; // строка подключения
        List<string[]> dataList = new List<string[]>(); // буфер хранящий элементы строки таблицы перед выводом

        public DisplayForm(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            var tablNames = sqlCon.GetSchema("Tables");
            foreach (DataRow row in tablNames.Rows)
            {
                comboBox1.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Данные для вывода таблицы
            SqlDataReader sqlReader = null;
            SqlCommand commandShow = new SqlCommand(); // класс выполняет комады к БД

            commandShow.CommandText = "SELECT * FROM " + comboBox1.Text; // запрос на вывод таблицы выбраной в comboBox
            commandShow.Connection = sqlCon;
            sqlReader = commandShow.ExecuteReader();

            int numberOfColums = sqlReader.FieldCount; // получает кол-во столбцов в таблице
            string[] rowsName = new string[numberOfColums]; // имена столбцов

            try
            {
                // считывание строк в список
                dataList.Clear(); // очистить список
                while (sqlReader.Read())
                {
                    dataList.Add(new string[numberOfColums]);
                    for (int i = 0; i < numberOfColums; ++i)
                    {
                        dataList[dataList.Count - 1][i] = sqlReader[i].ToString();
                    }
                }

                // считывание имён столбцов и их типов
                for (int i = 0; i < numberOfColums; ++i)
                {
                    rowsName[i] = sqlReader.GetName(i);
                }
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
            ShowTable(numberOfColums, rowsName);
        }

        private void ShowTable(int сolumsNumber, string[] nameRows)
        {
            // очистить dataGridView
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }

            // инициализация столбцов
            dataGridView1.ColumnCount = сolumsNumber;
            for (int i = 0; i < сolumsNumber; ++i)
            {
                dataGridView1.Columns[i].Name = nameRows[i];
            }

            // заполнение строк
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);
        }
    }
}
