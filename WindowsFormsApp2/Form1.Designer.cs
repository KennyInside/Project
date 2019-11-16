namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addString = new System.Windows.Forms.Button();
            this.delString = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fruitsTableAdapter = new WindowsFormsApp2.wiserDBDataSet1TableAdapters.fruitsTableAdapter();
            this.wiserDBDataSet2 = new WindowsFormsApp2.wiserDBDataSet2();
            this.fruitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitsTableAdapter1 = new WindowsFormsApp2.wiserDBDataSet2TableAdapters.fruitsTableAdapter();
            this.idFruitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFruitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceFruitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFruitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addString
            // 
            this.addString.Location = new System.Drawing.Point(12, 12);
            this.addString.Name = "addString";
            this.addString.Size = new System.Drawing.Size(75, 23);
            this.addString.TabIndex = 0;
            this.addString.Text = "Add string";
            this.addString.UseVisualStyleBackColor = true;
            this.addString.Click += new System.EventHandler(this.AddString_Click);
            // 
            // delString
            // 
            this.delString.Location = new System.Drawing.Point(12, 41);
            this.delString.Name = "delString";
            this.delString.Size = new System.Drawing.Size(75, 23);
            this.delString.TabIndex = 1;
            this.delString.Text = "Delete string";
            this.delString.UseVisualStyleBackColor = true;
            this.delString.Click += new System.EventHandler(this.DelString_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFruitDataGridViewTextBoxColumn,
            this.nameFruitDataGridViewTextBoxColumn,
            this.priceFruitDataGridViewTextBoxColumn,
            this.countFruitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fruitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // fruitsTableAdapter
            // 
            this.fruitsTableAdapter.ClearBeforeFill = true;
            // 
            // wiserDBDataSet2
            // 
            this.wiserDBDataSet2.DataSetName = "wiserDBDataSet2";
            this.wiserDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitsBindingSource
            // 
            this.fruitsBindingSource.DataMember = "fruits";
            this.fruitsBindingSource.DataSource = this.wiserDBDataSet2;
            // 
            // fruitsTableAdapter1
            // 
            this.fruitsTableAdapter1.ClearBeforeFill = true;
            // 
            // idFruitDataGridViewTextBoxColumn
            // 
            this.idFruitDataGridViewTextBoxColumn.DataPropertyName = "idFruit";
            this.idFruitDataGridViewTextBoxColumn.HeaderText = "idFruit";
            this.idFruitDataGridViewTextBoxColumn.Name = "idFruitDataGridViewTextBoxColumn";
            // 
            // nameFruitDataGridViewTextBoxColumn
            // 
            this.nameFruitDataGridViewTextBoxColumn.DataPropertyName = "nameFruit";
            this.nameFruitDataGridViewTextBoxColumn.HeaderText = "nameFruit";
            this.nameFruitDataGridViewTextBoxColumn.Name = "nameFruitDataGridViewTextBoxColumn";
            // 
            // priceFruitDataGridViewTextBoxColumn
            // 
            this.priceFruitDataGridViewTextBoxColumn.DataPropertyName = "priceFruit";
            this.priceFruitDataGridViewTextBoxColumn.HeaderText = "priceFruit";
            this.priceFruitDataGridViewTextBoxColumn.Name = "priceFruitDataGridViewTextBoxColumn";
            // 
            // countFruitDataGridViewTextBoxColumn
            // 
            this.countFruitDataGridViewTextBoxColumn.DataPropertyName = "countFruit";
            this.countFruitDataGridViewTextBoxColumn.HeaderText = "countFruit";
            this.countFruitDataGridViewTextBoxColumn.Name = "countFruitDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delString);
            this.Controls.Add(this.addString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addString;
        private System.Windows.Forms.Button delString;
        private System.Windows.Forms.DataGridView dataGridView1;
        private wiserDBDataSet1TableAdapters.fruitsTableAdapter fruitsTableAdapter;
        private wiserDBDataSet2 wiserDBDataSet2;
        private System.Windows.Forms.BindingSource fruitsBindingSource;
        private wiserDBDataSet2TableAdapters.fruitsTableAdapter fruitsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFruitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFruitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFruitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFruitDataGridViewTextBoxColumn;
    }
}

