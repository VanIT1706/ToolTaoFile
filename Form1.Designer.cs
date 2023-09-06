namespace slide22._1_tạo_thư_mục_và_file_hàng_loạt
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
            this.lblNhapDuongDan = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoFile = new System.Windows.Forms.Button();
            this.btnTaoThuMuc = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapDuongDan
            // 
            this.lblNhapDuongDan.AutoSize = true;
            this.lblNhapDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapDuongDan.Location = new System.Drawing.Point(17, 94);
            this.lblNhapDuongDan.Name = "lblNhapDuongDan";
            this.lblNhapDuongDan.Size = new System.Drawing.Size(130, 20);
            this.lblNhapDuongDan.TabIndex = 0;
            this.lblNhapDuongDan.Text = "Nhập đường dẫn";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPath.Location = new System.Drawing.Point(18, 115);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(354, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(378, 109);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(90, 32);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lượng tệp,thư mục cần tạo:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(21, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(351, 22);
            this.txtSoLuong.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Thoát);
            this.groupBox1.Controls.Add(this.btnTaoThuMuc);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.btnTaoFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.lblNhapDuongDan);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 248);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnTaoFile
            // 
            this.btnTaoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoFile.Location = new System.Drawing.Point(188, 162);
            this.btnTaoFile.Name = "btnTaoFile";
            this.btnTaoFile.Size = new System.Drawing.Size(89, 62);
            this.btnTaoFile.TabIndex = 2;
            this.btnTaoFile.Text = "Tạo file";
            this.btnTaoFile.UseVisualStyleBackColor = false;
            this.btnTaoFile.Click += new System.EventHandler(this.btnTaoFile_Click);
            // 
            // btnTaoThuMuc
            // 
            this.btnTaoThuMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaoThuMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoThuMuc.Location = new System.Drawing.Point(283, 162);
            this.btnTaoThuMuc.Name = "btnTaoThuMuc";
            this.btnTaoThuMuc.Size = new System.Drawing.Size(89, 62);
            this.btnTaoThuMuc.TabIndex = 3;
            this.btnTaoThuMuc.Text = "Tạo thư mục";
            this.btnTaoThuMuc.UseVisualStyleBackColor = false;
            this.btnTaoThuMuc.Click += new System.EventHandler(this.btnTaoThuMuc_Click);
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.Location = new System.Drawing.Point(379, 162);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(89, 62);
            this.Thoát.TabIndex = 9;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = false;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(513, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo thư mục và file hàng loạt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhapDuongDan;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button btnTaoThuMuc;
        private System.Windows.Forms.Button btnTaoFile;
    }
}

