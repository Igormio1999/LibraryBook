namespace Kulakov.Forms
{
    partial class BookList
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RbId = new System.Windows.Forms.RadioButton();
            this.RbName = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kulakovLBDataSet = new Kulakov.KulakovLBDataSet();
            this.fullBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullBookTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.FullBookTableAdapter();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStellazhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAccessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Все зарегистрированные экземпляры библиотеки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIdDataGridViewTextBoxColumn,
            this.bNameDataGridViewTextBoxColumn,
            this.bStellazhDataGridViewTextBoxColumn,
            this.bAccessDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 208);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RbId);
            this.groupBox1.Controls.Add(this.RbName);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(625, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 283);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 202);
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
            // RbId
            // 
            this.RbId.AutoSize = true;
            this.RbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbId.Location = new System.Drawing.Point(11, 77);
            this.RbId.Name = "RbId";
            this.RbId.Size = new System.Drawing.Size(216, 29);
            this.RbId.TabIndex = 2;
            this.RbId.TabStop = true;
            this.RbId.Text = "Номер экземпляра";
            this.RbId.UseVisualStyleBackColor = true;
            // 
            // RbName
            // 
            this.RbName.AutoSize = true;
            this.RbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbName.Location = new System.Drawing.Point(11, 135);
            this.RbName.Name = "RbName";
            this.RbName.Size = new System.Drawing.Size(176, 29);
            this.RbName.TabIndex = 2;
            this.RbName.TabStop = true;
            this.RbName.Text = "Название книги";
            this.RbName.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(78, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // kulakovLBDataSet
            // 
            this.kulakovLBDataSet.DataSetName = "KulakovLBDataSet";
            this.kulakovLBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullBookBindingSource
            // 
            this.fullBookBindingSource.DataMember = "FullBook";
            this.fullBookBindingSource.DataSource = this.kulakovLBDataSet;
            // 
            // fullBookTableAdapter
            // 
            this.fullBookTableAdapter.ClearBeforeFill = true;
            // 
            // bIdDataGridViewTextBoxColumn
            // 
            this.bIdDataGridViewTextBoxColumn.DataPropertyName = "bId";
            this.bIdDataGridViewTextBoxColumn.HeaderText = "Номер экземпляра";
            this.bIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIdDataGridViewTextBoxColumn.Name = "bIdDataGridViewTextBoxColumn";
            this.bIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "bName";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "Название произведения";
            this.bNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            this.bNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bStellazhDataGridViewTextBoxColumn
            // 
            this.bStellazhDataGridViewTextBoxColumn.DataPropertyName = "bStellazh";
            this.bStellazhDataGridViewTextBoxColumn.HeaderText = "Стелаж";
            this.bStellazhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bStellazhDataGridViewTextBoxColumn.Name = "bStellazhDataGridViewTextBoxColumn";
            this.bStellazhDataGridViewTextBoxColumn.Width = 125;
            // 
            // bAccessDataGridViewCheckBoxColumn
            // 
            this.bAccessDataGridViewCheckBoxColumn.DataPropertyName = "bAccess";
            this.bAccessDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.bAccessDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bAccessDataGridViewCheckBoxColumn.Name = "bAccessDataGridViewCheckBoxColumn";
            this.bAccessDataGridViewCheckBoxColumn.Width = 125;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(62, 286);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(240, 36);
            this.BtUpdate.TabIndex = 12;
            this.BtUpdate.Text = "Обновить";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(330, 286);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(240, 36);
            this.BtSave.TabIndex = 12;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.kulakovLBDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 340);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(905, 387);
            this.MinimumSize = new System.Drawing.Size(905, 387);
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полный список книг";
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbId;
        private System.Windows.Forms.RadioButton RbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private KulakovLBDataSet kulakovLBDataSet;
        private System.Windows.Forms.BindingSource fullBookBindingSource;
        private KulakovLBDataSetTableAdapters.FullBookTableAdapter fullBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStellazhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAccessDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private KulakovLBDataSetTableAdapters.BookTableAdapter bookTableAdapter;
    }
}