namespace CarPart2
{
    partial class AddSilerListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_запчастиLabel;
            this.autoCarPartShop2DataSet = new CarPart2.AutoCarPartShop2DataSet();
            this.запчастьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастьTableAdapter = new CarPart2.AutoCarPartShop2DataSetTableAdapters.ЗапчастьTableAdapter();
            this.tableAdapterManager = new CarPart2.AutoCarPartShop2DataSetTableAdapters.TableAdapterManager();
            this.код_запчастиComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.запчастьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            код_запчастиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_запчастиLabel
            // 
            код_запчастиLabel.AutoSize = true;
            код_запчастиLabel.Location = new System.Drawing.Point(26, 37);
            код_запчастиLabel.Name = "код_запчастиLabel";
            код_запчастиLabel.Size = new System.Drawing.Size(78, 13);
            код_запчастиLabel.TabIndex = 1;
            код_запчастиLabel.Text = "Код запчасти:";
            // 
            // autoCarPartShop2DataSet
            // 
            this.autoCarPartShop2DataSet.DataSetName = "AutoCarPartShop2DataSet";
            this.autoCarPartShop2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запчастьBindingSource
            // 
            this.запчастьBindingSource.DataMember = "Запчасть";
            this.запчастьBindingSource.DataSource = this.autoCarPartShop2DataSet;
            // 
            // запчастьTableAdapter
            // 
            this.запчастьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CотрудникиTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarPart2.AutoCarPartShop2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗапчастьTableAdapter = this.запчастьTableAdapter;
            this.tableAdapterManager.МаркаTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.Накладная_поставкиTableAdapter = null;
            this.tableAdapterManager.Накладная_продажTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Список_поставикиTableAdapter = null;
            this.tableAdapterManager.Список_продажTableAdapter = null;
            // 
            // код_запчастиComboBox
            // 
            this.код_запчастиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.запчастьBindingSource, "Код_запчасти", true));
            this.код_запчастиComboBox.DataSource = this.запчастьBindingSource1;
            this.код_запчастиComboBox.DisplayMember = "Код_запчасти";
            this.код_запчастиComboBox.FormattingEnabled = true;
            this.код_запчастиComboBox.Location = new System.Drawing.Point(173, 37);
            this.код_запчастиComboBox.Name = "код_запчастиComboBox";
            this.код_запчастиComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_запчастиComboBox.TabIndex = 2;
            this.код_запчастиComboBox.ValueMember = "Код_запчасти";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество запчастей";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавть запчасть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // запчастьBindingSource1
            // 
            this.запчастьBindingSource1.DataMember = "Запчасть";
            this.запчастьBindingSource1.DataSource = this.autoCarPartShop2DataSet;
            // 
            // AddSilerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(код_запчастиLabel);
            this.Controls.Add(this.код_запчастиComboBox);
            this.Name = "AddSilerListForm";
            this.Text = "AddSilerListForm";
            this.Load += new System.EventHandler(this.AddSilerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoCarPartShop2DataSet autoCarPartShop2DataSet;
        private System.Windows.Forms.BindingSource запчастьBindingSource;
        private AutoCarPartShop2DataSetTableAdapters.ЗапчастьTableAdapter запчастьTableAdapter;
        private AutoCarPartShop2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox код_запчастиComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource запчастьBindingSource1;
    }
}