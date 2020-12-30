namespace ТП2020_2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet = new ТП2020_2.AnimalsDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.radioButton_nickname = new System.Windows.Forms.RadioButton();
            this.radioButton_type = new System.Windows.Forms.RadioButton();
            this.radioButton_age = new System.Windows.Forms.RadioButton();
            this.radioButton_weight = new System.Windows.Forms.RadioButton();
            this.radioButton_class = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // animalsDataSetBindingSource
            // 
            this.animalsDataSetBindingSource.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource.Position = 0;
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "AnimalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(73, 25);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(397, 20);
            this.textBox_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(485, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Найти";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(138, 388);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(252, 388);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(92, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Изменить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(368, 388);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(27, 388);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(89, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // radioButton_nickname
            // 
            this.radioButton_nickname.AutoSize = true;
            this.radioButton_nickname.Location = new System.Drawing.Point(31, 61);
            this.radioButton_nickname.Name = "radioButton_nickname";
            this.radioButton_nickname.Size = new System.Drawing.Size(73, 17);
            this.radioButton_nickname.TabIndex = 8;
            this.radioButton_nickname.TabStop = true;
            this.radioButton_nickname.Text = "Nickname";
            this.radioButton_nickname.UseVisualStyleBackColor = true;
            // 
            // radioButton_type
            // 
            this.radioButton_type.AutoSize = true;
            this.radioButton_type.Location = new System.Drawing.Point(110, 61);
            this.radioButton_type.Name = "radioButton_type";
            this.radioButton_type.Size = new System.Drawing.Size(49, 17);
            this.radioButton_type.TabIndex = 9;
            this.radioButton_type.TabStop = true;
            this.radioButton_type.Text = "Type";
            this.radioButton_type.UseVisualStyleBackColor = true;
            // 
            // radioButton_age
            // 
            this.radioButton_age.AutoSize = true;
            this.radioButton_age.Location = new System.Drawing.Point(165, 61);
            this.radioButton_age.Name = "radioButton_age";
            this.radioButton_age.Size = new System.Drawing.Size(44, 17);
            this.radioButton_age.TabIndex = 10;
            this.radioButton_age.TabStop = true;
            this.radioButton_age.Text = "Age";
            this.radioButton_age.UseVisualStyleBackColor = true;
            // 
            // radioButton_weight
            // 
            this.radioButton_weight.AutoSize = true;
            this.radioButton_weight.Location = new System.Drawing.Point(215, 61);
            this.radioButton_weight.Name = "radioButton_weight";
            this.radioButton_weight.Size = new System.Drawing.Size(59, 17);
            this.radioButton_weight.TabIndex = 11;
            this.radioButton_weight.TabStop = true;
            this.radioButton_weight.Text = "Weight";
            this.radioButton_weight.UseVisualStyleBackColor = true;
            // 
            // radioButton_class
            // 
            this.radioButton_class.AutoSize = true;
            this.radioButton_class.Location = new System.Drawing.Point(280, 61);
            this.radioButton_class.Name = "radioButton_class";
            this.radioButton_class.Size = new System.Drawing.Size(50, 17);
            this.radioButton_class.TabIndex = 12;
            this.radioButton_class.TabStop = true;
            this.radioButton_class.Text = "Class";
            this.radioButton_class.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.radioButton_class);
            this.Controls.Add(this.radioButton_weight);
            this.Controls.Add(this.radioButton_age);
            this.Controls.Add(this.radioButton_type);
            this.Controls.Add(this.radioButton_nickname);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Зоопарк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource;
        private AnimalsDataSet animalsDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.RadioButton radioButton_nickname;
        private System.Windows.Forms.RadioButton radioButton_type;
        private System.Windows.Forms.RadioButton radioButton_age;
        private System.Windows.Forms.RadioButton radioButton_weight;
        private System.Windows.Forms.RadioButton radioButton_class;
    }
}

