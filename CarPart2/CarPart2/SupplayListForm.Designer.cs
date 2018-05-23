namespace CarPart2
{
    partial class SuplayListForm
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
            System.Windows.Forms.Label количество_запчастейLabel;
            System.Windows.Forms.Label цена_запчастиLabel;
            this.autoCarPartShop2DataSet = new CarPart2.AutoCarPartShop2DataSet();
            this.запчастьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастьTableAdapter = new CarPart2.AutoCarPartShop2DataSetTableAdapters.ЗапчастьTableAdapter();
            this.tableAdapterManager = new CarPart2.AutoCarPartShop2DataSetTableAdapters.TableAdapterManager();
            this.список_поставикиTableAdapter = new CarPart2.AutoCarPartShop2DataSetTableAdapters.Список_поставикиTableAdapter();
            this.код_запчастиComboBox = new System.Windows.Forms.ComboBox();
            this.запчастьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.список_поставикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количество_запчастейTextBox = new System.Windows.Forms.TextBox();
            this.цена_запчастиTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            код_запчастиLabel = new System.Windows.Forms.Label();
            количество_запчастейLabel = new System.Windows.Forms.Label();
            цена_запчастиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_поставикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_запчастиLabel
            // 
            код_запчастиLabel.AutoSize = true;
            код_запчастиLabel.Location = new System.Drawing.Point(16, 24);
            код_запчастиLabel.Name = "код_запчастиLabel";
            код_запчастиLabel.Size = new System.Drawing.Size(78, 13);
            код_запчастиLabel.TabIndex = 1;
            код_запчастиLabel.Text = "Код запчасти:";
            // 
            // количество_запчастейLabel
            // 
            количество_запчастейLabel.AutoSize = true;
            количество_запчастейLabel.Location = new System.Drawing.Point(19, 65);
            количество_запчастейLabel.Name = "количество_запчастейLabel";
            количество_запчастейLabel.Size = new System.Drawing.Size(124, 13);
            количество_запчастейLabel.TabIndex = 2;
            количество_запчастейLabel.Text = "Количество запчастей:";
            // 
            // цена_запчастиLabel
            // 
            цена_запчастиLabel.AutoSize = true;
            цена_запчастиLabel.Location = new System.Drawing.Point(19, 107);
            цена_запчастиLabel.Name = "цена_запчастиLabel";
            цена_запчастиLabel.Size = new System.Drawing.Size(85, 13);
            цена_запчастиLabel.TabIndex = 4;
            цена_запчастиLabel.Text = "Цена запчасти:";
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
            this.tableAdapterManager.Список_поставикиTableAdapter = this.список_поставикиTableAdapter;
            this.tableAdapterManager.Список_продажTableAdapter = null;
            // 
            // список_поставикиTableAdapter
            // 
            this.список_поставикиTableAdapter.ClearBeforeFill = true;
            // 
            // код_запчастиComboBox
            // 
            this.код_запчастиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.запчастьBindingSource, "Код_запчасти", true));
            this.код_запчастиComboBox.DataSource = this.запчастьBindingSource1;
            this.код_запчастиComboBox.DisplayMember = "Код_запчасти";
            this.код_запчастиComboBox.FormattingEnabled = true;
            this.код_запчастиComboBox.Location = new System.Drawing.Point(149, 21);
            this.код_запчастиComboBox.Name = "код_запчастиComboBox";
            this.код_запчастиComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_запчастиComboBox.TabIndex = 2;
            this.код_запчастиComboBox.ValueMember = "Код_запчасти";
            // 
            // запчастьBindingSource1
            // 
            this.запчастьBindingSource1.DataMember = "Запчасть";
            this.запчастьBindingSource1.DataSource = this.autoCarPartShop2DataSet;
            // 
            // список_поставикиBindingSource
            // 
            this.список_поставикиBindingSource.DataMember = "Список_поставики";
            this.список_поставикиBindingSource.DataSource = this.autoCarPartShop2DataSet;
            // 
            // количество_запчастейTextBox
            // 
            this.количество_запчастейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_поставикиBindingSource, "Количество_запчастей", true));
            this.количество_запчастейTextBox.Location = new System.Drawing.Point(149, 62);
            this.количество_запчастейTextBox.Name = "количество_запчастейTextBox";
            this.количество_запчастейTextBox.Size = new System.Drawing.Size(121, 20);
            this.количество_запчастейTextBox.TabIndex = 3;
            // 
            // цена_запчастиTextBox
            // 
            this.цена_запчастиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_поставикиBindingSource, "Цена_запчасти", true));
            this.цена_запчастиTextBox.Location = new System.Drawing.Point(149, 104);
            this.цена_запчастиTextBox.Name = "цена_запчастиTextBox";
            this.цена_запчастиTextBox.Size = new System.Drawing.Size(121, 20);
            this.цена_запчастиTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить запчасть к накладной";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuplayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(цена_запчастиLabel);
            this.Controls.Add(this.цена_запчастиTextBox);
            this.Controls.Add(количество_запчастейLabel);
            this.Controls.Add(this.количество_запчастейTextBox);
            this.Controls.Add(код_запчастиLabel);
            this.Controls.Add(this.код_запчастиComboBox);
            this.Name = "SuplayListForm";
            this.Text = "SuplayForm";
            this.Load += new System.EventHandler(this.SuplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_поставикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoCarPartShop2DataSet autoCarPartShop2DataSet;
        private System.Windows.Forms.BindingSource запчастьBindingSource;
        private AutoCarPartShop2DataSetTableAdapters.ЗапчастьTableAdapter запчастьTableAdapter;
        private AutoCarPartShop2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox код_запчастиComboBox;
        private AutoCarPartShop2DataSetTableAdapters.Список_поставикиTableAdapter список_поставикиTableAdapter;
        private System.Windows.Forms.BindingSource список_поставикиBindingSource;
        private System.Windows.Forms.TextBox количество_запчастейTextBox;
        private System.Windows.Forms.TextBox цена_запчастиTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource запчастьBindingSource1;
    }
}