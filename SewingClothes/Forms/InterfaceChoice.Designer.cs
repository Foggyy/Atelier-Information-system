namespace SewingClothes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCustomerChoice = new System.Windows.Forms.Button();
            this.buttonAdminChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCustomerChoice
            // 
            this.buttonCustomerChoice.Location = new System.Drawing.Point(59, 136);
            this.buttonCustomerChoice.Name = "buttonCustomerChoice";
            this.buttonCustomerChoice.Size = new System.Drawing.Size(153, 66);
            this.buttonCustomerChoice.TabIndex = 0;
            this.buttonCustomerChoice.Text = "Пользователь";
            this.buttonCustomerChoice.UseVisualStyleBackColor = true;
            this.buttonCustomerChoice.Click += new System.EventHandler(this.buttonCustomerChoice_Click);
            // 
            // buttonAdminChoice
            // 
            this.buttonAdminChoice.Location = new System.Drawing.Point(312, 136);
            this.buttonAdminChoice.Name = "buttonAdminChoice";
            this.buttonAdminChoice.Size = new System.Drawing.Size(153, 66);
            this.buttonAdminChoice.TabIndex = 1;
            this.buttonAdminChoice.Text = "Администратор";
            this.buttonAdminChoice.UseVisualStyleBackColor = true;
            this.buttonAdminChoice.Click += new System.EventHandler(this.buttonAdminChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор интерфейса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(532, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdminChoice);
            this.Controls.Add(this.buttonCustomerChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор интерфейса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomerChoice;
        private System.Windows.Forms.Button buttonAdminChoice;
        private System.Windows.Forms.Label label1;
    }
}

