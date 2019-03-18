namespace SewingClothes
{
    partial class AccesouriesChoice
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
            this.label6 = new System.Windows.Forms.Label();
            this.listViewAccessories = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddAccesories = new System.Windows.Forms.Button();
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.listViewRecommended = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рекомендуемые аксессуары";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Все аксессуары";
            // 
            // listViewAccessories
            // 
            this.listViewAccessories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.columnHeaderType,
            this.columnHeaderPosition,
            this.columnHeaderAmount,
            this.columnHeaderCost});
            this.listViewAccessories.FullRowSelect = true;
            this.listViewAccessories.Location = new System.Drawing.Point(17, 297);
            this.listViewAccessories.Name = "listViewAccessories";
            this.listViewAccessories.Size = new System.Drawing.Size(740, 201);
            this.listViewAccessories.TabIndex = 18;
            this.listViewAccessories.UseCompatibleStateImageBehavior = false;
            this.listViewAccessories.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Изображение";
            this.columnHeaderImage.Width = 108;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            this.columnHeaderType.Width = 179;
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "Положение";
            this.columnHeaderPosition.Width = 173;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Количество";
            this.columnHeaderAmount.Width = 105;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Стоимость за единицу";
            this.columnHeaderCost.Width = 164;
            // 
            // buttonAddAccesories
            // 
            this.buttonAddAccesories.Location = new System.Drawing.Point(834, 160);
            this.buttonAddAccesories.Name = "buttonAddAccesories";
            this.buttonAddAccesories.Size = new System.Drawing.Size(140, 82);
            this.buttonAddAccesories.TabIndex = 19;
            this.buttonAddAccesories.Text = "Добавить аксессуары и выйти в меню";
            this.buttonAddAccesories.UseVisualStyleBackColor = true;
            this.buttonAddAccesories.Click += new System.EventHandler(this.buttonAddAccesories_Click);
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(834, 297);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(140, 84);
            this.buttonReturnMenu.TabIndex = 20;
            this.buttonReturnMenu.Text = "Ничего не выбирать и выйти в меню";
            this.buttonReturnMenu.UseVisualStyleBackColor = true;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // listViewRecommended
            // 
            this.listViewRecommended.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRecommended.FullRowSelect = true;
            this.listViewRecommended.Location = new System.Drawing.Point(17, 41);
            this.listViewRecommended.Name = "listViewRecommended";
            this.listViewRecommended.Size = new System.Drawing.Size(740, 201);
            this.listViewRecommended.TabIndex = 21;
            this.listViewRecommended.UseCompatibleStateImageBehavior = false;
            this.listViewRecommended.View = System.Windows.Forms.View.Details;
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
            this.columnHeader4.Text = "Количество";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Стоимость за единицу";
            this.columnHeader5.Width = 164;
            // 
            // AccesouriesChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 510);
            this.Controls.Add(this.listViewRecommended);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonAddAccesories);
            this.Controls.Add(this.listViewAccessories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AccesouriesChoice";
            this.Text = "Выбор аксессуаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccesouriesChoice_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewAccessories;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.Button buttonAddAccesories;
        private System.Windows.Forms.Button buttonReturnMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ListView listViewRecommended;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}