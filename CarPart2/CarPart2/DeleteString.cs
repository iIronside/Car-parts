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
    public partial class DeleteString : Form
    {
        SqlConnection sqlCon; // строка подключения
        List<string[]> dataList = new List<string[]>(); // буфер хранящий элементы строки таблицы перед выводом

        public DeleteString(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void DeleteString_Load(object sender, EventArgs e)
        {
            var tablNames = sqlCon.GetSchema("Tables");
            foreach (DataRow row in tablNames.Rows)
            {
                comboBox1.Items.Add(row["TABLE_NAME"]);
            }
        }

        /// <summary>
        /// Вывод окна для удаления строки
        /// </summary>
        /// <param name="сolumsNumber"></param>
        /// <param name="nameRows"></param>
        private void showDeliteDialog(int сolumsNumber, string[] nameRows)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show(dataGridView1.SelectedCells[0].RowIndex.ToString());
                int delRow = dataGridView1.SelectedCells[0].RowIndex; // индекс строки выбраной ячейки
                int delColum = dataGridView1.SelectedCells[0].ColumnIndex; // индекс столбца выбраной ячейки

                DialogResult dialogResult = MessageBox.Show("Вы действительнохотите удалить " + delRow + " строку", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.CommandType = CommandType.Text;

                    //Удаление данных
                    try
                    {
                        cmdDelete.CommandText = "DELETE FROM " + comboBox1.Text + " WHERE " + dataGridView1.Columns[delColum].Name + " = '" + dataGridView1.Rows[delRow].Cells[delColum].Value.ToString() + "'";
                        cmdDelete.Connection = sqlCon;
                        cmdDelete.ExecuteNonQuery();
                        MessageBox.Show("Строка была удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            showDeliteDialog(numberOfColums, rowsName);
        }
    }
}
