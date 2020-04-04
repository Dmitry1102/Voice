namespace Lab_2_OOTP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxDriveName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCost,
            this.ColumnCity,
            this.ColumnEngine});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(351, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(381, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(206, 47);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить Транспортное Средство";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(381, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(206, 52);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить Транспортное Средство";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(381, 67);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(206, 47);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить Данные";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(51, 180);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(115, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Text = "ffkjkfg";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(51, 219);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(115, 20);
            this.textBoxCost.TabIndex = 10;
            this.textBoxCost.Text = "445";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Двигатель:";
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Location = new System.Drawing.Point(52, 258);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(115, 20);
            this.textBoxEngine.TabIndex = 14;
            this.textBoxEngine.Text = "jkfkgkh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Завод Изготовитель:";
            // 
            // textBoxFact
            // 
            this.textBoxFact.Location = new System.Drawing.Point(230, 219);
            this.textBoxFact.Name = "textBoxFact";
            this.textBoxFact.Size = new System.Drawing.Size(115, 20);
            this.textBoxFact.TabIndex = 18;
            this.textBoxFact.Text = "kjhhlhl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Город:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(230, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(115, 20);
            this.textBoxCity.TabIndex = 16;
            this.textBoxCity.Text = ",,nhhl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Имя Водителя:";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(49, 322);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(0, 13);
            this.labelFirst.TabIndex = 25;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Не уточнено",
            "Наземный Транспорт",
            "Водный Транпорт",
            "Воздушный Транспорт",
            "Рабочий Транспорт"});
            this.comboBoxType.Location = new System.Drawing.Point(51, 298);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(148, 21);
            this.comboBoxType.TabIndex = 28;
            this.comboBoxType.Tag = "";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfession_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Тип Транспортного средства:";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Items.AddRange(new object[] {
            "Выберите здание."});
            this.listBoxInfo.Location = new System.Drawing.Point(381, 258);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(207, 147);
            this.listBoxInfo.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "1233";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(229, 363);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 31);
            this.buttonClear.TabIndex = 32;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxDriveName
            // 
            this.textBoxDriveName.Location = new System.Drawing.Point(230, 258);
            this.textBoxDriveName.Name = "textBoxDriveName";
            this.textBoxDriveName.Size = new System.Drawing.Size(115, 20);
            this.textBoxDriveName.TabIndex = 20;
            this.textBoxDriveName.Text = "jgklklgh";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(230, 298);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(115, 20);
            this.textBoxSurname.TabIndex = 33;
            this.textBoxSurname.Text = "yjyuto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Фамилия Водителя:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(230, 337);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(115, 20);
            this.textBoxCategory.TabIndex = 35;
            this.textBoxCategory.Text = "iyoyu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Категория:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "54656";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(49, 358);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(0, 13);
            this.labelSecond.TabIndex = 38;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Цена";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // ColumnCity
            // 
            this.ColumnCity.HeaderText = "Город";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            // 
            // ColumnEngine
            // 
            this.ColumnEngine.HeaderText = "Двигатель";
            this.ColumnEngine.Name = "ColumnEngine";
            this.ColumnEngine.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 460);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDriveName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Transport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxDriveName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEngine;
    }
}

