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
    public partial class SuplayListForm : Form
    {
        SqlConnection sqlCon = null;
        string idsupplay;

        public SuplayListForm(SqlConnection sqlConnection, string id)
        {
            idsupplay = id;
            sqlCon = sqlConnection;
            InitializeComponent();
        }

        private void запчастьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запчастьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoCarPartShop2DataSet);

        }

        private void SuplayForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoCarPartShop2DataSet.Список_поставики". При необходимости она может быть перемещена или удалена.
            this.список_поставикиTableAdapter.Fill(this.autoCarPartShop2DataSet.Список_поставики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoCarPartShop2DataSet.Запчасть". При необходимости она может быть перемещена или удалена.
            this.запчастьTableAdapter.Fill(this.autoCarPartShop2DataSet.Запчасть);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime curDate = DateTime.Now;
                SqlCommand comAddSupList = new SqlCommand("INSERT into Список_поставики([IDНакладной_поставки], Код_запчасти, Количество_запчастей, Цена_запчасти, Дата_заказа) values('" + idsupplay + "', "+ код_запчастиComboBox.SelectedValue + ", "+ количество_запчастейTextBox.Text + ", "+ цена_запчастиTextBox.Text + ", '"+ curDate +"')", sqlCon);
                comAddSupList.ExecuteNonQuery();
                MessageBox.Show("Запчасти заказаны");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
