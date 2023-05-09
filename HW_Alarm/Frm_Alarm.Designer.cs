namespace HW_Alarm
{
    partial class Frm_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.timerForNow = new System.Windows.Forms.Timer(this.components);
            this.labTimeShow = new System.Windows.Forms.Label();
            this.grpBoxSelectTime = new System.Windows.Forms.GroupBox();
            this.chkBoxSet = new System.Windows.Forms.CheckBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerForChangeCol = new System.Windows.Forms.Timer(this.components);
            this.grpBoxSelectTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerForNow
            // 
            this.timerForNow.Enabled = true;
            this.timerForNow.Interval = 1000;
            this.timerForNow.Tick += new System.EventHandler(this.timerForNow_Tick);
            // 
            // labTimeShow
            // 
            this.labTimeShow.AutoSize = true;
            this.labTimeShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTimeShow.Location = new System.Drawing.Point(13, 18);
            this.labTimeShow.Name = "labTimeShow";
            this.labTimeShow.Size = new System.Drawing.Size(54, 20);
            this.labTimeShow.TabIndex = 0;
            this.labTimeShow.Text = "label1";
            // 
            // grpBoxSelectTime
            // 
            this.grpBoxSelectTime.Controls.Add(this.chkBoxSet);
            this.grpBoxSelectTime.Controls.Add(this.txtTime);
            this.grpBoxSelectTime.Controls.Add(this.labTitle);
            this.grpBoxSelectTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBoxSelectTime.Location = new System.Drawing.Point(93, 65);
            this.grpBoxSelectTime.Name = "grpBoxSelectTime";
            this.grpBoxSelectTime.Size = new System.Drawing.Size(342, 161);
            this.grpBoxSelectTime.TabIndex = 1;
            this.grpBoxSelectTime.TabStop = false;
            this.grpBoxSelectTime.Text = "Select Time";
            // 
            // chkBoxSet
            // 
            this.chkBoxSet.AutoSize = true;
            this.chkBoxSet.Location = new System.Drawing.Point(92, 115);
            this.chkBoxSet.Name = "chkBoxSet";
            this.chkBoxSet.Size = new System.Drawing.Size(101, 24);
            this.chkBoxSet.TabIndex = 2;
            this.chkBoxSet.Text = "Set Alarm";
            this.chkBoxSet.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(120, 71);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(144, 29);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "___ 時 ___ 分 ___ 秒";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(14, 75);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(111, 20);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Alarm Time：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 18);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerForChangeCol
            // 
            this.timerForChangeCol.Interval = 1000;
            this.timerForChangeCol.Tick += new System.EventHandler(this.timerForChangeCol_Tick);
            // 
            // Frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpBoxSelectTime);
            this.Controls.Add(this.labTimeShow);
            this.Name = "Frm_Alarm";
            this.Text = "Form Alarm";
            this.grpBoxSelectTime.ResumeLayout(false);
            this.grpBoxSelectTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerForNow;
        private System.Windows.Forms.Label labTimeShow;
        private System.Windows.Forms.GroupBox grpBoxSelectTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.CheckBox chkBoxSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerForChangeCol;
    }
}

