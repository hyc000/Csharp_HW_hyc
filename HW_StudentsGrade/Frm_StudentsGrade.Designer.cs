namespace HW_StudentsGrade
{
    partial class Frm_StudentsGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labStuName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddRandem = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRendom20 = new System.Windows.Forms.Button();
            this.txtShowTitle = new System.Windows.Forms.TextBox();
            this.labShowReport = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.txtShowAll = new System.Windows.Forms.TextBox();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(96, 167);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 29);
            this.txtMath.TabIndex = 15;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(96, 113);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 29);
            this.txtEn.TabIndex = 14;
            this.txtEn.Text = "0";
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCh.Location = new System.Drawing.Point(96, 63);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(100, 29);
            this.txtCh.TabIndex = 13;
            this.txtCh.Text = "0";
            this.txtCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStuName.Location = new System.Drawing.Point(96, 12);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 29);
            this.txtStuName.TabIndex = 12;
            this.txtStuName.Text = "0";
            this.txtStuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(11, 167);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 11;
            this.labMath.Text = "數學：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(11, 118);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(67, 24);
            this.labEn.TabIndex = 10;
            this.labEn.Text = "英文：";
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCh.Location = new System.Drawing.Point(11, 68);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(67, 24);
            this.labCh.TabIndex = 9;
            this.labCh.Text = "國文：";
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStuName.Location = new System.Drawing.Point(11, 12);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(67, 24);
            this.labStuName.TabIndex = 8;
            this.labStuName.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(25, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddRandem
            // 
            this.btnAddRandem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandem.Location = new System.Drawing.Point(25, 252);
            this.btnAddRandem.Name = "btnAddRandem";
            this.btnAddRandem.Size = new System.Drawing.Size(164, 34);
            this.btnAddRandem.TabIndex = 17;
            this.btnAddRandem.Text = "隨機儲存資料";
            this.btnAddRandem.UseVisualStyleBackColor = true;
            this.btnAddRandem.Click += new System.EventHandler(this.btnAddRandem_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(25, 292);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 34);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "各科統計";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(25, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 34);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRendom20
            // 
            this.btnRendom20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRendom20.Location = new System.Drawing.Point(25, 406);
            this.btnRendom20.Name = "btnRendom20";
            this.btnRendom20.Size = new System.Drawing.Size(164, 34);
            this.btnRendom20.TabIndex = 20;
            this.btnRendom20.Text = "隨機加入20筆";
            this.btnRendom20.UseVisualStyleBackColor = true;
            this.btnRendom20.Click += new System.EventHandler(this.btnRendom20_Click);
            // 
            // txtShowTitle
            // 
            this.txtShowTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtShowTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowTitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShowTitle.Location = new System.Drawing.Point(0, 2);
            this.txtShowTitle.Multiline = true;
            this.txtShowTitle.Name = "txtShowTitle";
            this.txtShowTitle.Size = new System.Drawing.Size(514, 27);
            this.txtShowTitle.TabIndex = 21;
            this.txtShowTitle.Text = "姓名\t國文\t英文\t數學\t總分\t平均\t最低\t最高";
            // 
            // labShowReport
            // 
            this.labShowReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowReport.Location = new System.Drawing.Point(238, 298);
            this.labShowReport.Name = "labShowReport";
            this.labShowReport.Size = new System.Drawing.Size(550, 134);
            this.labShowReport.TabIndex = 22;
            this.labShowReport.Text = "\r\n";
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShow.Controls.Add(this.txtShowAll);
            this.panelShow.Controls.Add(this.txtShowTitle);
            this.panelShow.Location = new System.Drawing.Point(238, 12);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(550, 274);
            this.panelShow.TabIndex = 23;
            // 
            // txtShowAll
            // 
            this.txtShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.txtShowAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowAll.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShowAll.Location = new System.Drawing.Point(0, 19);
            this.txtShowAll.Multiline = true;
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(514, 317);
            this.txtShowAll.TabIndex = 22;
            // 
            // Frm_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.labShowReport);
            this.Controls.Add(this.btnRendom20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAddRandem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.labStuName);
            this.Name = "Frm_StudentsGrade";
            this.Text = "StudentsGrade";
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddRandem;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRendom20;
        private System.Windows.Forms.TextBox txtShowTitle;
        private System.Windows.Forms.Label labShowReport;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.TextBox txtShowAll;
    }
}

