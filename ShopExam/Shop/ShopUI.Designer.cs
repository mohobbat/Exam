namespace Shop
{
    partial class ShopUI
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
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextButton = new System.Windows.Forms.Button();
            this.productInfoGridView = new System.Windows.Forms.DataGridView();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(300, 421);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(145, 20);
            this.totalTextBox.TabIndex = 16;
            // 
            // totalTextButton
            // 
            this.totalTextButton.Location = new System.Drawing.Point(155, 420);
            this.totalTextButton.Name = "totalTextButton";
            this.totalTextButton.Size = new System.Drawing.Size(75, 23);
            this.totalTextButton.TabIndex = 15;
            this.totalTextButton.Text = "Total Quantity ";
            this.totalTextButton.UseVisualStyleBackColor = true;
            // 
            // productInfoGridView
            // 
            this.productInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInfoGridView.Location = new System.Drawing.Point(57, 238);
            this.productInfoGridView.Name = "productInfoGridView";
            this.productInfoGridView.Size = new System.Drawing.Size(422, 146);
            this.productInfoGridView.TabIndex = 14;
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(427, 179);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(75, 23);
            this.viewAllButton.TabIndex = 12;
            this.viewAllButton.Text = "View ALL";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(176, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(176, 119);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(139, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(176, 59);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.productNameTextBox.TabIndex = 10;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(176, 16);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(139, 20);
            this.productCodeTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producet Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ProductCode";
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 501);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalTextButton);
            this.Controls.Add(this.productInfoGridView);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShopUI";
            this.Text = "ShopUI";
            ((System.ComponentModel.ISupportInitialize)(this.productInfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button totalTextButton;
        private System.Windows.Forms.DataGridView productInfoGridView;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

