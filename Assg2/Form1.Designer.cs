namespace Assg2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descendingButton = new System.Windows.Forms.RadioButton();
            this.ascendingButton = new System.Windows.Forms.RadioButton();
            this.showButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please input two integer numbers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descendingButton);
            this.groupBox1.Controls.Add(this.ascendingButton);
            this.groupBox1.Location = new System.Drawing.Point(44, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "order";
            // 
            // descendingButton
            // 
            this.descendingButton.AutoSize = true;
            this.descendingButton.Location = new System.Drawing.Point(14, 86);
            this.descendingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(156, 19);
            this.descendingButton.TabIndex = 1;
            this.descendingButton.TabStop = true;
            this.descendingButton.Text = "descending order";
            this.descendingButton.UseVisualStyleBackColor = true;
            this.descendingButton.CheckedChanged += new System.EventHandler(this.descendingButton_CheckedChanged);
            // 
            // ascendingButton
            // 
            this.ascendingButton.AutoSize = true;
            this.ascendingButton.Location = new System.Drawing.Point(14, 37);
            this.ascendingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(148, 19);
            this.ascendingButton.TabIndex = 0;
            this.ascendingButton.TabStop = true;
            this.ascendingButton.Text = "ascending order";
            this.ascendingButton.UseVisualStyleBackColor = true;
            this.ascendingButton.CheckedChanged += new System.EventHandler(this.ascendingButton_CheckedChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(42, 310);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(230, 44);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "show all the prime numbers";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(363, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.AcceptsReturn = true;
            this.resultTextBox.AcceptsTab = true;
            this.resultTextBox.Location = new System.Drawing.Point(375, 74);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(199, 280);
            this.resultTextBox.TabIndex = 7;
            this.resultTextBox.Text = "The result will be shown here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 375);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Prime Number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton descendingButton;
        private System.Windows.Forms.RadioButton ascendingButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

