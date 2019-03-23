namespace SewingClothes
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.buttonChangeFabric = new System.Windows.Forms.Button();
            this.buttonChangeAccessories = new System.Windows.Forms.Button();
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonInterfaceBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeFabric
            // 
            this.buttonChangeFabric.Location = new System.Drawing.Point(188, 25);
            this.buttonChangeFabric.Name = "buttonChangeFabric";
            this.buttonChangeFabric.Size = new System.Drawing.Size(164, 81);
            this.buttonChangeFabric.TabIndex = 0;
            this.buttonChangeFabric.Text = "Изменить список тканей";
            this.buttonChangeFabric.UseVisualStyleBackColor = true;
            this.buttonChangeFabric.Click += new System.EventHandler(this.buttonChangeFabric_Click);
            // 
            // buttonChangeAccessories
            // 
            this.buttonChangeAccessories.Location = new System.Drawing.Point(188, 124);
            this.buttonChangeAccessories.Name = "buttonChangeAccessories";
            this.buttonChangeAccessories.Size = new System.Drawing.Size(164, 81);
            this.buttonChangeAccessories.TabIndex = 1;
            this.buttonChangeAccessories.Text = "Изменить список аксессуаров";
            this.buttonChangeAccessories.UseVisualStyleBackColor = true;
            this.buttonChangeAccessories.Click += new System.EventHandler(this.buttonChangeAccessories_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(188, 221);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(164, 81);
            this.buttonOrdersList.TabIndex = 2;
            this.buttonOrdersList.Text = "Оформленные заказы";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "Конструктор запросов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonInterfaceBack
            // 
            this.buttonInterfaceBack.Location = new System.Drawing.Point(12, 371);
            this.buttonInterfaceBack.Name = "buttonInterfaceBack";
            this.buttonInterfaceBack.Size = new System.Drawing.Size(132, 60);
            this.buttonInterfaceBack.TabIndex = 6;
            this.buttonInterfaceBack.Text = "Вернуться к выбору интерфейса";
            this.buttonInterfaceBack.UseVisualStyleBackColor = true;
            this.buttonInterfaceBack.Click += new System.EventHandler(this.buttonInterfaceBack_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(570, 443);
            this.Controls.Add(this.buttonInterfaceBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonChangeAccessories);
            this.Controls.Add(this.buttonChangeFabric);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeFabric;
        private System.Windows.Forms.Button buttonChangeAccessories;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonInterfaceBack;
    }
}