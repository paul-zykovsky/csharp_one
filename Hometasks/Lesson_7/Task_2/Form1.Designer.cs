namespace Task_2
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblAttemptsTitle = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblCondTitle = new System.Windows.Forms.Label();
            this.lblCond = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumberTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(458, 116);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 86);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "button1";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAttemptsTitle
            // 
            this.lblAttemptsTitle.AutoSize = true;
            this.lblAttemptsTitle.Location = new System.Drawing.Point(226, 116);
            this.lblAttemptsTitle.Name = "lblAttemptsTitle";
            this.lblAttemptsTitle.Size = new System.Drawing.Size(46, 17);
            this.lblAttemptsTitle.TabIndex = 1;
            this.lblAttemptsTitle.Text = "label1";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(226, 185);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(46, 17);
            this.lblAttempts.TabIndex = 2;
            this.lblAttempts.Text = "label2";
            // 
            // lblCondTitle
            // 
            this.lblCondTitle.AutoSize = true;
            this.lblCondTitle.Location = new System.Drawing.Point(131, 115);
            this.lblCondTitle.Name = "lblCondTitle";
            this.lblCondTitle.Size = new System.Drawing.Size(46, 17);
            this.lblCondTitle.TabIndex = 3;
            this.lblCondTitle.Text = "label1";
            // 
            // lblCond
            // 
            this.lblCond.AutoSize = true;
            this.lblCond.Location = new System.Drawing.Point(131, 185);
            this.lblCond.Name = "lblCond";
            this.lblCond.Size = new System.Drawing.Size(46, 17);
            this.lblCond.TabIndex = 4;
            this.lblCond.Text = "label1";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(352, 182);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumberTitle
            // 
            this.lblNumberTitle.AutoSize = true;
            this.lblNumberTitle.Location = new System.Drawing.Point(354, 116);
            this.lblNumberTitle.Name = "lblNumberTitle";
            this.lblNumberTitle.Size = new System.Drawing.Size(46, 17);
            this.lblNumberTitle.TabIndex = 6;
            this.lblNumberTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberTitle);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblCond);
            this.Controls.Add(this.lblCondTitle);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblAttemptsTitle);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblAttemptsTitle;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblCondTitle;
        private System.Windows.Forms.Label lblCond;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumberTitle;
    }
}

