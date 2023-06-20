namespace Kulakov.Forms
{
    partial class Extendbook
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
            this.BGetInfo = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbBook = new System.Windows.Forms.TextBox();
            this.LbCountDay = new System.Windows.Forms.Label();
            this.LbGiveDate = new System.Windows.Forms.Label();
            this.TbDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGetInfo
            // 
            this.BGetInfo.Location = new System.Drawing.Point(9, 273);
            this.BGetInfo.Name = "BGetInfo";
            this.BGetInfo.Size = new System.Drawing.Size(362, 40);
            this.BGetInfo.TabIndex = 20;
            this.BGetInfo.Text = "Посмотреть информацию";
            this.BGetInfo.UseVisualStyleBackColor = true;
            this.BGetInfo.Click += new System.EventHandler(this.BGetInfo_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(9, 328);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(362, 40);
            this.BtAdd.TabIndex = 21;
            this.BtAdd.Text = "Продлить";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Продлить срок возрата книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество дней:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата выдачи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер экземпляра:";
            // 
            // TbBook
            // 
            this.TbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbBook.Location = new System.Drawing.Point(221, 67);
            this.TbBook.Name = "TbBook";
            this.TbBook.Size = new System.Drawing.Size(160, 30);
            this.TbBook.TabIndex = 18;
            // 
            // LbCountDay
            // 
            this.LbCountDay.AutoSize = true;
            this.LbCountDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbCountDay.Location = new System.Drawing.Point(337, 146);
            this.LbCountDay.Name = "LbCountDay";
            this.LbCountDay.Size = new System.Drawing.Size(34, 25);
            this.LbCountDay.TabIndex = 13;
            this.LbCountDay.Text = "16";
            // 
            // LbGiveDate
            // 
            this.LbGiveDate.AutoSize = true;
            this.LbGiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGiveDate.Location = new System.Drawing.Point(257, 109);
            this.LbGiveDate.Name = "LbGiveDate";
            this.LbGiveDate.Size = new System.Drawing.Size(114, 25);
            this.LbGiveDate.TabIndex = 13;
            this.LbGiveDate.Text = "2020-06-17";
            // 
            // TbDays
            // 
            this.TbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDays.Location = new System.Drawing.Point(221, 183);
            this.TbDays.Name = "TbDays";
            this.TbDays.Size = new System.Drawing.Size(160, 30);
            this.TbDays.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Продлить на (дней):";
            // 
            // Extendbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 385);
            this.Controls.Add(this.BGetInfo);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbGiveDate);
            this.Controls.Add(this.LbCountDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDays);
            this.Controls.Add(this.TbBook);
            this.Name = "Extendbook";
            this.Text = "Продлить срок возврата";
            this.Load += new System.EventHandler(this.Extendbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGetInfo;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbBook;
        private System.Windows.Forms.Label LbCountDay;
        private System.Windows.Forms.Label LbGiveDate;
        private System.Windows.Forms.TextBox TbDays;
        private System.Windows.Forms.Label label4;
    }
}