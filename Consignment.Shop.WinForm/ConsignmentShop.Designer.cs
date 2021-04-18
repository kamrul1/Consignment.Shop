
namespace Consignment.Shop.WinForm
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consignmentShopLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.storeItemLabel = new System.Windows.Forms.Label();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consignmentShopLabel
            // 
            this.consignmentShopLabel.AutoSize = true;
            this.consignmentShopLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consignmentShopLabel.Location = new System.Drawing.Point(237, 9);
            this.consignmentShopLabel.Name = "consignmentShopLabel";
            this.consignmentShopLabel.Size = new System.Drawing.Size(304, 45);
            this.consignmentShopLabel.TabIndex = 0;
            this.consignmentShopLabel.Text = "Consignment Shop";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 15;
            this.itemListBox.Location = new System.Drawing.Point(28, 117);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(261, 289);
            this.itemListBox.TabIndex = 1;
            // 
            // storeItemLabel
            // 
            this.storeItemLabel.AutoSize = true;
            this.storeItemLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeItemLabel.Location = new System.Drawing.Point(28, 83);
            this.storeItemLabel.Name = "storeItemLabel";
            this.storeItemLabel.Size = new System.Drawing.Size(88, 21);
            this.storeItemLabel.TabIndex = 2;
            this.storeItemLabel.Text = "Store items";
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoppingCartLabel.Location = new System.Drawing.Point(505, 83);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(152, 21);
            this.shoppingCartLabel.TabIndex = 4;
            this.shoppingCartLabel.Text = "Shopping Cart Items";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 15;
            this.shoppingCartListBox.Location = new System.Drawing.Point(505, 117);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(261, 289);
            this.shoppingCartListBox.TabIndex = 3;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(322, 154);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(127, 23);
            this.addToCartButton.TabIndex = 5;
            this.addToCartButton.Text = "Add to Cart >";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(670, 415);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vendorLabel.Location = new System.Drawing.Point(28, 488);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(87, 21);
            this.vendorLabel.TabIndex = 8;
            this.vendorLabel.Text = "Vender List";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 15;
            this.vendorListBox.Location = new System.Drawing.Point(28, 522);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(261, 289);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeProfitLabel.Location = new System.Drawing.Point(505, 488);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(88, 21);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeProfitValue.Location = new System.Drawing.Point(612, 488);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(49, 21);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 871);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.storeItemLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.consignmentShopLabel);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consignmentShopLabel;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label storeItemLabel;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

