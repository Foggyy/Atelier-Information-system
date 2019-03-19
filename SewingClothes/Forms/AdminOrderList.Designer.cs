namespace SewingClothes
{
    partial class OrderList
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
            this.label2 = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCostDynamic = new System.Windows.Forms.Label();
            this.labelDateDynamic = new System.Windows.Forms.Label();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.labelDeliveryType = new System.Windows.Forms.Label();
            this.labelPaymentDynamic = new System.Windows.Forms.Label();
            this.labelDeliveryDynamic = new System.Windows.Forms.Label();
            this.labelClothesType = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelClothesTypeDynamic = new System.Windows.Forms.Label();
            this.labelGenderDynamic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFabricName = new System.Windows.Forms.Label();
            this.labelFabricColour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Заказчики";
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.Location = new System.Drawing.Point(17, 89);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(789, 212);
            this.listViewOrders.TabIndex = 12;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewOrders_ItemSelectionChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "ID";
            this.columnHeader0.Width = 76;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID заказа";
            this.columnHeader4.Width = 146;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(700, 320);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(106, 69);
            this.buttonCancelOrder.TabIndex = 13;
            this.buttonCancelOrder.Text = "Отменить выбранный заказ";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(17, 320);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(106, 69);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "Вернуться назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(847, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Информация о заказе";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(852, 89);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 17);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Дата:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(852, 119);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(82, 17);
            this.labelCost.TabIndex = 17;
            this.labelCost.Text = "Стоимость:";
            // 
            // labelCostDynamic
            // 
            this.labelCostDynamic.AutoSize = true;
            this.labelCostDynamic.Location = new System.Drawing.Point(1000, 119);
            this.labelCostDynamic.Name = "labelCostDynamic";
            this.labelCostDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelCostDynamic.TabIndex = 18;
            this.labelCostDynamic.Text = "-";
            // 
            // labelDateDynamic
            // 
            this.labelDateDynamic.AutoSize = true;
            this.labelDateDynamic.Location = new System.Drawing.Point(1000, 89);
            this.labelDateDynamic.Name = "labelDateDynamic";
            this.labelDateDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelDateDynamic.TabIndex = 19;
            this.labelDateDynamic.Text = "-";
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Location = new System.Drawing.Point(852, 149);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(113, 17);
            this.labelPaymentType.TabIndex = 20;
            this.labelPaymentType.Text = "Способ оплаты:";
            // 
            // labelDeliveryType
            // 
            this.labelDeliveryType.AutoSize = true;
            this.labelDeliveryType.Location = new System.Drawing.Point(852, 181);
            this.labelDeliveryType.Name = "labelDeliveryType";
            this.labelDeliveryType.Size = new System.Drawing.Size(124, 17);
            this.labelDeliveryType.TabIndex = 21;
            this.labelDeliveryType.Text = "Способ доставки:";
            // 
            // labelPaymentDynamic
            // 
            this.labelPaymentDynamic.AutoSize = true;
            this.labelPaymentDynamic.Location = new System.Drawing.Point(1000, 149);
            this.labelPaymentDynamic.Name = "labelPaymentDynamic";
            this.labelPaymentDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelPaymentDynamic.TabIndex = 22;
            this.labelPaymentDynamic.Text = "-";
            // 
            // labelDeliveryDynamic
            // 
            this.labelDeliveryDynamic.AutoSize = true;
            this.labelDeliveryDynamic.Location = new System.Drawing.Point(1000, 181);
            this.labelDeliveryDynamic.Name = "labelDeliveryDynamic";
            this.labelDeliveryDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelDeliveryDynamic.TabIndex = 23;
            this.labelDeliveryDynamic.Text = "-";
            // 
            // labelClothesType
            // 
            this.labelClothesType.AutoSize = true;
            this.labelClothesType.Location = new System.Drawing.Point(852, 213);
            this.labelClothesType.Name = "labelClothesType";
            this.labelClothesType.Size = new System.Drawing.Size(92, 17);
            this.labelClothesType.TabIndex = 24;
            this.labelClothesType.Text = "Тип одежды:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(852, 243);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(38, 17);
            this.labelGender.TabIndex = 25;
            this.labelGender.Text = "Пол:";
            // 
            // labelClothesTypeDynamic
            // 
            this.labelClothesTypeDynamic.AutoSize = true;
            this.labelClothesTypeDynamic.Location = new System.Drawing.Point(1000, 213);
            this.labelClothesTypeDynamic.Name = "labelClothesTypeDynamic";
            this.labelClothesTypeDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelClothesTypeDynamic.TabIndex = 26;
            this.labelClothesTypeDynamic.Text = "-";
            // 
            // labelGenderDynamic
            // 
            this.labelGenderDynamic.AutoSize = true;
            this.labelGenderDynamic.Location = new System.Drawing.Point(1000, 243);
            this.labelGenderDynamic.Name = "labelGenderDynamic";
            this.labelGenderDynamic.Size = new System.Drawing.Size(13, 17);
            this.labelGenderDynamic.TabIndex = 27;
            this.labelGenderDynamic.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ткань:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Цвет ткани:";
            // 
            // labelFabricName
            // 
            this.labelFabricName.AutoSize = true;
            this.labelFabricName.Location = new System.Drawing.Point(1000, 273);
            this.labelFabricName.Name = "labelFabricName";
            this.labelFabricName.Size = new System.Drawing.Size(13, 17);
            this.labelFabricName.TabIndex = 30;
            this.labelFabricName.Text = "-";
            // 
            // labelFabricColour
            // 
            this.labelFabricColour.AutoSize = true;
            this.labelFabricColour.Location = new System.Drawing.Point(1000, 304);
            this.labelFabricColour.Name = "labelFabricColour";
            this.labelFabricColour.Size = new System.Drawing.Size(13, 17);
            this.labelFabricColour.TabIndex = 31;
            this.labelFabricColour.Text = "-";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1378, 417);
            this.Controls.Add(this.labelFabricColour);
            this.Controls.Add(this.labelFabricName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGenderDynamic);
            this.Controls.Add(this.labelClothesTypeDynamic);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelClothesType);
            this.Controls.Add(this.labelDeliveryDynamic);
            this.Controls.Add(this.labelPaymentDynamic);
            this.Controls.Add(this.labelDeliveryType);
            this.Controls.Add(this.labelPaymentType);
            this.Controls.Add(this.labelDateDynamic);
            this.Controls.Add(this.labelCostDynamic);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.label2);
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCostDynamic;
        private System.Windows.Forms.Label labelDateDynamic;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.Label labelDeliveryType;
        private System.Windows.Forms.Label labelPaymentDynamic;
        private System.Windows.Forms.Label labelDeliveryDynamic;
        private System.Windows.Forms.Label labelClothesType;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelClothesTypeDynamic;
        private System.Windows.Forms.Label labelGenderDynamic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFabricName;
        private System.Windows.Forms.Label labelFabricColour;
    }
}