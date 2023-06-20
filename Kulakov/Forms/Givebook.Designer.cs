namespace Kulakov.Forms
{
    partial class Givebook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCopyBook = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtCheck = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbNumberReaders = new System.Windows.Forms.TextBox();
            this.LbFIO = new System.Windows.Forms.Label();
            this.LbPhone = new System.Windows.Forms.Label();
            this.LbGroup = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbNumberBook = new System.Windows.Forms.Label();
            this.LbAutorBook = new System.Windows.Forms.Label();
            this.LbFolmularBook = new System.Windows.Forms.Label();
            this.LbNameBook = new System.Windows.Forms.Label();
            this.BtExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(245, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Организация выдачи книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер экземпляра:";
            // 
            // TbCopyBook
            // 
            this.TbCopyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbCopyBook.Location = new System.Drawing.Point(213, 24);
            this.TbCopyBook.Name = "TbCopyBook";
            this.TbCopyBook.Size = new System.Drawing.Size(155, 30);
            this.TbCopyBook.TabIndex = 8;
            this.TbCopyBook.TextChanged += new System.EventHandler(this.TbCopyBook_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BtClear);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtAdd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtCheck);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbDays);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbNumberReaders);
            this.groupBox1.Controls.Add(this.LbFIO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LbPhone);
            this.groupBox1.Controls.Add(this.TbCopyBook);
            this.groupBox1.Controls.Add(this.LbGroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LbNumberBook);
            this.groupBox1.Controls.Add(this.LbAutorBook);
            this.groupBox1.Controls.Add(this.LbFolmularBook);
            this.groupBox1.Controls.Add(this.LbNameBook);
            this.groupBox1.Location = new System.Drawing.Point(20, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 300);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выдача книги";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(408, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Телефон читателя:";
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(6, 251);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(362, 37);
            this.BtClear.TabIndex = 9;
            this.BtClear.Text = "Очистить поля";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(408, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Группа читателя:";
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(6, 160);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(362, 37);
            this.BtAdd.TabIndex = 9;
            this.BtAdd.Text = "Оформить выдачу";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(408, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ФИО читателя:";
            // 
            // BtCheck
            // 
            this.BtCheck.Location = new System.Drawing.Point(6, 203);
            this.BtCheck.Name = "BtCheck";
            this.BtCheck.Size = new System.Drawing.Size(362, 37);
            this.BtCheck.TabIndex = 9;
            this.BtCheck.Text = "Проверить информацию";
            this.BtCheck.UseVisualStyleBackColor = true;
            this.BtCheck.Click += new System.EventHandler(this.BtCheck_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(408, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Номер формуляра:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество дней:";
            // 
            // TbDays
            // 
            this.TbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDays.Location = new System.Drawing.Point(213, 106);
            this.TbDays.Name = "TbDays";
            this.TbDays.Size = new System.Drawing.Size(155, 30);
            this.TbDays.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(408, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Автор книги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер формуляра:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(408, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Название книги:";
            // 
            // TbNumberReaders
            // 
            this.TbNumberReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbNumberReaders.Location = new System.Drawing.Point(213, 63);
            this.TbNumberReaders.Name = "TbNumberReaders";
            this.TbNumberReaders.Size = new System.Drawing.Size(155, 30);
            this.TbNumberReaders.TabIndex = 8;
            // 
            // LbFIO
            // 
            this.LbFIO.AutoSize = true;
            this.LbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbFIO.Location = new System.Drawing.Point(658, 184);
            this.LbFIO.Name = "LbFIO";
            this.LbFIO.Size = new System.Drawing.Size(20, 25);
            this.LbFIO.TabIndex = 0;
            this.LbFIO.Text = "*";
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbPhone.Location = new System.Drawing.Point(658, 254);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(20, 25);
            this.LbPhone.TabIndex = 0;
            this.LbPhone.Text = "*";
            // 
            // LbGroup
            // 
            this.LbGroup.AutoSize = true;
            this.LbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGroup.Location = new System.Drawing.Point(658, 218);
            this.LbGroup.Name = "LbGroup";
            this.LbGroup.Size = new System.Drawing.Size(20, 25);
            this.LbGroup.TabIndex = 0;
            this.LbGroup.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер экземпляра:";
            // 
            // LbNumberBook
            // 
            this.LbNumberBook.AutoSize = true;
            this.LbNumberBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbNumberBook.Location = new System.Drawing.Point(658, 18);
            this.LbNumberBook.Name = "LbNumberBook";
            this.LbNumberBook.Size = new System.Drawing.Size(20, 25);
            this.LbNumberBook.TabIndex = 0;
            this.LbNumberBook.Text = "*";
            // 
            // LbAutorBook
            // 
            this.LbAutorBook.AutoSize = true;
            this.LbAutorBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbAutorBook.Location = new System.Drawing.Point(658, 120);
            this.LbAutorBook.Name = "LbAutorBook";
            this.LbAutorBook.Size = new System.Drawing.Size(20, 25);
            this.LbAutorBook.TabIndex = 0;
            this.LbAutorBook.Text = "*";
            // 
            // LbFolmularBook
            // 
            this.LbFolmularBook.AutoSize = true;
            this.LbFolmularBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbFolmularBook.Location = new System.Drawing.Point(658, 55);
            this.LbFolmularBook.Name = "LbFolmularBook";
            this.LbFolmularBook.Size = new System.Drawing.Size(20, 25);
            this.LbFolmularBook.TabIndex = 0;
            this.LbFolmularBook.Text = "*";
            // 
            // LbNameBook
            // 
            this.LbNameBook.AutoSize = true;
            this.LbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbNameBook.Location = new System.Drawing.Point(658, 86);
            this.LbNameBook.Name = "LbNameBook";
            this.LbNameBook.Size = new System.Drawing.Size(20, 25);
            this.LbNameBook.TabIndex = 0;
            this.LbNameBook.Text = "*";
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(719, 14);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(119, 37);
            this.BtExit.TabIndex = 9;
            this.BtExit.Text = "Закрыть";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // Givebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.label2);
            this.Name = "Givebook";
            this.Text = "Выдача книги";
            this.Load += new System.EventHandler(this.Givebook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCopyBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbNumberReaders;
        private System.Windows.Forms.Label LbFIO;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.Label LbGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbNumberBook;
        private System.Windows.Forms.Label LbAutorBook;
        private System.Windows.Forms.Label LbFolmularBook;
        private System.Windows.Forms.Label LbNameBook;
        private System.Windows.Forms.Button BtExit;
    }
}