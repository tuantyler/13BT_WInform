namespace Bai4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnterInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountKhaiBao = new System.Windows.Forms.TextBox();
            this.btnDeleteCurrentSelect = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khai báo y tế điện tử";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(101, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 31);
            this.txtName.TabIndex = 2;
            // 
            // btnEnterInfo
            // 
            this.btnEnterInfo.Location = new System.Drawing.Point(101, 155);
            this.btnEnterInfo.Name = "btnEnterInfo";
            this.btnEnterInfo.Size = new System.Drawing.Size(106, 23);
            this.btnEnterInfo.TabIndex = 3;
            this.btnEnterInfo.Text = "Nhập thông tin";
            this.btnEnterInfo.UseVisualStyleBackColor = true;
            this.btnEnterInfo.Click += new System.EventHandler(this.btnEnterInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(399, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 147);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số người đã khai báo";
            // 
            // txtCountKhaiBao
            // 
            this.txtCountKhaiBao.Enabled = false;
            this.txtCountKhaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountKhaiBao.Location = new System.Drawing.Point(540, 296);
            this.txtCountKhaiBao.Name = "txtCountKhaiBao";
            this.txtCountKhaiBao.Size = new System.Drawing.Size(108, 31);
            this.txtCountKhaiBao.TabIndex = 6;
            // 
            // btnDeleteCurrentSelect
            // 
            this.btnDeleteCurrentSelect.Location = new System.Drawing.Point(402, 340);
            this.btnDeleteCurrentSelect.Name = "btnDeleteCurrentSelect";
            this.btnDeleteCurrentSelect.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteCurrentSelect.TabIndex = 7;
            this.btnDeleteCurrentSelect.Text = "Xóa thông tin đang chọn";
            this.btnDeleteCurrentSelect.UseVisualStyleBackColor = true;
            this.btnDeleteCurrentSelect.Click += new System.EventHandler(this.btnDeleteCurrentSelect_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Location = new System.Drawing.Point(574, 340);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteFirst.TabIndex = 8;
            this.btnDeleteFirst.Text = "Xóa thông tin đầu";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(574, 369);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteLast.TabIndex = 9;
            this.btnDeleteLast.Text = "Xóa thông tin cuối";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(402, 369);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteAll.TabIndex = 10;
            this.btnDeleteAll.Text = "Xóa tất cả thông tin";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.btnDeleteCurrentSelect);
            this.Controls.Add(this.txtCountKhaiBao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnterInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnterInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountKhaiBao;
        private System.Windows.Forms.Button btnDeleteCurrentSelect;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

