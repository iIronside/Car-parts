namespace CarPart2
{
    partial class SupplyForm
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
            System.Windows.Forms.Label имя_компанииLabel;
            this.autoCarPartShop2DataSet = new CarPart2.AutoCarPartShop2DataSet();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new CarPart2.AutoCarPartShop2DataSetTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new CarPart2.AutoCarPartShop2DataSetTableAdapters.TableAdapterManager();
            this.имя_компанииComboBox = new System.Windows.Forms.ComboBox();
            this.поставщикBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            имя_компанииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // имя_компанииLabel
            // 
            имя_компанииLabel.AutoSize = true;
            имя_компанииLabel.Location = new System.Drawing.Point(10, 40);
            имя_компанииLabel.Name = "имя_компанииLabel";
            имя_компанииLabel.Size = new System.Drawing.Size(150, 13);
            имя_компанииLabel.TabIndex = 1;
            имя_компанииLabel.Text = "Имя компании поставщика:";
            // 
            // autoCarPartShop2DataSet
            // 
            this.autoCarPartShop2DataSet.DataSetName = "AutoCarPartShop2DataSet";
            this.autoCarPartShop2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.autoCarPartShop2DataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CотрудникиTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarPart2.AutoCarPartShop2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗапчастьTableAdapter = null;
            this.tableAdapterManager.МаркаTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.Накладная_поставкиTableAdapter = null;
            this.tableAdapterManager.Накладная_продажTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.Список_поставикиTableAdapter = null;
            this.tableAdapterManager.Список_продажTableAdapter = null;
            // 
            // имя_компанииComboBox
            // 
            this.имя_компанииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Имя_компании", true));
            this.имя_компанииComboBox.DataSource = this.поставщикBindingSource1;
            this.имя_компанииComboBox.DisplayMember = "Имя_компании";
            this.имя_компанииComboBox.FormattingEnabled = true;
            this.имя_компанииComboBox.Location = new System.Drawing.Point(166, 37);
            this.имя_компанииComboBox.Name = "имя_компанииComboBox";
            this.имя_компанииComboBox.Size = new System.Drawing.Size(121, 21);
            this.имя_компанииComboBox.TabIndex = 2;
            this.имя_компанииComboBox.ValueMember = "IDПоставщика";
            // 
            // поставщикBindingSource1
            // 
            this.поставщикBindingSource1.DataMember = "Поставщик";
            this.поставщикBindingSource1.DataSource = this.autoCarPartShop2DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать накладную поставки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(имя_компанииLabel);
            this.Controls.Add(this.имя_компанииComboBox);
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoCarPartShop2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoCarPartShop2DataSet autoCarPartShop2DataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private AutoCarPartShop2DataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private AutoCarPartShop2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox имя_компанииComboBox;
        private System.Windows.Forms.BindingSource поставщикBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}