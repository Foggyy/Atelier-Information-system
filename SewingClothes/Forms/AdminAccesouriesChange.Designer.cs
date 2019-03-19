namespace SewingClothes
{
    partial class AdminAccesouriesChange
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
            this.label6 = new System.Windows.Forms.Label();
            this.listViewAccessouries = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteAccessourie = new System.Windows.Forms.Button();
            this.buttonReturnAdmin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonAddAccessourie = new System.Windows.Forms.Button();
            this.labelImageLoaded = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Все аксессуары";
            // 
            // listViewAccessouries
            // 
            this.listViewAccessouries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAccessouries.FullRowSelect = true;
            this.listViewAccessouries.Location = new System.Drawing.Point(12, 223);
            this.listViewAccessouries.MultiSelect = false;
            this.listViewAccessouries.Name = "listViewAccessouries";
            this.listViewAccessouries.Size = new System.Drawing.Size(748, 241);
            this.listViewAccessouries.TabIndex = 19;
            this.listViewAccessouries.UseCompatibleStateImageBehavior = false;
            this.listViewAccessouries.View = System.Windows.Forms.View.Details;
            this.listViewAccessouries.SelectedIndexChanged += new System.EventHandler(this.listViewAccessouries_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Изображение";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Положение";
            this.columnHeader3.Width = 173;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость";
            this.columnHeader4.Width = 145;
            // 
            // buttonDeleteAccessourie
            // 
            this.buttonDeleteAccessourie.Location = new System.Drawing.Point(595, 480);
            this.buttonDeleteAccessourie.Name = "buttonDeleteAccessourie";
            this.buttonDeleteAccessourie.Size = new System.Drawing.Size(106, 66);
            this.buttonDeleteAccessourie.TabIndex = 30;
            this.buttonDeleteAccessourie.Text = "Удалить выбранный аксессуар";
            this.buttonDeleteAccessourie.UseVisualStyleBackColor = true;
            this.buttonDeleteAccessourie.Click += new System.EventHandler(this.buttonDeleteAccessourie_Click);
            // 
            // buttonReturnAdmin
            // 
            this.buttonReturnAdmin.Location = new System.Drawing.Point(12, 498);
            this.buttonReturnAdmin.Name = "buttonReturnAdmin";
            this.buttonReturnAdmin.Size = new System.Drawing.Size(106, 48);
            this.buttonReturnAdmin.TabIndex = 31;
            this.buttonReturnAdmin.Text = "Вернуться назад";
            this.buttonReturnAdmin.UseVisualStyleBackColor = true;
            this.buttonReturnAdmin.Click += new System.EventHandler(this.buttonReturnAdmin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Цена за единицу";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(203, 145);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(138, 22);
            this.textBoxCost.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Количество";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(203, 74);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(138, 22);
            this.textBoxAmount.TabIndex = 40;
            // 
            // buttonAddAccessourie
            // 
            this.buttonAddAccessourie.Location = new System.Drawing.Point(700, 101);
            this.buttonAddAccessourie.Name = "buttonAddAccessourie";
            this.buttonAddAccessourie.Size = new System.Drawing.Size(154, 66);
            this.buttonAddAccessourie.TabIndex = 39;
            this.buttonAddAccessourie.Text = "Добавить/Изменить аксессуар";
            this.buttonAddAccessourie.UseVisualStyleBackColor = true;
            this.buttonAddAccessourie.Click += new System.EventHandler(this.buttonAddAccessourie_Click);
            // 
            // labelImageLoaded
            // 
            this.labelImageLoaded.AutoSize = true;
            this.labelImageLoaded.Location = new System.Drawing.Point(409, 79);
            this.labelImageLoaded.Name = "labelImageLoaded";
            this.labelImageLoaded.Size = new System.Drawing.Size(190, 17);
            this.labelImageLoaded.TabIndex = 38;
            this.labelImageLoaded.Text = "Изображение не загружено";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(412, 119);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(111, 48);
            this.buttonLoadImage.TabIndex = 37;
            this.buttonLoadImage.Text = "Загрузка изображения";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(17, 145);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(138, 22);
            this.textBoxPosition.TabIndex = 36;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(20, 74);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(138, 22);
            this.textBoxType.TabIndex = 35;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(14, 108);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(83, 17);
            this.labelPosition.TabIndex = 34;
            this.labelPosition.Text = "Положение";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(17, 42);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(33, 17);
            this.labelType.TabIndex = 33;
            this.labelType.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Добавление/Изменение аксессуара";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Количество";
            this.columnHeader5.Width = 138;
            // 
            // AdminAccesouriesChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1116, 558);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonAddAccessourie);
            this.Controls.Add(this.labelImageLoaded);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReturnAdmin);
            this.Controls.Add(this.buttonDeleteAccessourie);
            this.Controls.Add(this.listViewAccessouries);
            this.Controls.Add(this.label6);
            this.Name = "AdminAccesouriesChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение списка аксессуаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAccesouriesChange_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewAccessouries;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonDeleteAccessourie;
        private System.Windows.Forms.Button buttonReturnAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonAddAccessourie;
        private System.Windows.Forms.Label labelImageLoaded;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}