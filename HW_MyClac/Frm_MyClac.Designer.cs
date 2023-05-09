namespace HW_MyClac
{
    partial class Frm_MyClac
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum2 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.labAns = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.labforline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(31, 37);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(94, 27);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1：";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(148, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(90, 35);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(148, 92);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(90, 35);
            this.txtNum2.TabIndex = 3;
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(31, 95);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(94, 27);
            this.labNum2.TabIndex = 2;
            this.labNum2.Text = "Num2：";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAns.Location = new System.Drawing.Point(148, 188);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(90, 35);
            this.txtAns.TabIndex = 5;
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.Location = new System.Drawing.Point(31, 191);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(107, 27);
            this.labAns.TabIndex = 4;
            this.labAns.Text = "Answer：";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(290, 30);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 41);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(380, 30);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 41);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivided
            // 
            this.btnDivided.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivided.Location = new System.Drawing.Point(380, 86);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(75, 41);
            this.btnDivided.TabIndex = 8;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiply.Location = new System.Drawing.Point(290, 88);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 41);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // labforline
            // 
            this.labforline.AutoSize = true;
            this.labforline.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labforline.Location = new System.Drawing.Point(32, 149);
            this.labforline.Name = "labforline";
            this.labforline.Size = new System.Drawing.Size(239, 19);
            this.labforline.TabIndex = 10;
            this.labforline.Text = "=======================";
            // 
            // Frm_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 235);
            this.Controls.Add(this.labforline);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labNum1);
            this.Name = "Frm_MyClac";
            this.Text = "計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label labforline;
    }
}

