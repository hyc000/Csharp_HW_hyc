namespace HW_OneStudentScore
{
    partial class Frm_StructFrm
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
            this.labName = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.grpBoxScore = new System.Windows.Forms.GroupBox();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.labShowHighLow = new System.Windows.Forms.Label();
            this.labShowAll = new System.Windows.Forms.Label();
            this.grpBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(62, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCh.Location = new System.Drawing.Point(62, 98);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(67, 24);
            this.labCh.TabIndex = 1;
            this.labCh.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(62, 148);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(67, 24);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(62, 197);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(147, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCh.Location = new System.Drawing.Point(147, 93);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(100, 29);
            this.txtCh.TabIndex = 5;
            this.txtCh.Text = "0";
            this.txtCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(147, 143);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 29);
            this.txtEn.TabIndex = 6;
            this.txtEn.Text = "0";
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(147, 197);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 29);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(30, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(159, 277);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(122, 50);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grpBoxScore
            // 
            this.grpBoxScore.Controls.Add(this.btnHighLow);
            this.grpBoxScore.Controls.Add(this.labShowHighLow);
            this.grpBoxScore.Controls.Add(this.labShowAll);
            this.grpBoxScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBoxScore.Location = new System.Drawing.Point(335, 35);
            this.grpBoxScore.Name = "grpBoxScore";
            this.grpBoxScore.Size = new System.Drawing.Size(428, 370);
            this.grpBoxScore.TabIndex = 10;
            this.grpBoxScore.TabStop = false;
            this.grpBoxScore.Text = "成績";
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighLow.Location = new System.Drawing.Point(230, 314);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(176, 50);
            this.btnHighLow.TabIndex = 11;
            this.btnHighLow.Text = "最高分/最低分科目";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // labShowHighLow
            // 
            this.labShowHighLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowHighLow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowHighLow.Location = new System.Drawing.Point(16, 212);
            this.labShowHighLow.Name = "labShowHighLow";
            this.labShowHighLow.Size = new System.Drawing.Size(390, 92);
            this.labShowHighLow.TabIndex = 2;
            // 
            // labShowAll
            // 
            this.labShowAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowAll.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowAll.Location = new System.Drawing.Point(16, 25);
            this.labShowAll.Name = "labShowAll";
            this.labShowAll.Size = new System.Drawing.Size(390, 177);
            this.labShowAll.TabIndex = 1;
            // 
            // Frm_StructFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxScore);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.labName);
            this.Name = "Frm_StructFrm";
            this.Text = "Frm_StructForm";
            this.grpBoxScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox grpBoxScore;
        private System.Windows.Forms.Button btnHighLow;
        internal System.Windows.Forms.Label labShowHighLow;
        private System.Windows.Forms.Label labShowAll;
    }
}

