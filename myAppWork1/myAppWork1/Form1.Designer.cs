namespace myAppWork1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMemberCard = new System.Windows.Forms.Button();
            this.btnManag = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະບົບຫໍສະໝຸດ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoanBook.BackgroundImage")));
            this.btnLoanBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoanBook.Location = new System.Drawing.Point(65, 91);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(144, 116);
            this.btnLoanBook.TabIndex = 1;
            this.btnLoanBook.Text = "ບໍລິການຢືມປື້ມ";
            this.btnLoanBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoanBook.UseVisualStyleBackColor = true;
            this.btnLoanBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.Location = new System.Drawing.Point(288, 91);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 116);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "ສົ່ງປື້ມ";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(288, 222);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 116);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "ລາຍງານຢືມ/ສົ່ງ";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReprt_Click);
            // 
            // btnMemberCard
            // 
            this.btnMemberCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMemberCard.BackgroundImage")));
            this.btnMemberCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMemberCard.Location = new System.Drawing.Point(65, 222);
            this.btnMemberCard.Name = "btnMemberCard";
            this.btnMemberCard.Size = new System.Drawing.Size(144, 116);
            this.btnMemberCard.TabIndex = 3;
            this.btnMemberCard.Text = "ອອກບັດສະມາຊິກ";
            this.btnMemberCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberCard.UseVisualStyleBackColor = true;
            this.btnMemberCard.Click += new System.EventHandler(this.btnMemberCard_Click);
            // 
            // btnManag
            // 
            this.btnManag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManag.BackgroundImage")));
            this.btnManag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManag.Location = new System.Drawing.Point(288, 350);
            this.btnManag.Name = "btnManag";
            this.btnManag.Size = new System.Drawing.Size(144, 116);
            this.btnManag.TabIndex = 6;
            this.btnManag.Text = "ຈັດການຂໍ້ມູນ";
            this.btnManag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManag.UseVisualStyleBackColor = true;
            this.btnManag.Click += new System.EventHandler(this.btnManag_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBook.BackgroundImage")));
            this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddBook.Location = new System.Drawing.Point(65, 350);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(144, 116);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "ເພີ່ມປື້ມ";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 478);
            this.Controls.Add(this.btnManag);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMemberCard);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans Lao Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.Text = "ໜ້າຫຼັກ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMemberCard;
        private System.Windows.Forms.Button btnManag;
        private System.Windows.Forms.Button btnAddBook;
    }
}

