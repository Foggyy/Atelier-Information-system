namespace SewingClothes
{
    partial class Form3
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
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBreastSize = new System.Windows.Forms.TextBox();
            this.textBoxWaistSize = new System.Windows.Forms.TextBox();
            this.textBoxHipsSize = new System.Windows.Forms.TextBox();
            this.buttonSizeCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(12, 397);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(97, 60);
            this.buttonReturnMenu.TabIndex = 0;
            this.buttonReturnMenu.Text = "Вернуться к главному меню";
            this.buttonReturnMenu.UseVisualStyleBackColor = true;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SewingClothes.Properties.Resources._12186_womans_clothes_icon;
            this.pictureBox1.Location = new System.Drawing.Point(436, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(16, 72);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGender.TabIndex = 3;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип одежды:";
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(16, 140);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPurpose.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(16, 215);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSize.TabIndex = 9;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(491, 374);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(150, 79);
            this.buttonSaveChanges.TabIndex = 10;
            this.buttonSaveChanges.Text = "Сохранить изменения и выйти в главное меню";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите мерки для автоматического\r\nопределения размера:";
            // 
            // textBoxBreastSize
            // 
            this.textBoxBreastSize.Location = new System.Drawing.Point(181, 140);
            this.textBoxBreastSize.Name = "textBoxBreastSize";
            this.textBoxBreastSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxBreastSize.TabIndex = 12;
            // 
            // textBoxWaistSize
            // 
            this.textBoxWaistSize.Location = new System.Drawing.Point(181, 215);
            this.textBoxWaistSize.Name = "textBoxWaistSize";
            this.textBoxWaistSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxWaistSize.TabIndex = 13;
            // 
            // textBoxHipsSize
            // 
            this.textBoxHipsSize.Location = new System.Drawing.Point(181, 286);
            this.textBoxHipsSize.Name = "textBoxHipsSize";
            this.textBoxHipsSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxHipsSize.TabIndex = 14;
            // 
            // buttonSizeCalculate
            // 
            this.buttonSizeCalculate.Location = new System.Drawing.Point(181, 332);
            this.buttonSizeCalculate.Name = "buttonSizeCalculate";
            this.buttonSizeCalculate.Size = new System.Drawing.Size(100, 32);
            this.buttonSizeCalculate.TabIndex = 15;
            this.buttonSizeCalculate.Text = "Определить";
            this.buttonSizeCalculate.UseVisualStyleBackColor = true;
            this.buttonSizeCalculate.Click += new System.EventHandler(this.buttonSizeCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Обхват груди(см)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Обхват талии(см)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Обхват бедер(см)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSizeCalculate);
            this.Controls.Add(this.textBoxHipsSize);
            this.Controls.Add(this.textBoxWaistSize);
            this.Controls.Add(this.textBoxBreastSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReturnMenu);
            this.Name = "Form3";
            this.Text = "Выбор характеристик одежды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBreastSize;
        private System.Windows.Forms.TextBox textBoxWaistSize;
        private System.Windows.Forms.TextBox textBoxHipsSize;
        private System.Windows.Forms.Button buttonSizeCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}