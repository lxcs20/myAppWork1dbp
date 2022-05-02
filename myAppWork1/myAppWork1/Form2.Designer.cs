namespace myAppWork1
{
    partial class frmLoanBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanBook));
            this.label1 = new System.Windows.Forms.Label();
            this.labBorID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labBookID = new System.Windows.Forms.Label();
            this.txtBorID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 0;
            // 
            // labBorID
            // 
            this.labBorID.AutoSize = true;
            this.labBorID.Location = new System.Drawing.Point(45, 38);
            this.labBorID.Name = "labBorID";
            this.labBorID.Size = new System.Drawing.Size(104, 31);
            this.labBorID.TabIndex = 1;
            this.labBorID.Text = "ລະຫັດຜູ້ຢືມ";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(45, 83);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(151, 31);
            this.labName.TabIndex = 2;
            this.labName.Text = "ຊື່ ແລະ ນາມສະກຸນ";
            this.labName.Click += new System.EventHandler(this.label3_Click);
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(45, 128);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(89, 31);
            this.labBookID.TabIndex = 3;
            this.labBookID.Text = "ລະຫັດປື້ມ";
            // 
            // txtBorID
            // 
            this.txtBorID.Location = new System.Drawing.Point(202, 35);
            this.txtBorID.Name = "txtBorID";
            this.txtBorID.Size = new System.Drawing.Size(178, 39);
            this.txtBorID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 39);
            this.txtName.TabIndex = 5;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(202, 125);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(178, 39);
            this.txtBookID.TabIndex = 6;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(287, 208);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(93, 35);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "ເພີ່ມ";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "ຢຶນຢັນການຢືມ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBorID);
            this.Controls.Add(this.labBookID);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labBorID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans Lao Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmLoanBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ບໍລິການຢືມປື້ມ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labBorID;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.TextBox txtBorID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button button1;
    }
}