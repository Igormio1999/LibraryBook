namespace Kulakov.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзУчетнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прокатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПрокатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продлитьВыдачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияФормуляраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПолныйСписокФормуляровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСписокАктивныхПрокатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьНовуюКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДоступныхЭкземпляровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехЭкземпляровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.издательствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поПоступлениюКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаToolStripMenuItem,
            this.прокатToolStripMenuItem,
            this.читательToolStripMenuItem,
            this.книгиToolStripMenuItem1,
            this.отчетыToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзУчетнойЗаписиToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.системаToolStripMenuItem.Text = "Система";
            // 
            // выйтиИзУчетнойЗаписиToolStripMenuItem
            // 
            this.выйтиИзУчетнойЗаписиToolStripMenuItem.Name = "выйтиИзУчетнойЗаписиToolStripMenuItem";
            this.выйтиИзУчетнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.выйтиИзУчетнойЗаписиToolStripMenuItem.Text = "Выход из учетной записи";
            this.выйтиИзУчетнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзУчетнойЗаписиToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.выйтиToolStripMenuItem.Text = "Закрыть программу";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // прокатToolStripMenuItem
            // 
            this.прокатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПрокатToolStripMenuItem,
            this.продлитьВыдачуToolStripMenuItem,
            this.возвратКнигиToolStripMenuItem});
            this.прокатToolStripMenuItem.Name = "прокатToolStripMenuItem";
            this.прокатToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.прокатToolStripMenuItem.Text = "Операции";
            // 
            // новыйПрокатToolStripMenuItem
            // 
            this.новыйПрокатToolStripMenuItem.Name = "новыйПрокатToolStripMenuItem";
            this.новыйПрокатToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.новыйПрокатToolStripMenuItem.Text = "Выдача книги";
            this.новыйПрокатToolStripMenuItem.Click += new System.EventHandler(this.новыйПрокатToolStripMenuItem_Click);
            // 
            // продлитьВыдачуToolStripMenuItem
            // 
            this.продлитьВыдачуToolStripMenuItem.Name = "продлитьВыдачуToolStripMenuItem";
            this.продлитьВыдачуToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.продлитьВыдачуToolStripMenuItem.Text = "Продлить выдачу";
            this.продлитьВыдачуToolStripMenuItem.Click += new System.EventHandler(this.продлитьВыдачуToolStripMenuItem_Click);
            // 
            // возвратКнигиToolStripMenuItem
            // 
            this.возвратКнигиToolStripMenuItem.Name = "возвратКнигиToolStripMenuItem";
            this.возвратКнигиToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.возвратКнигиToolStripMenuItem.Text = "Возврат книги ";
            this.возвратКнигиToolStripMenuItem.Click += new System.EventHandler(this.возвратКнигиToolStripMenuItem_Click);
            // 
            // читательToolStripMenuItem
            // 
            this.читательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияФормуляраToolStripMenuItem,
            this.открытьПолныйСписокФормуляровToolStripMenuItem,
            this.открытьСписокАктивныхПрокатовToolStripMenuItem});
            this.читательToolStripMenuItem.Name = "читательToolStripMenuItem";
            this.читательToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.читательToolStripMenuItem.Text = "Читатель";
            // 
            // регистрацияФормуляраToolStripMenuItem
            // 
            this.регистрацияФормуляраToolStripMenuItem.Name = "регистрацияФормуляраToolStripMenuItem";
            this.регистрацияФормуляраToolStripMenuItem.Size = new System.Drawing.Size(389, 32);
            this.регистрацияФормуляраToolStripMenuItem.Text = "Создать новый формуляр";
            this.регистрацияФормуляраToolStripMenuItem.Click += new System.EventHandler(this.регистрацияФормуляраToolStripMenuItem_Click);
            // 
            // открытьПолныйСписокФормуляровToolStripMenuItem
            // 
            this.открытьПолныйСписокФормуляровToolStripMenuItem.Name = "открытьПолныйСписокФормуляровToolStripMenuItem";
            this.открытьПолныйСписокФормуляровToolStripMenuItem.Size = new System.Drawing.Size(389, 32);
            this.открытьПолныйСписокФормуляровToolStripMenuItem.Text = "Открыть список формуляров";
            this.открытьПолныйСписокФормуляровToolStripMenuItem.Click += new System.EventHandler(this.открытьПолныйСписокФормуляровToolStripMenuItem_Click);
            // 
            // открытьСписокАктивныхПрокатовToolStripMenuItem
            // 
            this.открытьСписокАктивныхПрокатовToolStripMenuItem.Name = "открытьСписокАктивныхПрокатовToolStripMenuItem";
            this.открытьСписокАктивныхПрокатовToolStripMenuItem.Size = new System.Drawing.Size(402, 32);
            this.открытьСписокАктивныхПрокатовToolStripMenuItem.Text = "Открыть список выданных книг *";
            this.открытьСписокАктивныхПрокатовToolStripMenuItem.Click += new System.EventHandler(this.открытьСписокАктивныхПрокатовToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem1
            // 
            this.книгиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарегистрироватьНовуюКнигуToolStripMenuItem,
            this.просмотрДоступныхЭкземпляровToolStripMenuItem,
            this.просмотрВсехЭкземпляровToolStripMenuItem,
            this.справочникиToolStripMenuItem1});
            this.книгиToolStripMenuItem1.Name = "книгиToolStripMenuItem1";
            this.книгиToolStripMenuItem1.Size = new System.Drawing.Size(82, 32);
            this.книгиToolStripMenuItem1.Text = "Книги";
            // 
            // зарегистрироватьНовуюКнигуToolStripMenuItem
            // 
            this.зарегистрироватьНовуюКнигуToolStripMenuItem.Name = "зарегистрироватьНовуюКнигуToolStripMenuItem";
            this.зарегистрироватьНовуюКнигуToolStripMenuItem.Size = new System.Drawing.Size(418, 32);
            this.зарегистрироватьНовуюКнигуToolStripMenuItem.Text = "Зарегистрировать новую книгу";
            this.зарегистрироватьНовуюКнигуToolStripMenuItem.Click += new System.EventHandler(this.зарегистрироватьНовуюКнигуToolStripMenuItem_Click);
            // 
            // просмотрДоступныхЭкземпляровToolStripMenuItem
            // 
            this.просмотрДоступныхЭкземпляровToolStripMenuItem.Name = "просмотрДоступныхЭкземпляровToolStripMenuItem";
            this.просмотрДоступныхЭкземпляровToolStripMenuItem.Size = new System.Drawing.Size(418, 32);
            this.просмотрДоступныхЭкземпляровToolStripMenuItem.Text = "Просмотр доступных экземпляров";
            this.просмотрДоступныхЭкземпляровToolStripMenuItem.Click += new System.EventHandler(this.просмотрДоступныхЭкземпляровToolStripMenuItem_Click);
            // 
            // просмотрВсехЭкземпляровToolStripMenuItem
            // 
            this.просмотрВсехЭкземпляровToolStripMenuItem.Name = "просмотрВсехЭкземпляровToolStripMenuItem";
            this.просмотрВсехЭкземпляровToolStripMenuItem.Size = new System.Drawing.Size(418, 32);
            this.просмотрВсехЭкземпляровToolStripMenuItem.Text = "Просмотр всех экземпляров";
            this.просмотрВсехЭкземпляровToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехЭкземпляровToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem1
            // 
            this.справочникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem1,
            this.жанрToolStripMenuItem1,
            this.издательствоToolStripMenuItem});
            this.справочникиToolStripMenuItem1.Name = "справочникиToolStripMenuItem1";
            this.справочникиToolStripMenuItem1.Size = new System.Drawing.Size(418, 32);
            this.справочникиToolStripMenuItem1.Text = "Справочники";
            // 
            // авторToolStripMenuItem1
            // 
            this.авторToolStripMenuItem1.Name = "авторToolStripMenuItem1";
            this.авторToolStripMenuItem1.Size = new System.Drawing.Size(222, 32);
            this.авторToolStripMenuItem1.Text = "Автор";
            this.авторToolStripMenuItem1.Click += new System.EventHandler(this.авторToolStripMenuItem1_Click);
            // 
            // жанрToolStripMenuItem1
            // 
            this.жанрToolStripMenuItem1.Name = "жанрToolStripMenuItem1";
            this.жанрToolStripMenuItem1.Size = new System.Drawing.Size(222, 32);
            this.жанрToolStripMenuItem1.Text = "Жанр";
            this.жанрToolStripMenuItem1.Click += new System.EventHandler(this.жанрToolStripMenuItem1_Click);
            // 
            // издательствоToolStripMenuItem
            // 
            this.издательствоToolStripMenuItem.Name = "издательствоToolStripMenuItem";
            this.издательствоToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.издательствоToolStripMenuItem.Text = "Издательство";
            this.издательствоToolStripMenuItem.Click += new System.EventHandler(this.издательствоToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem1
            // 
            this.отчетыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПоступлениюКнигToolStripMenuItem});
            this.отчетыToolStripMenuItem1.Name = "отчетыToolStripMenuItem1";
            this.отчетыToolStripMenuItem1.Size = new System.Drawing.Size(92, 32);
            this.отчетыToolStripMenuItem1.Text = "Отчеты";
            // 
            // поПоступлениюКнигToolStripMenuItem
            // 
            this.поПоступлениюКнигToolStripMenuItem.Name = "поПоступлениюКнигToolStripMenuItem";
            this.поПоступлениюКнигToolStripMenuItem.Size = new System.Drawing.Size(300, 32);
            this.поПоступлениюКнигToolStripMenuItem.Text = "По поступлению книг";
            this.поПоступлениюКнигToolStripMenuItem.Click += new System.EventHandler(this.поПоступлениюКнигToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 580);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(904, 627);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочий стол";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзУчетнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияФормуляраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПолныйСписокФормуляровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьНовуюКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДоступныхЭкземпляровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехЭкземпляровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прокатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПрокатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продлитьВыдачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возвратКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поПоступлениюКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem жанрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem издательствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСписокАктивныхПрокатовToolStripMenuItem;
    }
}