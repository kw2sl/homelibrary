namespace HomeLibrary.Properties
{
    partial class fInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInfo));
            this.btnInfoPage = new System.Windows.Forms.Button();
            this.btnHomeLibraryPage = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.MainLable = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInfoPage
            // 
            this.btnInfoPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfoPage.Location = new System.Drawing.Point(360, 12);
            this.btnInfoPage.Name = "btnInfoPage";
            this.btnInfoPage.Size = new System.Drawing.Size(172, 29);
            this.btnInfoPage.TabIndex = 29;
            this.btnInfoPage.Text = "Інформація";
            this.btnInfoPage.UseVisualStyleBackColor = true;
            // 
            // btnHomeLibraryPage
            // 
            this.btnHomeLibraryPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHomeLibraryPage.Location = new System.Drawing.Point(182, 12);
            this.btnHomeLibraryPage.Name = "btnHomeLibraryPage";
            this.btnHomeLibraryPage.Size = new System.Drawing.Size(172, 29);
            this.btnHomeLibraryPage.TabIndex = 28;
            this.btnHomeLibraryPage.Text = "Домашня бібліотека";
            this.btnHomeLibraryPage.UseVisualStyleBackColor = true;
            this.btnHomeLibraryPage.Click += new System.EventHandler(this.btnHomeLibraryPage_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainPage.Location = new System.Drawing.Point(12, 12);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(164, 29);
            this.btnMainPage.TabIndex = 27;
            this.btnMainPage.Text = "Головна";
            this.btnMainPage.UseVisualStyleBackColor = true;
            // 
            // MainLable
            // 
            this.MainLable.AutoSize = true;
            this.MainLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLable.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLable.Location = new System.Drawing.Point(31, 86);
            this.MainLable.Name = "MainLable";
            this.MainLable.Size = new System.Drawing.Size(685, 226);
            this.MainLable.TabIndex = 30;
            this.MainLable.Text = resources.GetString("MainLable.Text");
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(840, 477);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(211, 60);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 142);
            this.label1.TabIndex = 32;
            this.label1.Text = "КОНТАКТИ РОЗРОБНИКА:\r\n- Номер телефону: +38(093)733-13-00\r\n- Gmail: irinasavcuk85" +
    "5@gmail.com\r\n- Telegram: @nthn1l";
            // 
            // fInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MainLable);
            this.Controls.Add(this.btnInfoPage);
            this.Controls.Add(this.btnHomeLibraryPage);
            this.Controls.Add(this.btnMainPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1081, 596);
            this.Name = "fInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfoPage;
        private System.Windows.Forms.Button btnHomeLibraryPage;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Label MainLable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}