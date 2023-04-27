namespace Bai8
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnAddRootNode = new System.Windows.Forms.Button();
            this.btnAddChildNode = new System.Windows.Forms.Button();
            this.btnDeleteAllNode = new System.Windows.Forms.Button();
            this.btnDeleteSelectedNode = new System.Windows.Forms.Button();
            this.btnCountNode = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(34, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(269, 330);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề node";
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(414, 58);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(257, 20);
            this.txtNode.TabIndex = 2;
            // 
            // btnAddRootNode
            // 
            this.btnAddRootNode.Location = new System.Drawing.Point(340, 95);
            this.btnAddRootNode.Name = "btnAddRootNode";
            this.btnAddRootNode.Size = new System.Drawing.Size(331, 38);
            this.btnAddRootNode.TabIndex = 3;
            this.btnAddRootNode.Text = "Thêm node gốc";
            this.btnAddRootNode.UseVisualStyleBackColor = true;
            this.btnAddRootNode.Click += new System.EventHandler(this.btnAddRootNode_Click);
            // 
            // btnAddChildNode
            // 
            this.btnAddChildNode.Location = new System.Drawing.Point(340, 139);
            this.btnAddChildNode.Name = "btnAddChildNode";
            this.btnAddChildNode.Size = new System.Drawing.Size(331, 38);
            this.btnAddChildNode.TabIndex = 4;
            this.btnAddChildNode.Text = "Thêm Node con";
            this.btnAddChildNode.UseVisualStyleBackColor = true;
            this.btnAddChildNode.Click += new System.EventHandler(this.btnAddChildNode_Click);
            // 
            // btnDeleteAllNode
            // 
            this.btnDeleteAllNode.Location = new System.Drawing.Point(340, 183);
            this.btnDeleteAllNode.Name = "btnDeleteAllNode";
            this.btnDeleteAllNode.Size = new System.Drawing.Size(331, 38);
            this.btnDeleteAllNode.TabIndex = 5;
            this.btnDeleteAllNode.Text = "Xóa tất cả dạng Node";
            this.btnDeleteAllNode.UseVisualStyleBackColor = true;
            this.btnDeleteAllNode.Click += new System.EventHandler(this.btnDeleteAllNode_Click);
            // 
            // btnDeleteSelectedNode
            // 
            this.btnDeleteSelectedNode.Location = new System.Drawing.Point(340, 227);
            this.btnDeleteSelectedNode.Name = "btnDeleteSelectedNode";
            this.btnDeleteSelectedNode.Size = new System.Drawing.Size(331, 38);
            this.btnDeleteSelectedNode.TabIndex = 6;
            this.btnDeleteSelectedNode.Text = "Xóa Node dang chọn";
            this.btnDeleteSelectedNode.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedNode.Click += new System.EventHandler(this.btnDeleteSelectedNode_Click);
            // 
            // btnCountNode
            // 
            this.btnCountNode.Location = new System.Drawing.Point(340, 271);
            this.btnCountNode.Name = "btnCountNode";
            this.btnCountNode.Size = new System.Drawing.Size(331, 38);
            this.btnCountNode.TabIndex = 7;
            this.btnCountNode.Text = "Đếm tổng node treeview";
            this.btnCountNode.UseVisualStyleBackColor = true;
            this.btnCountNode.Click += new System.EventHandler(this.btnCountNode_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(623, 353);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(48, 38);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tree View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCountNode);
            this.Controls.Add(this.btnDeleteSelectedNode);
            this.Controls.Add(this.btnDeleteAllNode);
            this.Controls.Add(this.btnAddChildNode);
            this.Controls.Add(this.btnAddRootNode);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnAddRootNode;
        private System.Windows.Forms.Button btnAddChildNode;
        private System.Windows.Forms.Button btnDeleteAllNode;
        private System.Windows.Forms.Button btnDeleteSelectedNode;
        private System.Windows.Forms.Button btnCountNode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label label2;
    }
}

