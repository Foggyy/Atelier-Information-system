namespace SewingClothes
{
    partial class AdminFabricChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFabricChange));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteFabric = new System.Windows.Forms.Button();
            this.buttonAdminBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFabricName = new System.Windows.Forms.TextBox();
            this.textBoxFabricMaterial = new System.Windows.Forms.TextBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.labelImageLoaded = new System.Windows.Forms.Label();
            this.buttonAddFabric = new System.Windows.Forms.Button();
            this.textBoxFabricTexture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFabricAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFabricCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewAllFabrics = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTexture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxColour = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExcelOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Все ткани";
            // 
            // buttonDeleteFabric
            // 
            this.buttonDeleteFabric.Location = new System.Drawing.Point(420, 455);
            this.buttonDeleteFabric.Name = "buttonDeleteFabric";
            this.buttonDeleteFabric.Size = new System.Drawing.Size(106, 66);
            this.buttonDeleteFabric.TabIndex = 8;
            this.buttonDeleteFabric.Text = "Удалить выбранную ткань";
            this.buttonDeleteFabric.UseVisualStyleBackColor = true;
            this.buttonDeleteFabric.Click += new System.EventHandler(this.buttonDeleteFabric_Click);
            // 
            // buttonAdminBack
            // 
            this.buttonAdminBack.Location = new System.Drawing.Point(17, 460);
            this.buttonAdminBack.Name = "buttonAdminBack";
            this.buttonAdminBack.Size = new System.Drawing.Size(106, 56);
            this.buttonAdminBack.TabIndex = 9;
            this.buttonAdminBack.Text = "Вернуться назад";
            this.buttonAdminBack.UseVisualStyleBackColor = true;
            this.buttonAdminBack.Click += new System.EventHandler(this.buttonAdminBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Добавление/Изменение ткани";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Название ткани";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Материал";
            // 
            // textBoxFabricName
            // 
            this.textBoxFabricName.Location = new System.Drawing.Point(20, 74);
            this.textBoxFabricName.Name = "textBoxFabricName";
            this.textBoxFabricName.Size = new System.Drawing.Size(138, 22);
            this.textBoxFabricName.TabIndex = 13;
            // 
            // textBoxFabricMaterial
            // 
            this.textBoxFabricMaterial.Location = new System.Drawing.Point(17, 145);
            this.textBoxFabricMaterial.Name = "textBoxFabricMaterial";
            this.textBoxFabricMaterial.Size = new System.Drawing.Size(138, 22);
            this.textBoxFabricMaterial.TabIndex = 14;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(556, 119);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(111, 48);
            this.buttonLoadImage.TabIndex = 15;
            this.buttonLoadImage.Text = "Загрузка изображения";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // labelImageLoaded
            // 
            this.labelImageLoaded.AutoSize = true;
            this.labelImageLoaded.Location = new System.Drawing.Point(553, 79);
            this.labelImageLoaded.Name = "labelImageLoaded";
            this.labelImageLoaded.Size = new System.Drawing.Size(190, 17);
            this.labelImageLoaded.TabIndex = 16;
            this.labelImageLoaded.Text = "Изображение не загружено";
            // 
            // buttonAddFabric
            // 
            this.buttonAddFabric.Location = new System.Drawing.Point(748, 101);
            this.buttonAddFabric.Name = "buttonAddFabric";
            this.buttonAddFabric.Size = new System.Drawing.Size(154, 66);
            this.buttonAddFabric.TabIndex = 17;
            this.buttonAddFabric.Text = "Добавить/Изменить ткань";
            this.buttonAddFabric.UseVisualStyleBackColor = true;
            this.buttonAddFabric.Click += new System.EventHandler(this.buttonAddFabric_Click);
            // 
            // textBoxFabricTexture
            // 
            this.textBoxFabricTexture.Location = new System.Drawing.Point(203, 74);
            this.textBoxFabricTexture.Name = "textBoxFabricTexture";
            this.textBoxFabricTexture.Size = new System.Drawing.Size(138, 22);
            this.textBoxFabricTexture.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Фактура";
            // 
            // textBoxFabricAmount
            // 
            this.textBoxFabricAmount.Location = new System.Drawing.Point(379, 145);
            this.textBoxFabricAmount.Name = "textBoxFabricAmount";
            this.textBoxFabricAmount.Size = new System.Drawing.Size(138, 22);
            this.textBoxFabricAmount.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Количество";
            // 
            // textBoxFabricCost
            // 
            this.textBoxFabricCost.Location = new System.Drawing.Point(379, 74);
            this.textBoxFabricCost.Name = "textBoxFabricCost";
            this.textBoxFabricCost.Size = new System.Drawing.Size(138, 22);
            this.textBoxFabricCost.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Цена за метр";
            // 
            // listViewAllFabrics
            // 
            this.listViewAllFabrics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.columnHeaderColour,
            this.columnHeaderName,
            this.columnHeaderMaterial,
            this.columnHeaderTexture,
            this.columnHeaderAmount,
            this.columnHeaderCost});
            this.listViewAllFabrics.FullRowSelect = true;
            this.listViewAllFabrics.Location = new System.Drawing.Point(17, 258);
            this.listViewAllFabrics.Name = "listViewAllFabrics";
            this.listViewAllFabrics.Size = new System.Drawing.Size(860, 187);
            this.listViewAllFabrics.TabIndex = 24;
            this.listViewAllFabrics.UseCompatibleStateImageBehavior = false;
            this.listViewAllFabrics.View = System.Windows.Forms.View.Details;
            this.listViewAllFabrics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAllFabrics_ItemSelectionChanged);
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Изображение";
            this.columnHeaderImage.Width = 109;
            // 
            // columnHeaderColour
            // 
            this.columnHeaderColour.Text = "Цвет";
            this.columnHeaderColour.Width = 88;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 134;
            // 
            // columnHeaderMaterial
            // 
            this.columnHeaderMaterial.Text = "Материал";
            this.columnHeaderMaterial.Width = 93;
            // 
            // columnHeaderTexture
            // 
            this.columnHeaderTexture.Text = "Фактура";
            this.columnHeaderTexture.Width = 115;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Количество (метры)";
            this.columnHeaderAmount.Width = 155;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Стоимость за метр";
            this.columnHeaderCost.Width = 156;
            // 
            // textBoxColour
            // 
            this.textBoxColour.Location = new System.Drawing.Point(203, 145);
            this.textBoxColour.Name = "textBoxColour";
            this.textBoxColour.Size = new System.Drawing.Size(138, 22);
            this.textBoxColour.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Цвет";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(905, 301);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 86);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отменить выделение ткани";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExcelOutput
            // 
            this.buttonExcelOutput.Location = new System.Drawing.Point(900, 450);
            this.buttonExcelOutput.Name = "buttonExcelOutput";
            this.buttonExcelOutput.Size = new System.Drawing.Size(154, 66);
            this.buttonExcelOutput.TabIndex = 28;
            this.buttonExcelOutput.Text = "Вывод данных в Excel файл";
            this.buttonExcelOutput.UseVisualStyleBackColor = true;
            this.buttonExcelOutput.Click += new System.EventHandler(this.buttonExcelOutput_Click);
            // 
            // AdminFabricChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 528);
            this.Controls.Add(this.buttonExcelOutput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxColour);
            this.Controls.Add(this.listViewAllFabrics);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFabricCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFabricAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFabricTexture);
            this.Controls.Add(this.buttonAddFabric);
            this.Controls.Add(this.labelImageLoaded);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.textBoxFabricMaterial);
            this.Controls.Add(this.textBoxFabricName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdminBack);
            this.Controls.Add(this.buttonDeleteFabric);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminFabricChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение списка тканей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminFabricChange_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteFabric;
        private System.Windows.Forms.Button buttonAdminBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFabricName;
        private System.Windows.Forms.TextBox textBoxFabricMaterial;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelImageLoaded;
        private System.Windows.Forms.Button buttonAddFabric;
        private System.Windows.Forms.TextBox textBoxFabricTexture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFabricAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFabricCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewAllFabrics;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderColour;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterial;
        private System.Windows.Forms.ColumnHeader columnHeaderTexture;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.TextBox textBoxColour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExcelOutput;
    }
}