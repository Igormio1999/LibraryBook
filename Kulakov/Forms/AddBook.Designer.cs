namespace Kulakov.Forms
{
    partial class AddBook
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
            this.TbStellazh = new System.Windows.Forms.TextBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.CbAutor = new System.Windows.Forms.ComboBox();
            this.autorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CbPublisher = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CbGenry = new System.Windows.Forms.ComboBox();
            this.genryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorId = new System.Windows.Forms.Label();
            this.Publd = new System.Windows.Forms.Label();
            this.GenryId = new System.Windows.Forms.Label();
            this.kulakovLBDataSet = new Kulakov.KulakovLBDataSet();
            this.genryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genryTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.GenryTableAdapter();
            this.publisherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.PublisherTableAdapter();
            this.autorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.autorTableAdapter = new Kulakov.KulakovLBDataSetTableAdapters.AutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация новой книги";
            // 
            // TbStellazh
            // 
            this.TbStellazh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbStellazh.Location = new System.Drawing.Point(273, 217);
            this.TbStellazh.Name = "TbStellazh";
            this.TbStellazh.Size = new System.Drawing.Size(329, 30);
            this.TbStellazh.TabIndex = 16;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Номер стелажа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Издательство:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Автор:";
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbName.Location = new System.Drawing.Point(273, 67);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(329, 30);
            this.TbName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Название";
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(359, 303);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(244, 42);
            this.BtClear.TabIndex = 21;
            this.BtClear.Text = "Очистить";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(27, 303);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(244, 42);
            this.BtAdd.TabIndex = 22;
            this.BtAdd.Text = "Регистрация";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // CbAutor
            // 
            this.CbAutor.DataSource = this.autorBindingSource2;
            this.CbAutor.DisplayMember = "aName";
            this.CbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbAutor.FormattingEnabled = true;
            this.CbAutor.Location = new System.Drawing.Point(273, 101);
            this.CbAutor.Name = "CbAutor";
            this.CbAutor.Size = new System.Drawing.Size(329, 33);
            this.CbAutor.TabIndex = 23;
            // 
            // CbPublisher
            // 
            this.CbPublisher.DataSource = this.publisherBindingSource2;
            this.CbPublisher.DisplayMember = "pName";
            this.CbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbPublisher.FormattingEnabled = true;
            this.CbPublisher.Location = new System.Drawing.Point(273, 138);
            this.CbPublisher.Name = "CbPublisher";
            this.CbPublisher.Size = new System.Drawing.Size(329, 33);
            this.CbPublisher.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Жанр";
            // 
            // CbGenry
            // 
            this.CbGenry.DataSource = this.genryBindingSource1;
            this.CbGenry.DisplayMember = "gName";
            this.CbGenry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGenry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbGenry.FormattingEnabled = true;
            this.CbGenry.Location = new System.Drawing.Point(273, 174);
            this.CbGenry.Name = "CbGenry";
            this.CbGenry.Size = new System.Drawing.Size(329, 33);
            this.CbGenry.TabIndex = 23;
            // 
            // autorId
            // 
            this.autorId.AutoSize = true;
            this.autorId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource2, "aId", true));
            this.autorId.Location = new System.Drawing.Point(678, 107);
            this.autorId.Name = "autorId";
            this.autorId.Size = new System.Drawing.Size(13, 17);
            this.autorId.TabIndex = 24;
            this.autorId.Text = "*";
            // 
            // Publd
            // 
            this.Publd.AutoSize = true;
            this.Publd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource2, "pId", true));
            this.Publd.Location = new System.Drawing.Point(678, 146);
            this.Publd.Name = "Publd";
            this.Publd.Size = new System.Drawing.Size(13, 17);
            this.Publd.TabIndex = 24;
            this.Publd.Text = "*";
            // 
            // GenryId
            // 
            this.GenryId.AutoSize = true;
            this.GenryId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genryBindingSource1, "gId", true));
            this.GenryId.Location = new System.Drawing.Point(678, 182);
            this.GenryId.Name = "GenryId";
            this.GenryId.Size = new System.Drawing.Size(13, 17);
            this.GenryId.TabIndex = 24;
            this.GenryId.Text = "*";
            // 
            // kulakovLBDataSet
            // 
            this.kulakovLBDataSet.DataSetName = "KulakovLBDataSet";
            this.kulakovLBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genryBindingSource1
            // 
            this.genryBindingSource1.DataMember = "Genry";
            this.genryBindingSource1.DataSource = this.kulakovLBDataSet;
            // 
            // genryTableAdapter
            // 
            this.genryTableAdapter.ClearBeforeFill = true;
            // 
            // publisherBindingSource2
            // 
            this.publisherBindingSource2.DataMember = "Publisher";
            this.publisherBindingSource2.DataSource = this.kulakovLBDataSet;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // autorBindingSource2
            // 
            this.autorBindingSource2.DataMember = "Autor";
            this.autorBindingSource2.DataSource = this.kulakovLBDataSet;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 357);
            this.Controls.Add(this.GenryId);
            this.Controls.Add(this.Publd);
            this.Controls.Add(this.autorId);
            this.Controls.Add(this.CbGenry);
            this.Controls.Add(this.CbPublisher);
            this.Controls.Add(this.CbAutor);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.TbStellazh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(642, 404);
            this.MinimumSize = new System.Drawing.Size(642, 404);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация книги";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kulakovLBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbStellazh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.ComboBox CbAutor;
        
        private System.Windows.Forms.BindingSource autorBindingSource;
       
        private System.Windows.Forms.ComboBox CbPublisher;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        
        private System.Windows.Forms.BindingSource autorBindingSource1;
        
        private System.Windows.Forms.BindingSource publisherBindingSource1;
       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbGenry;
        private System.Windows.Forms.BindingSource genryBindingSource;
        
        private System.Windows.Forms.Label autorId;
        private System.Windows.Forms.Label Publd;
        private System.Windows.Forms.Label GenryId;
        private KulakovLBDataSet kulakovLBDataSet;
        private System.Windows.Forms.BindingSource genryBindingSource1;
        private KulakovLBDataSetTableAdapters.GenryTableAdapter genryTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource2;
        private KulakovLBDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource autorBindingSource2;
        private KulakovLBDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
    }
}