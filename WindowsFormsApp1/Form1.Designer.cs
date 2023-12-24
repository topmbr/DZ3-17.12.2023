namespace WindowsFormsApp1
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
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.listBoxResponses = new System.Windows.Forms.ListBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(230, 71);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(100, 22);
            this.txtRequest.TabIndex = 0;
            // 
            // listBoxResponses
            // 
            this.listBoxResponses.FormattingEnabled = true;
            this.listBoxResponses.ItemHeight = 16;
            this.listBoxResponses.Location = new System.Drawing.Point(430, 43);
            this.listBoxResponses.Name = "listBoxResponses";
            this.listBoxResponses.Size = new System.Drawing.Size(322, 148);
            this.listBoxResponses.TabIndex = 1;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(254, 248);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(211, 23);
            this.btnSendRequest.TabIndex = 2;
            this.btnSendRequest.Text = "відправлення запиту";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.listBoxResponses);
            this.Controls.Add(this.txtRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.ListBox listBoxResponses;
        private System.Windows.Forms.Button btnSendRequest;
    }
}

