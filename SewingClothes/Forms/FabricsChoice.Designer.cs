namespace SewingClothes
{
    partial class FabricsChoice
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
            this.listViewAllFabrics = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTexture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddFabric = new System.Windows.Forms.Button();
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все ткани";
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
            this.listViewAllFabrics.Location = new System.Drawing.Point(12, 304);
            this.listViewAllFabrics.Name = "listViewAllFabrics";
            this.listViewAllFabrics.Size = new System.Drawing.Size(860, 187);
            this.listViewAllFabrics.TabIndex = 1;
            this.listViewAllFabrics.UseCompatibleStateImageBehavior = false;
            this.listViewAllFabrics.View = System.Windows.Forms.View.Details;
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
            // buttonAddFabric
            // 
            this.buttonAddFabric.Location = new System.Drawing.Point(933, 216);
            this.buttonAddFabric.Name = "buttonAddFabric";
            this.buttonAddFabric.Size = new System.Drawing.Size(138, 85);
            this.buttonAddFabric.TabIndex = 2;
            this.buttonAddFabric.Text = "Выбрать ткань и вернуться в меню";
            this.buttonAddFabric.UseVisualStyleBackColor = true;
            this.buttonAddFabric.Click += new System.EventHandler(this.buttonAddFabric_Click);
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(12, 497);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(165, 49);
            this.buttonReturnMenu.TabIndex = 3;
            this.buttonReturnMenu.Text = "Отменить изменения и вернуться в меню";
            this.buttonReturnMenu.UseVisualStyleBackColor = true;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рекомендуемые ткани";
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Стоимость за метр";
            this.columnHeaderCost.Width = 156;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(17, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 176);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Изображение";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цвет";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Материал";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фактура";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Количество (метры)";
            this.columnHeader6.Width = 155;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Стоимость за метр";
            this.columnHeader7.Width = 156;
            // 
            // FabricsChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 558);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonAddFabric);
            this.Controls.Add(this.listViewAllFabrics);
            this.Controls.Add(this.label1);
            this.Name = "FabricsChoice";
            this.Text = "Выбор ткани";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAllFabrics;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderColour;
        private System.Windows.Forms.Button buttonAddFabric;
        private System.Windows.Forms.Button buttonReturnMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterial;
        private System.Windows.Forms.ColumnHeader columnHeaderTexture;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}