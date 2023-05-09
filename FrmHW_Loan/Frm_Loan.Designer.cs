namespace FrmHW_Loan
{
    partial class Frm_Loan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnPMT = new System.Windows.Forms.Button();
            this.txtFirstPay = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtLoanNum = new System.Windows.Forms.TextBox();
            this.labFirstPay = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labPeriod = new System.Windows.Forms.Label();
            this.labLoanNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(559, 307);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(146, 53);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(330, 307);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(146, 53);
            this.btnTotal.TabIndex = 20;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(95, 307);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(146, 53);
            this.btnPMT.TabIndex = 19;
            this.btnPMT.Text = "PMT(月付額)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // txtFirstPay
            // 
            this.txtFirstPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstPay.Location = new System.Drawing.Point(240, 213);
            this.txtFirstPay.Name = "txtFirstPay";
            this.txtFirstPay.Size = new System.Drawing.Size(100, 35);
            this.txtFirstPay.TabIndex = 18;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(240, 172);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 35);
            this.txtRate.TabIndex = 17;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPeriod.Location = new System.Drawing.Point(240, 131);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 35);
            this.txtPeriod.TabIndex = 16;
            // 
            // txtLoanNum
            // 
            this.txtLoanNum.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanNum.Location = new System.Drawing.Point(240, 90);
            this.txtLoanNum.Name = "txtLoanNum";
            this.txtLoanNum.Size = new System.Drawing.Size(100, 35);
            this.txtLoanNum.TabIndex = 15;
            // 
            // labFirstPay
            // 
            this.labFirstPay.AutoSize = true;
            this.labFirstPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirstPay.Location = new System.Drawing.Point(107, 213);
            this.labFirstPay.Name = "labFirstPay";
            this.labFirstPay.Size = new System.Drawing.Size(75, 26);
            this.labFirstPay.TabIndex = 14;
            this.labFirstPay.Text = "頭期款";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(107, 172);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(87, 26);
            this.labRate.TabIndex = 13;
            this.labRate.Text = "利率(%)";
            // 
            // labPeriod
            // 
            this.labPeriod.AutoSize = true;
            this.labPeriod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriod.Location = new System.Drawing.Point(107, 131);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(89, 26);
            this.labPeriod.TabIndex = 12;
            this.labPeriod.Text = "期限(年)";
            // 
            // labLoanNum
            // 
            this.labLoanNum.AutoSize = true;
            this.labLoanNum.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanNum.Location = new System.Drawing.Point(107, 90);
            this.labLoanNum.Name = "labLoanNum";
            this.labLoanNum.Size = new System.Drawing.Size(96, 26);
            this.labLoanNum.TabIndex = 11;
            this.labLoanNum.Text = "貸款金額";
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtFirstPay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtLoanNum);
            this.Controls.Add(this.labFirstPay);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.labLoanNum);
            this.Name = "Frm_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnPMT;
        internal System.Windows.Forms.TextBox txtFirstPay;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox txtPeriod;
        internal System.Windows.Forms.TextBox txtLoanNum;
        private System.Windows.Forms.Label labFirstPay;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.Label labLoanNum;
    }
}

