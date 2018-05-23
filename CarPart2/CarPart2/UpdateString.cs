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
    public partial class UpdateString : Form
    {
        SqlConnection sqlCon;
        public UpdateString(SqlConnection sqlConnection)
        {
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void UpdateString_Load(object sender, EventArgs e)
        {
            var tablNames = sqlCon.GetSchema("Tables");
            foreach (DataRow row in tablNames.Rows)
            {
                comboBox1.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int delRow = dataGridView1.SelectedCells[0].RowIndex; // индекс строки выбраной ячейки
            int delColum = dataGridView1.SelectedCells[0].ColumnIndex; // индекс столбца выбраной ячейки
            int colums = dataGridView1.ColumnCount;

            DialogResult dialogResult = MessageBox.Show("Вы действительнохотите измениь " + delRow + 1 + " строку", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.CommandType = CommandType.Text;
                string tmp = " WHERE " + dataGridView1.Columns[0].Name + " = " + dataGridView1.Rows[delRow].Cells[0].Value.ToString() + "";
                //Изменение данных
                try
                {
                    cmdDelete.CommandText = "UPDATE " + comboBox1.Text + " SET ";

                    cmdDelete.CommandText += "" + dataGridView1.Columns[delColum].Name + " = '" + dataGridView1.Rows[delRow].Cells[delColum].Value.ToString() + "'";

                    cmdDelete.CommandText += tmp;
                    cmdDelete.Connection = sqlCon;
                    cmdDelete.ExecuteNonQuery();

                    MessageBox.Show("Строка была изменена", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
