namespace Kulakov.Forms
{
    partial class ListReaders
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formularBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RbYear = new System.Windows.Forms.RadioButton();
            this.RbGroup = new System.Windows.Forms.RadioButton();
            this.RbPhone = new System.Windows.Forms.RadioButton();
            this.RbFIO = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kulakovLBDataSet = new Kulakov.KulakovLBDataSet();
            this.formularBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.formularTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.FormularTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список Читателей";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.formularBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 236);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RbYear);
            this.groupBox1.Controls.Add(this.RbGroup);
            this.groupBox1.Controls.Add(this.RbPhone);
            this.groupBox1.Controls.Add(this.RbFIO);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(539, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 292);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbYear
            // 
            this.RbYear.AutoSize = true;
            this.RbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbYear.Location = new System.Drawing.Point(11, 170);
            this.RbYear.Name = "RbYear";
            this.RbYear.Size = new System.Drawing.Size(182, 29);
            this.RbYear.TabIndex = 2;
            this.RbYear.TabStop = true;
            this.RbYear.Text = "Дата рождения";
            this.RbYear.UseVisualStyleBackColor = true;
            // 
            // RbGroup
            // 
            this.RbGroup.AutoSize = true;
            this.RbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbGroup.Location = new System.Drawing.Point(9, 100);
            this.RbGroup.Name = "RbGroup";
            this.RbGroup.Size = new System.Drawing.Size(97, 29);
            this.RbGroup.TabIndex = 2;
            this.RbGroup.TabStop = true;
            this.RbGroup.Text = "Группа";
            this.RbGroup.UseVisualStyleBackColor = true;
            // 
            // RbPhone
            // 
            this.RbPhone.AutoSize = true;
            this.RbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbPhone.Location = new System.Drawing.Point(9, 135);
            this.RbPhone.Name = "RbPhone";
            this.RbPhone.Size = new System.Drawing.Size(120, 29);
            this.RbPhone.TabIndex = 2;
            this.RbPhone.TabStop = true;
            this.RbPhone.Text = "Телефон";
            this.RbPhone.UseVisualStyleBackColor = true;
            // 
            // RbFIO
            // 
            this.RbFIO.AutoSize = true;
            this.RbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbFIO.Location = new System.Drawing.Point(9, 65);
            this.RbFIO.Name = "RbFIO";
            this.RbFIO.Size = new System.Drawing.Size(87, 29);
            this.RbFIO.TabIndex = 2;
            this.RbFIO.TabStop = true;
            this.RbFIO.Text = "ФИО:";
            this.RbFIO.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(78, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поиск:";
            // 
            // kulakovLBDataSet
            // 
            this.kulakovLBDataSet.DataSetName = "KulakovLBDataSet";
            this.kulakovLBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formularBindingSource2
            // 
            this.formularBindingSource2.DataMember = "Formular";
            this.formularBindingSource2.DataSource = this.kulakovLBDataSet;
            // 
            // formularTableAdapter
            // 
            this.formularTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "formularId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер формуляра:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudentGroup";
            this.dataGridViewTextBoxColumn4.HeaderText = "Группа студента:";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата рождения:";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(280, 300);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(240, 36);
            this.BtSave.TabIndex = 13;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(12, 300);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(240, 36);
            this.BtUpdate.TabIndex = 14;
            this.BtUpdate.Text = "Обновить";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // ListReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 348);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListReaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список читателей";
            this.Load += new System.EventHandler(this.ListReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbYear;
        private System.Windows.Forms.RadioButton RbGroup;
        private System.Windows.Forms.RadioButton RbPhone;
        private System.Windows.Forms.RadioButton RbFIO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
     
        private System.Windows.Forms.BindingSource formularBindingSource;
     
        //private System.Windows.Forms.DataGridViewTextBoxColumn formularIdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentGroupDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.BindingSource formularBindingSource1;
        private KulakovLBDataSet kulakovLBDataSet;
        private System.Windows.Forms.BindingSource formularBindingSource2;
        private KulakovLBDataSetTableAdapters.FormularTableAdapter formularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtUpdate;
    }
}