namespace bai12_tinhSOchanle
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
            this.lblsodau = new System.Windows.Forms.Label();
            this.txbsodau = new System.Windows.Forms.TextBox();
            this.lblsocuoi = new System.Windows.Forms.Label();
            this.txbsocuoi = new System.Windows.Forms.TextBox();
            this.lbltongchan = new System.Windows.Forms.Label();
            this.btntongchan = new System.Windows.Forms.Button();
            this.lbltongle = new System.Windows.Forms.Label();
            this.btntongle = new System.Windows.Forms.Button();
            this.lbltatca = new System.Windows.Forms.Label();
            this.btntatca = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsodau
            // 
            this.lblsodau.AutoSize = true;
            this.lblsodau.Location = new System.Drawing.Point(72, 72);
            this.lblsodau.Name = "lblsodau";
            this.lblsodau.Size = new System.Drawing.Size(57, 20);
            this.lblsodau.TabIndex = 0;
            this.lblsodau.Text = "số đầu";
            // 
            // txbsodau
            // 
            this.txbsodau.Location = new System.Drawing.Point(167, 71);
            this.txbsodau.Name = "txbsodau";
            this.txbsodau.Size = new System.Drawing.Size(102, 26);
            this.txbsodau.TabIndex = 1;
            // 
            // lblsocuoi
            // 
            this.lblsocuoi.AutoSize = true;
            this.lblsocuoi.Location = new System.Drawing.Point(72, 134);
            this.lblsocuoi.Name = "lblsocuoi";
            this.lblsocuoi.Size = new System.Drawing.Size(59, 20);
            this.lblsocuoi.TabIndex = 0;
            this.lblsocuoi.Text = "số cuối";
            // 
            // txbsocuoi
            // 
            this.txbsocuoi.Location = new System.Drawing.Point(167, 133);
            this.txbsocuoi.Name = "txbsocuoi";
            this.txbsocuoi.Size = new System.Drawing.Size(102, 26);
            this.txbsocuoi.TabIndex = 1;
            // 
            // lbltongchan
            // 
            this.lbltongchan.AutoSize = true;
            this.lbltongchan.Location = new System.Drawing.Point(407, 71);
            this.lbltongchan.Name = "lbltongchan";
            this.lbltongchan.Size = new System.Drawing.Size(80, 20);
            this.lbltongchan.TabIndex = 2;
            this.lbltongchan.Text = "tổng chẵn";
            // 
            // btntongchan
            // 
            this.btntongchan.Location = new System.Drawing.Point(529, 68);
            this.btntongchan.Name = "btntongchan";
            this.btntongchan.Size = new System.Drawing.Size(75, 29);
            this.btntongchan.TabIndex = 3;
            this.btntongchan.UseVisualStyleBackColor = true;
            this.btntongchan.Click += new System.EventHandler(this.btntongchan_Click);
            // 
            // lbltongle
            // 
            this.lbltongle.AutoSize = true;
            this.lbltongle.Location = new System.Drawing.Point(407, 128);
            this.lbltongle.Name = "lbltongle";
            this.lbltongle.Size = new System.Drawing.Size(57, 20);
            this.lbltongle.TabIndex = 2;
            this.lbltongle.Text = "tổng lẻ";
            // 
            // btntongle
            // 
            this.btntongle.Location = new System.Drawing.Point(529, 125);
            this.btntongle.Name = "btntongle";
            this.btntongle.Size = new System.Drawing.Size(75, 29);
            this.btntongle.TabIndex = 3;
            this.btntongle.UseVisualStyleBackColor = true;
            // 
            // lbltatca
            // 
            this.lbltatca.AutoSize = true;
            this.lbltatca.Location = new System.Drawing.Point(407, 184);
            this.lbltatca.Name = "lbltatca";
            this.lbltatca.Size = new System.Drawing.Size(49, 20);
            this.lbltatca.TabIndex = 2;
            this.lbltatca.Text = "tất cả";
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(529, 181);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 29);
            this.btntatca.TabIndex = 3;
            this.btntatca.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(221, 292);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(307, 39);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btntatca);
            this.Controls.Add(this.lbltatca);
            this.Controls.Add(this.btntongle);
            this.Controls.Add(this.lbltongle);
            this.Controls.Add(this.btntongchan);
            this.Controls.Add(this.lbltongchan);
            this.Controls.Add(this.txbsocuoi);
            this.Controls.Add(this.lblsocuoi);
            this.Controls.Add(this.txbsodau);
            this.Controls.Add(this.lblsodau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsodau;
        private System.Windows.Forms.TextBox txbsodau;
        private System.Windows.Forms.Label lblsocuoi;
        private System.Windows.Forms.TextBox txbsocuoi;
        private System.Windows.Forms.Label lbltongchan;
        private System.Windows.Forms.Button btntongchan;
        private System.Windows.Forms.Label lbltongle;
        private System.Windows.Forms.Button btntongle;
        private System.Windows.Forms.Label lbltatca;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btntinh;
    }
}

