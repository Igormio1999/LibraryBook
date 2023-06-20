namespace Kulakov.Forms
{
    partial class ReturnBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbGiveDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbCountDay = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.TbStellazh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BGetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер экземпляра:";
            // 
            // TbBook
            // 
            this.TbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbBook.Location = new System.Drawing.Point(219, 61);
            this.TbBook.Name = "TbBook";
            this.TbBook.Size = new System.Drawing.Size(160, 30);
            this.TbBook.TabIndex = 10;
            this.TbBook.TextChanged += new System.EventHandler(this.TbCopyBook_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Возврат книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата выдачи:";
            // 
            // LbGiveDate
            // 
            this.LbGiveDate.AutoSize = true;
            this.LbGiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGiveDate.Location = new System.Drawing.Point(265, 141);
            this.LbGiveDate.Name = "LbGiveDate";
            this.LbGiveDate.Size = new System.Drawing.Size(114, 25);
            this.LbGiveDate.TabIndex = 9;
            this.LbGiveDate.Text = "2020-06-17";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество дней проката:";
            // 
            // LbCountDay
            // 
            this.LbCountDay.AutoSize = true;
            this.LbCountDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbCountDay.Location = new System.Drawing.Point(345, 177);
            this.LbCountDay.Name = "LbCountDay";
            this.LbCountDay.Size = new System.Drawing.Size(34, 25);
            this.LbCountDay.TabIndex = 9;
            this.LbCountDay.Text = "16";
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(17, 295);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(362, 40);
            this.BtAdd.TabIndex = 12;
            this.BtAdd.Text = "Вернуть экземпляр";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // TbStellazh
            // 
            this.TbStellazh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbStellazh.Location = new System.Drawing.Point(219, 98);
            this.TbStellazh.Name = "TbStellazh";
            this.TbStellazh.Size = new System.Drawing.Size(160, 30);
            this.TbStellazh.TabIndex = 10;
            this.TbStellazh.TextChanged += new System.EventHandler(this.TbCopyBook_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Номер стелажа:";
            // 
            // BGetInfo
            // 
            this.BGetInfo.Location = new System.Drawing.Point(17, 240);
            this.BGetInfo.Name = "BGetInfo";
            this.BGetInfo.Size = new System.Drawing.Size(362, 40);
            this.BGetInfo.TabIndex = 12;
            this.BGetInfo.Text = "Посмотреть информацию";
            this.BGetInfo.UseVisualStyleBackColor = true;
            this.BGetInfo.Click += new System.EventHandler(this.BGetInfo_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 347);
            this.Controls.Add(this.BGetInfo);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbCountDay);
            this.Controls.Add(this.LbGiveDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbStellazh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbBook);
            this.Name = "ReturnBook";
            this.Text = "Возврат книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbGiveDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbCountDay;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.TextBox TbStellazh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BGetInfo;
    }
}