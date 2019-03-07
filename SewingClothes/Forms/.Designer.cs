namespace SewingClothes
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonBasket = new System.Windows.Forms.Button();
            this.buttonClothesChoice = new System.Windows.Forms.Button();
            this.buttonAccessouriesChoice = new System.Windows.Forms.Button();
            this.buttonFabricChoice = new System.Windows.Forms.Button();
            this.buttonInterfaceBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFabricName = new System.Windows.Forms.Label();
            this.labelAccessouriesName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPurposeValue = new System.Windows.Forms.Label();
            this.labelGenderValue = new System.Windows.Forms.Label();
            this.labelSizeValue = new System.Windows.Forms.Label();
            this.labelFabricNameValue = new System.Windows.Forms.Label();
            this.richTextBoxAccessouries = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBasket
            // 
            this.buttonBasket.Location = new System.Drawing.Point(723, 12);
            this.buttonBasket.Name = "buttonBasket";
            this.buttonBasket.Size = new System.Drawing.Size(87, 34);
            this.buttonBasket.TabIndex = 0;
            this.buttonBasket.Text = "Корзина";
            this.buttonBasket.UseVisualStyleBackColor = true;
            this.buttonBasket.Click += new System.EventHandler(this.buttonBasket_Click);
            // 
            // buttonClothesChoice
            // 
            this.buttonClothesChoice.Location = new System.Drawing.Point(322, 56);
            this.buttonClothesChoice.Name = "buttonClothesChoice";
            this.buttonClothesChoice.Size = new System.Drawing.Size(158, 76);
            this.buttonClothesChoice.TabIndex = 2;
            this.buttonClothesChoice.Text = "Выбор одежды";
            this.buttonClothesChoice.UseVisualStyleBackColor = true;
            this.buttonClothesChoice.Click += new System.EventHandler(this.buttonClothesChoice_Click);
            // 
            // buttonAccessouriesChoice
            // 
            this.buttonAccessouriesChoice.Location = new System.Drawing.Point(322, 267);
            this.buttonAccessouriesChoice.Name = "buttonAccessouriesChoice";
            this.buttonAccessouriesChoice.Size = new System.Drawing.Size(158, 76);
            this.buttonAccessouriesChoice.TabIndex = 3;
            this.buttonAccessouriesChoice.Text = "Выбор аксессуаров";
            this.buttonAccessouriesChoice.UseVisualStyleBackColor = true;
            this.buttonAccessouriesChoice.Click += new System.EventHandler(this.buttonAccessouriesChoice_Click);
            // 
            // buttonFabricChoice
            // 
            this.buttonFabricChoice.Location = new System.Drawing.Point(322, 163);
            this.buttonFabricChoice.Name = "buttonFabricChoice";
            this.buttonFabricChoice.Size = new System.Drawing.Size(158, 76);
            this.buttonFabricChoice.TabIndex = 4;
            this.buttonFabricChoice.Text = "Выбор ткани";
            this.buttonFabricChoice.UseVisualStyleBackColor = true;
            this.buttonFabricChoice.Click += new System.EventHandler(this.buttonFabricChoice_Click);
            // 
            // buttonInterfaceBack
            // 
            this.buttonInterfaceBack.Location = new System.Drawing.Point(12, 395);
            this.buttonInterfaceBack.Name = "buttonInterfaceBack";
            this.buttonInterfaceBack.Size = new System.Drawing.Size(132, 60);
            this.buttonInterfaceBack.TabIndex = 5;
            this.buttonInterfaceBack.Text = "Вернуться к выбору интерфейса";
            this.buttonInterfaceBack.UseVisualStyleBackColor = true;
            this.buttonInterfaceBack.Click += new System.EventHandler(this.buttonInterfaceBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SewingClothes.Properties.Resources.supermarketbasket_89193;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(533, 146);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(38, 17);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Пол:";
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(533, 176);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(93, 17);
            this.labelPurpose.TabIndex = 7;
            this.labelPurpose.Text = "Назначение:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(533, 207);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(61, 17);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Размер:";
            // 
            // labelFabricName
            // 
            this.labelFabricName.AutoSize = true;
            this.labelFabricName.Location = new System.Drawing.Point(533, 239);
            this.labelFabricName.Name = "labelFabricName";
            this.labelFabricName.Size = new System.Drawing.Size(118, 17);
            this.labelFabricName.TabIndex = 9;
            this.labelFabricName.Text = "Название ткани:";
            // 
            // labelAccessouriesName
            // 
            this.labelAccessouriesName.AutoSize = true;
            this.labelAccessouriesName.Location = new System.Drawing.Point(533, 267);
            this.labelAccessouriesName.Name = "labelAccessouriesName";
            this.labelAccessouriesName.Size = new System.Drawing.Size(162, 17);
            this.labelAccessouriesName.TabIndex = 10;
            this.labelAccessouriesName.Text = "Названия аксессуаров:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            // 
            // labelPurposeValue
            // 
            this.labelPurposeValue.AutoSize = true;
            this.labelPurposeValue.Location = new System.Drawing.Point(717, 176);
            this.labelPurposeValue.Name = "labelPurposeValue";
            this.labelPurposeValue.Size = new System.Drawing.Size(13, 17);
            this.labelPurposeValue.TabIndex = 12;
            this.labelPurposeValue.Text = "-";
            this.labelPurposeValue.Visible = false;
            // 
            // labelGenderValue
            // 
            this.labelGenderValue.AutoSize = true;
            this.labelGenderValue.Location = new System.Drawing.Point(717, 146);
            this.labelGenderValue.Name = "labelGenderValue";
            this.labelGenderValue.Size = new System.Drawing.Size(13, 17);
            this.labelGenderValue.TabIndex = 13;
            this.labelGenderValue.Text = "-";
            this.labelGenderValue.Visible = false;
            // 
            // labelSizeValue
            // 
            this.labelSizeValue.AutoSize = true;
            this.labelSizeValue.Location = new System.Drawing.Point(717, 207);
            this.labelSizeValue.Name = "labelSizeValue";
            this.labelSizeValue.Size = new System.Drawing.Size(13, 17);
            this.labelSizeValue.TabIndex = 14;
            this.labelSizeValue.Text = "-";
            this.labelSizeValue.Visible = false;
            // 
            // labelFabricNameValue
            // 
            this.labelFabricNameValue.AutoSize = true;
            this.labelFabricNameValue.Location = new System.Drawing.Point(717, 239);
            this.labelFabricNameValue.Name = "labelFabricNameValue";
            this.labelFabricNameValue.Size = new System.Drawing.Size(13, 17);
            this.labelFabricNameValue.TabIndex = 15;
            this.labelFabricNameValue.Text = "-";
            this.labelFabricNameValue.Visible = false;
            // 
            // richTextBoxAccessouries
            // 
            this.richTextBoxAccessouries.Location = new System.Drawing.Point(720, 267);
            this.richTextBoxAccessouries.Name = "richTextBoxAccessouries";
            this.richTextBoxAccessouries.Size = new System.Drawing.Size(174, 101);
            this.richTextBoxAccessouries.TabIndex = 16;
            this.richTextBoxAccessouries.Text = "";
            this.richTextBoxAccessouries.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.richTextBoxAccessouries);
            this.Controls.Add(this.labelFabricNameValue);
            this.Controls.Add(this.labelSizeValue);
            this.Controls.Add(this.labelGenderValue);
            this.Controls.Add(this.labelPurposeValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAccessouriesName);
            this.Controls.Add(this.labelFabricName);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.buttonInterfaceBack);
            this.Controls.Add(this.buttonFabricChoice);
            this.Controls.Add(this.buttonAccessouriesChoice);
            this.Controls.Add(this.buttonClothesChoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBasket);
            this.Name = "Form2";
            this.Text = "Конструктор одежды";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBasket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClothesChoice;
        private System.Windows.Forms.Button buttonAccessouriesChoice;
        private System.Windows.Forms.Button buttonFabricChoice;
        private System.Windows.Forms.Button buttonInterfaceBack;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFabricName;
        private System.Windows.Forms.Label labelAccessouriesName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPurposeValue;
        private System.Windows.Forms.Label labelGenderValue;
        private System.Windows.Forms.Label labelSizeValue;
        private System.Windows.Forms.Label labelFabricNameValue;
        private System.Windows.Forms.RichTextBox richTextBoxAccessouries;
    }
}