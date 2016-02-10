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
            this.tabControl_db = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_loger = new System.Windows.Forms.TextBox();
            this.button_parse = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_cat = new System.Windows.Forms.Label();
            this.label_loc = new System.Windows.Forms.Label();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.comboBox_subCat = new System.Windows.Forms.ComboBox();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.comboBox_subLoc = new System.Windows.Forms.ComboBox();
            this.tabControl_db.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_db
            // 
            this.tabControl_db.Controls.Add(this.tabPage1);
            this.tabControl_db.Controls.Add(this.tabPage2);
            this.tabControl_db.Location = new System.Drawing.Point(1, 12);
            this.tabControl_db.Name = "tabControl_db";
            this.tabControl_db.SelectedIndex = 0;
            this.tabControl_db.Size = new System.Drawing.Size(1183, 544);
            this.tabControl_db.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1175, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "База данных";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1169, 512);
            this.dataGridView1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_loger);
            this.tabPage2.Controls.Add(this.button_parse);
            this.tabPage2.Controls.Add(this.button_refresh);
            this.tabPage2.Controls.Add(this.label_cat);
            this.tabPage2.Controls.Add(this.label_loc);
            this.tabPage2.Controls.Add(this.comboBox_cat);
            this.tabPage2.Controls.Add(this.comboBox_subCat);
            this.tabPage2.Controls.Add(this.comboBox_loc);
            this.tabPage2.Controls.Add(this.comboBox_subLoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1175, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Парсинг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_loger
            // 
            this.textBox_loger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_loger.Location = new System.Drawing.Point(7, 118);
            this.textBox_loger.Multiline = true;
            this.textBox_loger.Name = "textBox_loger";
            this.textBox_loger.Size = new System.Drawing.Size(611, 394);
            this.textBox_loger.TabIndex = 9;
            // 
            // button_parse
            // 
            this.button_parse.Location = new System.Drawing.Point(641, 23);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(74, 49);
            this.button_parse.TabIndex = 8;
            this.button_parse.Text = "Парсить";
            this.button_parse.UseVisualStyleBackColor = true;
            this.button_parse.Click += new System.EventHandler(this.button_parse_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(733, 23);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(74, 49);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить таблицу";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_cat
            // 
            this.label_cat.AutoSize = true;
            this.label_cat.Location = new System.Drawing.Point(220, 19);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(48, 13);
            this.label_cat.TabIndex = 7;
            this.label_cat.Text = "Каталог";
            // 
            // label_loc
            // 
            this.label_loc.AutoSize = true;
            this.label_loc.Location = new System.Drawing.Point(18, 19);
            this.label_loc.Name = "label_loc";
            this.label_loc.Size = new System.Drawing.Size(67, 13);
            this.label_loc.TabIndex = 6;
            this.label_loc.Text = "Территория";
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(220, 38);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_cat.TabIndex = 3;
            this.comboBox_cat.TextChanged += new System.EventHandler(this.comboBox_cat_TextChanged);
            // 
            // comboBox_subCat
            // 
            this.comboBox_subCat.FormattingEnabled = true;
            this.comboBox_subCat.Location = new System.Drawing.Point(220, 66);
            this.comboBox_subCat.Name = "comboBox_subCat";
            this.comboBox_subCat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_subCat.TabIndex = 4;
            this.comboBox_subCat.TextChanged += new System.EventHandler(this.comboBox_subCat_TextChanged);
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(17, 38);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(151, 21);
            this.comboBox_loc.TabIndex = 1;
            this.comboBox_loc.TextChanged += new System.EventHandler(this.comboBox_loc_TextChanged);
            // 
            // comboBox_subLoc
            // 
            this.comboBox_subLoc.FormattingEnabled = true;
            this.comboBox_subLoc.Location = new System.Drawing.Point(17, 66);
            this.comboBox_subLoc.Name = "comboBox_subLoc";
            this.comboBox_subLoc.Size = new System.Drawing.Size(151, 21);
            this.comboBox_subLoc.TabIndex = 2;
            this.comboBox_subLoc.TextChanged += new System.EventHandler(this.comboBox_subLoc_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tabControl_db);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl_db.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_db;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.ComboBox comboBox_subLoc;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.ComboBox comboBox_subCat;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_loc;
        private System.Windows.Forms.Label label_cat;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}