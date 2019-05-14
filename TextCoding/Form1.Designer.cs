namespace TextCoding
{
    partial class Form1
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
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.cbxToLowCase = new System.Windows.Forms.CheckBox();
            this.cbxDeleteDashes = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.textBoxMessage);
            this.groupBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMessage.Location = new System.Drawing.Point(12, 7);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(541, 57);
            this.groupBoxMessage.TabIndex = 0;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Исходное послание";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 23);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(524, 24);
            this.textBoxMessage.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.cbxToLowCase);
            this.groupBoxResult.Controls.Add(this.cbxDeleteDashes);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.Location = new System.Drawing.Point(12, 70);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(541, 102);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // cbxToLowCase
            // 
            this.cbxToLowCase.AutoSize = true;
            this.cbxToLowCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxToLowCase.Location = new System.Drawing.Point(356, 79);
            this.cbxToLowCase.Name = "cbxToLowCase";
            this.cbxToLowCase.Size = new System.Drawing.Size(174, 17);
            this.cbxToLowCase.TabIndex = 5;
            this.cbxToLowCase.Text = "Перевести в нижний регистр";
            this.cbxToLowCase.UseVisualStyleBackColor = true;
            this.cbxToLowCase.CheckedChanged += new System.EventHandler(this.checkBox_Click);
            // 
            // cbxDeleteDashes
            // 
            this.cbxDeleteDashes.AutoSize = true;
            this.cbxDeleteDashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDeleteDashes.Location = new System.Drawing.Point(356, 56);
            this.cbxDeleteDashes.Name = "cbxDeleteDashes";
            this.cbxDeleteDashes.Size = new System.Drawing.Size(137, 17);
            this.cbxDeleteDashes.TabIndex = 4;
            this.cbxDeleteDashes.Text = "Удалить разделители";
            this.cbxDeleteDashes.UseVisualStyleBackColor = true;
            this.cbxDeleteDashes.CheckedChanged += new System.EventHandler(this.checkBox_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 23);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(524, 24);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(12, 178);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(541, 36);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Получить хэш";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 224);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2 Алгоритм безопасного хэширования (Secure Hash Algorithm, S" +
    "HA)";
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.CheckBox cbxToLowCase;
        private System.Windows.Forms.CheckBox cbxDeleteDashes;
    }
}

