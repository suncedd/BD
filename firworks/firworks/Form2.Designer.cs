namespace firworks
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.фейерверкDataSet4 = new firworks.ФейерверкDataSet4();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new firworks.ФейерверкDataSet4TableAdapters.ПоставщикTableAdapter();
            this.фейерверкDataSet5 = new firworks.ФейерверкDataSet5();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new firworks.ФейерверкDataSet5TableAdapters.ТоварTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.фейерверкDataSet6 = new firworks.ФейерверкDataSet6();
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter1 = new firworks.ФейерверкDataSet6TableAdapters.ТоварTableAdapter();
            this.фейерверкDataSet7 = new firworks.ФейерверкDataSet7();
            this.товарBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter2 = new firworks.ФейерверкDataSet7TableAdapters.ТоварTableAdapter();
            this.фейерверкDataSet8 = new firworks.ФейерверкDataSet8();
            this.поставщикBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter1 = new firworks.ФейерверкDataSet8TableAdapters.ПоставщикTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.поставщикBindingSource1;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "КодПоставщика";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.товарBindingSource2;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(609, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "КодТовара";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // фейерверкDataSet4
            // 
            this.фейерверкDataSet4.DataSetName = "ФейерверкDataSet4";
            this.фейерверкDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.фейерверкDataSet4;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // фейерверкDataSet5
            // 
            this.фейерверкDataSet5.DataSetName = "ФейерверкDataSet5";
            this.фейерверкDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.фейерверкDataSet5;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // фейерверкDataSet6
            // 
            this.фейерверкDataSet6.DataSetName = "ФейерверкDataSet6";
            this.фейерверкDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "Товар";
            this.товарBindingSource1.DataSource = this.фейерверкDataSet6;
            // 
            // товарTableAdapter1
            // 
            this.товарTableAdapter1.ClearBeforeFill = true;
            // 
            // фейерверкDataSet7
            // 
            this.фейерверкDataSet7.DataSetName = "ФейерверкDataSet7";
            this.фейерверкDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource2
            // 
            this.товарBindingSource2.DataMember = "Товар";
            this.товарBindingSource2.DataSource = this.фейерверкDataSet7;
            // 
            // товарTableAdapter2
            // 
            this.товарTableAdapter2.ClearBeforeFill = true;
            // 
            // фейерверкDataSet8
            // 
            this.фейерверкDataSet8.DataSetName = "ФейерверкDataSet8";
            this.фейерверкDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикBindingSource1
            // 
            this.поставщикBindingSource1.DataMember = "Поставщик";
            this.поставщикBindingSource1.DataSource = this.фейерверкDataSet8;
            // 
            // поставщикTableAdapter1
            // 
            this.поставщикTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фейерверкDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ФейерверкDataSet4 фейерверкDataSet4;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private ФейерверкDataSet4TableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private ФейерверкDataSet5 фейерверкDataSet5;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ФейерверкDataSet5TableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Button button2;
        private ФейерверкDataSet6 фейерверкDataSet6;
        private System.Windows.Forms.BindingSource товарBindingSource1;
        private ФейерверкDataSet6TableAdapters.ТоварTableAdapter товарTableAdapter1;
        private ФейерверкDataSet7 фейерверкDataSet7;
        private System.Windows.Forms.BindingSource товарBindingSource2;
        private ФейерверкDataSet7TableAdapters.ТоварTableAdapter товарTableAdapter2;
        private ФейерверкDataSet8 фейерверкDataSet8;
        private System.Windows.Forms.BindingSource поставщикBindingSource1;
        private ФейерверкDataSet8TableAdapters.ПоставщикTableAdapter поставщикTableAdapter1;
    }
}