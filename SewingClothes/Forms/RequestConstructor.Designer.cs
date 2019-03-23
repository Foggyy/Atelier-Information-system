namespace SewingClothes
{
    partial class RequestConstructor
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
            this.buttonAddTables = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonAddFields = new System.Windows.Forms.Button();
            this.checkedListBoxTables = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxFields = new System.Windows.Forms.CheckedListBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.dataGridViewConditions = new System.Windows.Forms.DataGridView();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predicate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonSaveValues = new System.Windows.Forms.Button();
            this.buttonLaunchQuery = new System.Windows.Forms.Button();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список таблиц";
            // 
            // buttonAddTables
            // 
            this.buttonAddTables.Location = new System.Drawing.Point(194, 134);
            this.buttonAddTables.Name = "buttonAddTables";
            this.buttonAddTables.Size = new System.Drawing.Size(159, 52);
            this.buttonAddTables.TabIndex = 3;
            this.buttonAddTables.Text = "Добавить";
            this.buttonAddTables.UseVisualStyleBackColor = true;
            this.buttonAddTables.Click += new System.EventHandler(this.buttonAddTables_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите таблицу";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(407, 46);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(159, 24);
            this.comboBoxTables.TabIndex = 6;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // buttonAddFields
            // 
            this.buttonAddFields.Location = new System.Drawing.Point(407, 76);
            this.buttonAddFields.Name = "buttonAddFields";
            this.buttonAddFields.Size = new System.Drawing.Size(159, 52);
            this.buttonAddFields.TabIndex = 7;
            this.buttonAddFields.Text = "Добавить";
            this.buttonAddFields.UseVisualStyleBackColor = true;
            this.buttonAddFields.Click += new System.EventHandler(this.buttonAddFields_Click);
            // 
            // checkedListBoxTables
            // 
            this.checkedListBoxTables.FormattingEnabled = true;
            this.checkedListBoxTables.Location = new System.Drawing.Point(15, 46);
            this.checkedListBoxTables.Name = "checkedListBoxTables";
            this.checkedListBoxTables.Size = new System.Drawing.Size(173, 140);
            this.checkedListBoxTables.TabIndex = 11;
            // 
            // checkedListBoxFields
            // 
            this.checkedListBoxFields.FormattingEnabled = true;
            this.checkedListBoxFields.Location = new System.Drawing.Point(590, 46);
            this.checkedListBoxFields.Name = "checkedListBoxFields";
            this.checkedListBoxFields.Size = new System.Drawing.Size(173, 140);
            this.checkedListBoxFields.TabIndex = 12;
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(407, 134);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(159, 52);
            this.buttonClearList.TabIndex = 13;
            this.buttonClearList.Text = "Очистить список выбранных полей";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // dataGridViewConditions
            // 
            this.dataGridViewConditions.AllowUserToAddRows = false;
            this.dataGridViewConditions.AllowUserToDeleteRows = false;
            this.dataGridViewConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Field,
            this.Condition,
            this.Value,
            this.Predicate});
            this.dataGridViewConditions.Location = new System.Drawing.Point(843, 46);
            this.dataGridViewConditions.Name = "dataGridViewConditions";
            this.dataGridViewConditions.RowTemplate.Height = 24;
            this.dataGridViewConditions.Size = new System.Drawing.Size(482, 140);
            this.dataGridViewConditions.TabIndex = 15;
            // 
            // Field
            // 
            this.Field.HeaderText = "Поле";
            this.Field.Name = "Field";
            this.Field.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Условие";
            this.Condition.Items.AddRange(new object[] {
            "=",
            "!=",
            ">",
            "<",
            ">=",
            "<="});
            this.Condition.Name = "Condition";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // Predicate
            // 
            this.Predicate.HeaderText = "Предикат";
            this.Predicate.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.Predicate.Name = "Predicate";
            // 
            // buttonSaveValues
            // 
            this.buttonSaveValues.Location = new System.Drawing.Point(1205, 192);
            this.buttonSaveValues.Name = "buttonSaveValues";
            this.buttonSaveValues.Size = new System.Drawing.Size(120, 63);
            this.buttonSaveValues.TabIndex = 16;
            this.buttonSaveValues.Text = "Сохранить изменения";
            this.buttonSaveValues.UseVisualStyleBackColor = true;
            this.buttonSaveValues.Click += new System.EventHandler(this.buttonSaveValues_Click);
            // 
            // buttonLaunchQuery
            // 
            this.buttonLaunchQuery.Location = new System.Drawing.Point(1205, 397);
            this.buttonLaunchQuery.Name = "buttonLaunchQuery";
            this.buttonLaunchQuery.Size = new System.Drawing.Size(120, 63);
            this.buttonLaunchQuery.TabIndex = 17;
            this.buttonLaunchQuery.Text = "Выполнить запрос";
            this.buttonLaunchQuery.UseVisualStyleBackColor = true;
            this.buttonLaunchQuery.Click += new System.EventHandler(this.buttonLaunchQuery_Click);
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(165, 317);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowTemplate.Height = 24;
            this.dataGridViewRequest.Size = new System.Drawing.Size(1024, 231);
            this.dataGridViewRequest.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поля таблицы:";
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Location = new System.Drawing.Point(12, 460);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(134, 88);
            this.buttonReturnToMenu.TabIndex = 21;
            this.buttonReturnToMenu.Text = "Вернуться в меню администратора";
            this.buttonReturnToMenu.UseVisualStyleBackColor = true;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // RequestConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 560);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.buttonLaunchQuery);
            this.Controls.Add(this.buttonSaveValues);
            this.Controls.Add(this.dataGridViewConditions);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.checkedListBoxFields);
            this.Controls.Add(this.checkedListBoxTables);
            this.Controls.Add(this.buttonAddFields);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddTables);
            this.Controls.Add(this.label1);
            this.Name = "RequestConstructor";
            this.Text = "Конструктор запросов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestConstructor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonAddFields;
        private System.Windows.Forms.CheckedListBox checkedListBoxTables;
        private System.Windows.Forms.CheckedListBox checkedListBoxFields;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.DataGridView dataGridViewConditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewComboBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewComboBoxColumn Predicate;
        private System.Windows.Forms.Button buttonSaveValues;
        private System.Windows.Forms.Button buttonLaunchQuery;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReturnToMenu;
    }
}