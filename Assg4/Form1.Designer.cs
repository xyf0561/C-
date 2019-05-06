namespace Assg4
{
    partial class ShopForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Query = new System.Windows.Forms.GroupBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.numberButton = new System.Windows.Forms.RadioButton();
            this.priceButton = new System.Windows.Forms.RadioButton();
            this.queryButton = new System.Windows.Forms.Button();
            this.Purchase = new System.Windows.Forms.GroupBox();
            this.PurchaseLabel = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyOrRemoveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Query.SuspendLayout();
            this.Purchase.SuspendLayout();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Query
            // 
            this.Query.Controls.Add(this.queryLabel);
            this.Query.Controls.Add(this.queryComboBox);
            this.Query.Controls.Add(this.numberButton);
            this.Query.Controls.Add(this.priceButton);
            this.Query.Controls.Add(this.queryButton);
            this.Query.Location = new System.Drawing.Point(57, 33);
            this.Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Query.Name = "Query";
            this.Query.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Query.Size = new System.Drawing.Size(884, 123);
            this.Query.TabIndex = 0;
            this.Query.TabStop = false;
            this.Query.Text = "Query";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryLabel.Location = new System.Drawing.Point(582, 48);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(154, 24);
            this.queryLabel.TabIndex = 4;
            this.queryLabel.Text = "Query Result";
            // 
            // queryComboBox
            // 
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            "Computer",
            "Phone"});
            this.queryComboBox.Location = new System.Drawing.Point(29, 38);
            this.queryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(190, 23);
            this.queryComboBox.TabIndex = 3;
            // 
            // numberButton
            // 
            this.numberButton.AutoSize = true;
            this.numberButton.Location = new System.Drawing.Point(237, 71);
            this.numberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(148, 19);
            this.numberButton.TabIndex = 2;
            this.numberButton.TabStop = true;
            this.numberButton.Text = "number of stock";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.CheckedChanged += new System.EventHandler(this.numberButton_CheckedChanged);
            // 
            // priceButton
            // 
            this.priceButton.AutoSize = true;
            this.priceButton.Location = new System.Drawing.Point(237, 38);
            this.priceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(68, 19);
            this.priceButton.TabIndex = 1;
            this.priceButton.TabStop = true;
            this.priceButton.Text = "price";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.CheckedChanged += new System.EventHandler(this.priceButton_CheckedChanged);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(419, 38);
            this.queryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(124, 51);
            this.queryButton.TabIndex = 0;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // Purchase
            // 
            this.Purchase.Controls.Add(this.PurchaseLabel);
            this.Purchase.Controls.Add(this.PurchaseButton);
            this.Purchase.Controls.Add(this.textBox5);
            this.Purchase.Controls.Add(this.textBox4);
            this.Purchase.Controls.Add(this.textBox3);
            this.Purchase.Controls.Add(this.textBox2);
            this.Purchase.Controls.Add(this.textBox1);
            this.Purchase.Controls.Add(this.label5);
            this.Purchase.Controls.Add(this.label4);
            this.Purchase.Controls.Add(this.label3);
            this.Purchase.Controls.Add(this.label2);
            this.Purchase.Controls.Add(this.label1);
            this.Purchase.Controls.Add(this.comboBox5);
            this.Purchase.Controls.Add(this.comboBox4);
            this.Purchase.Controls.Add(this.comboBox3);
            this.Purchase.Controls.Add(this.comboBox2);
            this.Purchase.Controls.Add(this.comboBox1);
            this.Purchase.Location = new System.Drawing.Point(57, 194);
            this.Purchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Purchase.Name = "Purchase";
            this.Purchase.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Purchase.Size = new System.Drawing.Size(884, 221);
            this.Purchase.TabIndex = 1;
            this.Purchase.TabStop = false;
            this.Purchase.Text = "Purchase";
            // 
            // PurchaseLabel
            // 
            this.PurchaseLabel.AutoSize = true;
            this.PurchaseLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PurchaseLabel.Location = new System.Drawing.Point(605, 122);
            this.PurchaseLabel.Name = "PurchaseLabel";
            this.PurchaseLabel.Size = new System.Drawing.Size(159, 20);
            this.PurchaseLabel.TabIndex = 16;
            this.PurchaseLabel.Text = "Purchase Result";
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(587, 25);
            this.PurchaseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(201, 42);
            this.PurchaseButton.TabIndex = 15;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(419, 176);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 25);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "-";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(419, 136);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 25);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "-";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(419, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 25);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "-";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(419, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 25);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "-";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 25);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "-";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "number";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(38, 176);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(224, 23);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.Text = "- - - -";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(38, 136);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(224, 23);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.Text = "- - - -";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(38, 96);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 23);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "- - - -";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(38, 57);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "- - - -";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "- - - -";
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.modifyOrRemoveButton);
            this.modifyGroupBox.Controls.Add(this.addButton);
            this.modifyGroupBox.Location = new System.Drawing.Point(57, 448);
            this.modifyGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyGroupBox.Size = new System.Drawing.Size(883, 86);
            this.modifyGroupBox.TabIndex = 2;
            this.modifyGroupBox.TabStop = false;
            this.modifyGroupBox.Text = "Modify";
            // 
            // modifyOrRemoveButton
            // 
            this.modifyOrRemoveButton.Location = new System.Drawing.Point(353, 33);
            this.modifyOrRemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyOrRemoveButton.Name = "modifyOrRemoveButton";
            this.modifyOrRemoveButton.Size = new System.Drawing.Size(375, 32);
            this.modifyOrRemoveButton.TabIndex = 1;
            this.modifyOrRemoveButton.Text = "Modify or Remove";
            this.modifyOrRemoveButton.UseVisualStyleBackColor = true;
            this.modifyOrRemoveButton.Click += new System.EventHandler(this.modifyOrRemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(82, 33);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 575);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.Query);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.Query.ResumeLayout(false);
            this.Query.PerformLayout();
            this.Purchase.ResumeLayout(false);
            this.Purchase.PerformLayout();
            this.modifyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Query;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.GroupBox Purchase;
        private System.Windows.Forms.RadioButton numberButton;
        private System.Windows.Forms.RadioButton priceButton;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyOrRemoveButton;
        public System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Label PurchaseLabel;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

