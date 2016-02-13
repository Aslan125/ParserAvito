namespace ParserAvito
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_loger = new System.Windows.Forms.TextBox();
            this.button_parse = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_cat = new System.Windows.Forms.Label();
            this.label_loc = new System.Windows.Forms.Label();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.comboBox_subCat = new System.Windows.Forms.ComboBox();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.comboBox_subLoc = new System.Windows.Forms.ComboBox();
            this.button_cleanDb = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.saveFileDialog_export = new System.Windows.Forms.SaveFileDialog();
            this.numderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_sysLogs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numderDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.publicDateDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articlesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1178, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_loger
            // 
            this.textBox_loger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_loger.Location = new System.Drawing.Point(532, 25);
            this.textBox_loger.Multiline = true;
            this.textBox_loger.Name = "textBox_loger";
            this.textBox_loger.Size = new System.Drawing.Size(648, 137);
            this.textBox_loger.TabIndex = 9;
            // 
            // button_parse
            // 
            this.button_parse.Location = new System.Drawing.Point(371, 25);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(129, 49);
            this.button_parse.TabIndex = 8;
            this.button_parse.Text = "Парсить";
            this.button_parse.UseVisualStyleBackColor = true;
            this.button_parse.Click += new System.EventHandler(this.button_parse_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(12, 93);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(129, 49);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить таблицу";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_cat
            // 
            this.label_cat.AutoSize = true;
            this.label_cat.Location = new System.Drawing.Point(215, 6);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(48, 13);
            this.label_cat.TabIndex = 7;
            this.label_cat.Text = "Каталог";
            // 
            // label_loc
            // 
            this.label_loc.AutoSize = true;
            this.label_loc.Location = new System.Drawing.Point(13, 6);
            this.label_loc.Name = "label_loc";
            this.label_loc.Size = new System.Drawing.Size(67, 13);
            this.label_loc.TabIndex = 6;
            this.label_loc.Text = "Территория";
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(215, 25);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_cat.TabIndex = 3;
            this.comboBox_cat.TextChanged += new System.EventHandler(this.comboBox_cat_TextChanged);
            // 
            // comboBox_subCat
            // 
            this.comboBox_subCat.FormattingEnabled = true;
            this.comboBox_subCat.Location = new System.Drawing.Point(215, 53);
            this.comboBox_subCat.Name = "comboBox_subCat";
            this.comboBox_subCat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_subCat.TabIndex = 4;
            this.comboBox_subCat.TextChanged += new System.EventHandler(this.comboBox_subCat_TextChanged);
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(12, 25);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(151, 21);
            this.comboBox_loc.TabIndex = 1;
            this.comboBox_loc.TextChanged += new System.EventHandler(this.comboBox_loc_TextChanged);
            // 
            // comboBox_subLoc
            // 
            this.comboBox_subLoc.FormattingEnabled = true;
            this.comboBox_subLoc.Location = new System.Drawing.Point(12, 53);
            this.comboBox_subLoc.Name = "comboBox_subLoc";
            this.comboBox_subLoc.Size = new System.Drawing.Size(151, 21);
            this.comboBox_subLoc.TabIndex = 2;
            this.comboBox_subLoc.TextChanged += new System.EventHandler(this.comboBox_subLoc_TextChanged);
            // 
            // button_cleanDb
            // 
            this.button_cleanDb.Location = new System.Drawing.Point(180, 93);
            this.button_cleanDb.Name = "button_cleanDb";
            this.button_cleanDb.Size = new System.Drawing.Size(124, 49);
            this.button_cleanDb.TabIndex = 10;
            this.button_cleanDb.Text = "Очистить базу";
            this.button_cleanDb.UseVisualStyleBackColor = true;
            this.button_cleanDb.Click += new System.EventHandler(this.button_cleanDb_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(371, 93);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(129, 49);
            this.button_export.TabIndex = 11;
            this.button_export.Text = "Экспорт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // saveFileDialog_export
            // 
            this.saveFileDialog_export.Filter = "\"Файл таблицы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // numderDataGridViewTextBoxColumn
            // 
            this.numderDataGridViewTextBoxColumn.DataPropertyName = "Numder";
            this.numderDataGridViewTextBoxColumn.HeaderText = "Numder";
            this.numderDataGridViewTextBoxColumn.Name = "numderDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.Visible = false;
            this.infoDataGridViewTextBoxColumn.Width = 530;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 85;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // publicDateDataGridViewTextBoxColumn
            // 
            this.publicDateDataGridViewTextBoxColumn.DataPropertyName = "PublicDate";
            this.publicDateDataGridViewTextBoxColumn.HeaderText = "PublicDate";
            this.publicDateDataGridViewTextBoxColumn.Name = "publicDateDataGridViewTextBoxColumn";
            this.publicDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Visible = false;
            this.urlDataGridViewTextBoxColumn.Width = 350;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataSource = typeof(ParserAvito.Articles);
            // 
            // label_sysLogs
            // 
            this.label_sysLogs.AutoSize = true;
            this.label_sysLogs.Location = new System.Drawing.Point(532, 5);
            this.label_sysLogs.Name = "label_sysLogs";
            this.label_sysLogs.Size = new System.Drawing.Size(91, 13);
            this.label_sysLogs.TabIndex = 12;
            this.label_sysLogs.Text = "Системные логи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label_sysLogs);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_cleanDb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_parse);
            this.Controls.Add(this.textBox_loger);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_cat);
            this.Controls.Add(this.comboBox_loc);
            this.Controls.Add(this.label_loc);
            this.Controls.Add(this.comboBox_subLoc);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.comboBox_subCat);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.ComboBox comboBox_subLoc;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.ComboBox comboBox_subCat;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_loc;
        private System.Windows.Forms.Label label_cat;
        private System.Windows.Forms.Button button_parse;
        private System.Windows.Forms.TextBox textBox_loger;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_cleanDb;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_export;
        private System.Windows.Forms.Label label_sysLogs;
    }
}