
namespace BinaryTree
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTree = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBypass = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обработкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьОбходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметричныйМетодLNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямойМетодNLRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратныйМетодLRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методСправаналевоRNLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обходВШиринуBFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTree);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дерево";
            // 
            // textBoxTree
            // 
            this.textBoxTree.Location = new System.Drawing.Point(6, 19);
            this.textBoxTree.Multiline = true;
            this.textBoxTree.Name = "textBoxTree";
            this.textBoxTree.Size = new System.Drawing.Size(343, 356);
            this.textBoxTree.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBypass);
            this.groupBox2.Location = new System.Drawing.Point(374, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обходы";
            // 
            // textBoxBypass
            // 
            this.textBoxBypass.Location = new System.Drawing.Point(6, 19);
            this.textBoxBypass.Multiline = true;
            this.textBoxBypass.Name = "textBoxBypass";
            this.textBoxBypass.Size = new System.Drawing.Size(372, 155);
            this.textBoxBypass.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 61);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(372, 128);
            this.textBoxSearch.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обработкаДанныхToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обработкаДанныхToolStripMenuItem
            // 
            this.обработкаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.выполнитьОбходToolStripMenuItem});
            this.обработкаДанныхToolStripMenuItem.Name = "обработкаДанныхToolStripMenuItem";
            this.обработкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.обработкаДанныхToolStripMenuItem.Text = "Обработка данных";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеToolStripMenuItem_Click);
            // 
            // выполнитьОбходToolStripMenuItem
            // 
            this.выполнитьОбходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.симметричныйМетодLNRToolStripMenuItem,
            this.прямойМетодNLRToolStripMenuItem,
            this.обратныйМетодLRNToolStripMenuItem,
            this.методСправаналевоRNLToolStripMenuItem,
            this.обходВШиринуBFSToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.выполнитьОбходToolStripMenuItem.Name = "выполнитьОбходToolStripMenuItem";
            this.выполнитьОбходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выполнитьОбходToolStripMenuItem.Text = "Выполнить обход";
            // 
            // симметричныйМетодLNRToolStripMenuItem
            // 
            this.симметричныйМетодLNRToolStripMenuItem.Name = "симметричныйМетодLNRToolStripMenuItem";
            this.симметричныйМетодLNRToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.симметричныйМетодLNRToolStripMenuItem.Text = "Симметричный метод - LNR";
            this.симметричныйМетодLNRToolStripMenuItem.Click += new System.EventHandler(this.симметричныйМетодLNRToolStripMenuItem_Click);
            // 
            // прямойМетодNLRToolStripMenuItem
            // 
            this.прямойМетодNLRToolStripMenuItem.Name = "прямойМетодNLRToolStripMenuItem";
            this.прямойМетодNLRToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.прямойМетодNLRToolStripMenuItem.Text = "Прямой метод - NLR";
            this.прямойМетодNLRToolStripMenuItem.Click += new System.EventHandler(this.прямойМетодNLRToolStripMenuItem_Click);
            // 
            // обратныйМетодLRNToolStripMenuItem
            // 
            this.обратныйМетодLRNToolStripMenuItem.Name = "обратныйМетодLRNToolStripMenuItem";
            this.обратныйМетодLRNToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.обратныйМетодLRNToolStripMenuItem.Text = "Обратный метод - LRN";
            this.обратныйМетодLRNToolStripMenuItem.Click += new System.EventHandler(this.обратныйМетодLRNToolStripMenuItem_Click);
            // 
            // методСправаналевоRNLToolStripMenuItem
            // 
            this.методСправаналевоRNLToolStripMenuItem.Name = "методСправаналевоRNLToolStripMenuItem";
            this.методСправаналевоRNLToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.методСправаналевоRNLToolStripMenuItem.Text = "Метод справа-налево - RNL";
            this.методСправаналевоRNLToolStripMenuItem.Click += new System.EventHandler(this.методСправаналевоRNLToolStripMenuItem_Click);
            // 
            // обходВШиринуBFSToolStripMenuItem
            // 
            this.обходВШиринуBFSToolStripMenuItem.Name = "обходВШиринуBFSToolStripMenuItem";
            this.обходВШиринуBFSToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.обходВШиринуBFSToolStripMenuItem.Text = "Обход в ширину - BFS";
            this.обходВШиринуBFSToolStripMenuItem.Click += new System.EventHandler(this.обходВШиринуBFSToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.всеToolStripMenuItem.Text = "Все...";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(374, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск ключа";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(6, 19);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(269, 36);
            this.textBoxKey.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Бинарные деревья";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обработкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьОбходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметричныйМетодLNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямойМетодNLRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem обратныйМетодLRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методСправаналевоRNLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обходВШиринуBFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTree;
        private System.Windows.Forms.TextBox textBoxBypass;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}

