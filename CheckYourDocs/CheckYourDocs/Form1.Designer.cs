namespace CheckYourDocs
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
            this.startBT = new System.Windows.Forms.Button();
            this.htmlTB = new System.Windows.Forms.TextBox();
            this.wordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(402, 394);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(231, 23);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "Check it before I wreck it";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click_1);
            // 
            // htmlTB
            // 
            this.htmlTB.Location = new System.Drawing.Point(25, 12);
            this.htmlTB.Multiline = true;
            this.htmlTB.Name = "htmlTB";
            this.htmlTB.Size = new System.Drawing.Size(382, 245);
            this.htmlTB.TabIndex = 1;
            // 
            // wordTB
            // 
            this.wordTB.Location = new System.Drawing.Point(434, 12);
            this.wordTB.Multiline = true;
            this.wordTB.Name = "wordTB";
            this.wordTB.Size = new System.Drawing.Size(354, 245);
            this.wordTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordTB);
            this.Controls.Add(this.htmlTB);
            this.Controls.Add(this.startBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.TextBox htmlTB;
        private System.Windows.Forms.TextBox wordTB;
    }
}

