namespace Home_Library
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfoPage = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnHomeLibraryPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(521, 459);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(346, 63);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Вхід до біліотеки";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 126);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home Library:\r\nВаша домашня бібліотка, куди ви можете \r\nзавантажувати свої електр" +
    "оні книги.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnInfoPage);
            this.panel1.Controls.Add(this.btnMainPage);
            this.panel1.Controls.Add(this.btnHomeLibraryPage);
            this.panel1.Location = new System.Drawing.Point(-51, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 65);
            this.panel1.TabIndex = 4;
            // 
            // btnInfoPage
            // 
            this.btnInfoPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfoPage.Location = new System.Drawing.Point(411, 27);
            this.btnInfoPage.Name = "btnInfoPage";
            this.btnInfoPage.Size = new System.Drawing.Size(172, 29);
            this.btnInfoPage.TabIndex = 18;
            this.btnInfoPage.Text = "Інформація";
            this.btnInfoPage.UseVisualStyleBackColor = true;
            this.btnInfoPage.Click += new System.EventHandler(this.btnInfoPage_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainPage.Location = new System.Drawing.Point(63, 27);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(164, 29);
            this.btnMainPage.TabIndex = 16;
            this.btnMainPage.Text = "Головна";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnHomeLibraryPage
            // 
            this.btnHomeLibraryPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHomeLibraryPage.Location = new System.Drawing.Point(233, 27);
            this.btnHomeLibraryPage.Name = "btnHomeLibraryPage";
            this.btnHomeLibraryPage.Size = new System.Drawing.Size(172, 29);
            this.btnHomeLibraryPage.TabIndex = 17;
            this.btnHomeLibraryPage.Text = "Домашня бібліотека";
            this.btnHomeLibraryPage.UseVisualStyleBackColor = true;
            this.btnHomeLibraryPage.Click += new System.EventHandler(this.btnHomeLibraryPage_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Home_Library.Properties.Resources.essential_books;
            this.ClientSize = new System.Drawing.Size(895, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(913, 596);
            this.Name = "fMain";
            this.Text = "Home Library";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfoPage;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnHomeLibraryPage;
    }
}

