using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarPart2
{
    public partial class AddStringInTable : Form
    {
        SqlConnection sqlCon; // строка подключения

        public AddStringInTable(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void AddStringInTable_Load(object sender, EventArgs e)
        {
            var tablNames = sqlCon.GetSchema("Tables");
            foreach (DataRow row in tablNames.Rows)
            {
                comboBox1.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand insertCommandNoIdentity;
            SqlDataReader sqlInsertReader = null;

            ArrayList rowsNameNoIdentityList = new ArrayList();
            int numOfColumsNoIdentity = 0;
            try
            {
                insertCommandNoIdentity = new SqlCommand("SELECT * FROM " + comboBox1.Text + "", sqlCon);
                sqlInsertReader = insertCommandNoIdentity.ExecuteReader();

                int numberOfColums = sqlInsertReader.FieldCount; // получает кол-во столбцов в таблице
                
                string[] rowsName = new string[numberOfColums]; // имена столбцов
                // считывание имён столбцов и их типов
                for (int i = 0; i < numberOfColums; ++i)
                {
                    rowsName[i] = sqlInsertReader.GetName(i);
                }
                sqlInsertReader.Close();

                for (int i = 0; i < numberOfColums; ++i)
                {
                    insertCommandNoIdentity.CommandText = "SELECT COLUMNPROPERTY(OBJECT_ID('" + comboBox1.Text + "'),'" + rowsName[i] + "','IsIdentity')"; // rowsName[i]
                    sqlInsertReader = insertCommandNoIdentity.ExecuteReader();
                    sqlInsertReader.Read();
                    //MessageBox.Show(rowsName[i]);

                    if ((int)sqlInsertReader[0] > 0)
                    {
                        sqlInsertReader.Close();
                        continue;
                    }

                    rowsNameNoIdentityList.Add(rowsName[i]);
                    ++numOfColumsNoIdentity; // подсчёт количества столбцов без Identity

                    sqlInsertReader.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlInsertReader != null)
                    sqlInsertReader.Close();
            }
            ShowInsertDialog(numOfColumsNoIdentity, rowsNameNoIdentityList);
        }

        /// <summary>
        /// Вывод страницы для вода данных
        /// </summary>
        private void ShowInsertDialog(int сolumsNumber, ArrayList nameRows)
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
                dataGridView1.Columns[i].Name = nameRows[i].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int rows = dataGridView1.RowCount - 1; // не учитывать последнюю строку(пустая)
                int colums = dataGridView1.ColumnCount;
                string[,] data = new string[rows, colums]; // введенные данные

                if (rows > 0) // Проверка на пустоту
                {
                    for (int i = 0; i < rows; ++i)
                    {
                        for (int j = 0; j < colums; ++j)
                        {
                            data[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    SqlCommand cmdIsert = new SqlCommand();
                    cmdIsert.CommandType = CommandType.Text;
                    string comText = "INSERT INTO " + comboBox1.Text + "(";

                    //Заполнение запроса параметрами
                    comText += dataGridView1.Columns[0].Name;
                    for (int i = 1; i < colums; ++i)
                    {
                        comText += ", " + dataGridView1.Columns[i].Name + "";
                    }
                    comText += ") VALUES(";

                    //Заполнения запроса значениями
                    for (int i = 0; i < rows; ++i)
                    {
                        comText += "'" + data[i, 0] + "'";
                        for (int j = 0; j < colums; ++j)
                        {
                            if (j == 0)
                            {
                                continue;
                            }
                            comText += ", '" + data[i, j] + "'";
                        }

                        if (i == rows - 1)
                            comText += ");";
                        else
                            comText += "), (";
                    }

                    //Сохранение данных
                    try
                    {
                        cmdIsert.CommandText = comText;
                        cmdIsert.Connection = sqlCon;
                        cmdIsert.ExecuteNonQuery();
                        MessageBox.Show("Запись была добавлена");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Выберете обробатываемую таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
