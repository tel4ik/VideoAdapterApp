
namespace VideoAdapterApp.View
{
    partial class MainView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видеокартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВидеокартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюВидеокартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКСравнениюВидеокартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полныйСписокВидеокартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКартДляСравненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(360, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 52;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(945, 563);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Видеокарты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видеокартыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видеокартыToolStripMenuItem
            // 
            this.видеокартыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВидеокартыToolStripMenuItem,
            this.удалитьВыбраннуюВидеокартуToolStripMenuItem,
            this.добавитьКСравнениюВидеокартуToolStripMenuItem,
            this.полныйСписокВидеокартToolStripMenuItem,
            this.списокКартДляСравненияToolStripMenuItem});
            this.видеокартыToolStripMenuItem.Name = "видеокартыToolStripMenuItem";
            this.видеокартыToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.видеокартыToolStripMenuItem.Text = "Видеокарты";
            // 
            // добавитьВидеокартыToolStripMenuItem
            // 
            this.добавитьВидеокартыToolStripMenuItem.Name = "добавитьВидеокартыToolStripMenuItem";
            this.добавитьВидеокартыToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.добавитьВидеокартыToolStripMenuItem.Text = "Добавить видеокарту";
            // 
            // удалитьВыбраннуюВидеокартуToolStripMenuItem
            // 
            this.удалитьВыбраннуюВидеокартуToolStripMenuItem.Name = "удалитьВыбраннуюВидеокартуToolStripMenuItem";
            this.удалитьВыбраннуюВидеокартуToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.удалитьВыбраннуюВидеокартуToolStripMenuItem.Text = "Удалить выбранную видеокарту";
            // 
            // добавитьКСравнениюВидеокартуToolStripMenuItem
            // 
            this.добавитьКСравнениюВидеокартуToolStripMenuItem.Name = "добавитьКСравнениюВидеокартуToolStripMenuItem";
            this.добавитьКСравнениюВидеокартуToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.добавитьКСравнениюВидеокартуToolStripMenuItem.Text = "Добавить к сравнению видеокарту";
            // 
            // полныйСписокВидеокартToolStripMenuItem
            // 
            this.полныйСписокВидеокартToolStripMenuItem.Name = "полныйСписокВидеокартToolStripMenuItem";
            this.полныйСписокВидеокартToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.полныйСписокВидеокартToolStripMenuItem.Text = "Полный список видеокарт";
            // 
            // списокКартДляСравненияToolStripMenuItem
            // 
            this.списокКартДляСравненияToolStripMenuItem.Name = "списокКартДляСравненияToolStripMenuItem";
            this.списокКартДляСравненияToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.списокКартДляСравненияToolStripMenuItem.Text = "Список карт для сравнения";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(78, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 404);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить к списку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "Сравнение видеокарт в файле";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 593);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видеокартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВидеокартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюВидеокартуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКСравнениюВидеокартуToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem полныйСписокВидеокартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКартДляСравненияToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}