namespace Assg1
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
            this.interestBox = new System.Windows.Forms.GroupBox();
            this.simpleButton = new System.Windows.Forms.RadioButton();
            this.compoundButton = new System.Windows.Forms.RadioButton();
            this.principalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.principalText = new System.Windows.Forms.TextBox();
            this.rateText = new System.Windows.Forms.TextBox();
            this.loanPeriodText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.interestBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // interestBox
            // 
            this.interestBox.Controls.Add(this.compoundButton);
            this.interestBox.Controls.Add(this.simpleButton);
            this.interestBox.Location = new System.Drawing.Point(36, 65);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(254, 148);
            this.interestBox.TabIndex = 0;
            this.interestBox.TabStop = false;
            this.interestBox.Text = "interest";
            // 
            // simpleButton
            // 
            this.simpleButton.AutoSize = true;
            this.simpleButton.Location = new System.Drawing.Point(27, 48);
            this.simpleButton.Name = "simpleButton";
            this.simpleButton.Size = new System.Drawing.Size(168, 22);
            this.simpleButton.TabIndex = 0;
            this.simpleButton.TabStop = true;
            this.simpleButton.Text = "simple interest";
            this.simpleButton.UseVisualStyleBackColor = true;
            this.simpleButton.CheckedChanged += new System.EventHandler(this.simpleButton_CheckedChanged);
            // 
            // compoundButton
            // 
            this.compoundButton.AutoSize = true;
            this.compoundButton.Location = new System.Drawing.Point(27, 102);
            this.compoundButton.Name = "compoundButton";
            this.compoundButton.Size = new System.Drawing.Size(186, 22);
            this.compoundButton.TabIndex = 1;
            this.compoundButton.TabStop = true;
            this.compoundButton.Text = "compound interest";
            this.compoundButton.UseVisualStyleBackColor = true;
            this.compoundButton.CheckedChanged += new System.EventHandler(this.compoundButton_CheckedChanged);
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(33, 268);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(89, 18);
            this.principalLabel.TabIndex = 1;
            this.principalLabel.Text = "principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "rate(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "loan period";
            // 
            // principalText
            // 
            this.principalText.Location = new System.Drawing.Point(174, 265);
            this.principalText.Name = "principalText";
            this.principalText.Size = new System.Drawing.Size(116, 28);
            this.principalText.TabIndex = 4;
            // 
            // rateText
            // 
            this.rateText.Location = new System.Drawing.Point(174, 318);
            this.rateText.Name = "rateText";
            this.rateText.Size = new System.Drawing.Size(116, 28);
            this.rateText.TabIndex = 5;
            // 
            // loanPeriodText
            // 
            this.loanPeriodText.Location = new System.Drawing.Point(174, 363);
            this.loanPeriodText.Name = "loanPeriodText";
            this.loanPeriodText.Size = new System.Drawing.Size(116, 28);
            this.loanPeriodText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "total amount :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amountLabel.Location = new System.Drawing.Point(386, 146);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(358, 24);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "The result will be shown here";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(470, 241);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(181, 45);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate(&C)";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(470, 301);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(181, 45);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset(&R)";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(470, 366);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(181, 45);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit(&E)";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanPeriodText);
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.principalText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.interestBox);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.interestBox.ResumeLayout(false);
            this.interestBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox interestBox;
        private System.Windows.Forms.RadioButton compoundButton;
        private System.Windows.Forms.RadioButton simpleButton;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principalText;
        private System.Windows.Forms.TextBox rateText;
        private System.Windows.Forms.TextBox loanPeriodText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

