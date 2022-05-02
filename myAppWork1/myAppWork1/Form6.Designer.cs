namespace myAppWork1
{
    partial class frmManagment
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
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnManagMem = new System.Windows.Forms.Button();
            this.btnManagBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.Location = new System.Drawing.Point(27, 96);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(171, 42);
            this.btnManageEmp.TabIndex = 0;
            this.btnManageEmp.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            // 
            // btnManagMem
            // 
            this.btnManagMem.Location = new System.Drawing.Point(27, 161);
            this.btnManagMem.Name = "btnManagMem";
            this.btnManagMem.Size = new System.Drawing.Size(171, 42);
            this.btnManagMem.TabIndex = 1;
            this.btnManagMem.Text = "ຈັດການຂໍ້ມູນສະມາຊິກ";
            this.btnManagMem.UseVisualStyleBackColor = true;
            // 
            // btnManagBook
            // 
            this.btnManagBook.Location = new System.Drawing.Point(27, 227);
            this.btnManagBook.Name = "btnManagBook";
            this.btnManagBook.Size = new System.Drawing.Size(171, 42);
            this.btnManagBook.TabIndex = 2;
            this.btnManagBook.Text = "ຈັດການຂໍ້ມູນປື້ມ";
            this.btnManagBook.UseVisualStyleBackColor = true;
            // 
            // frmManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 387);
            this.Controls.Add(this.btnManagBook);
            this.Controls.Add(this.btnManagMem);
            this.Controls.Add(this.btnManageEmp);
            this.Font = new System.Drawing.Font("Noto Sans Lao Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmManagment";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnManagMem;
        private System.Windows.Forms.Button btnManagBook;
    }
}