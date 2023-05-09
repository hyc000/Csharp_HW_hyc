namespace FrmHW_Hello
{
    partial class Frm_Hello1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hello1));
            this.labNameZh = new System.Windows.Forms.Label();
            this.labNameEn = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labStarSign = new System.Windows.Forms.Label();
            this.txtNameZh = new System.Windows.Forms.TextBox();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStarSign = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNameZh
            // 
            this.labNameZh.AutoSize = true;
            this.labNameZh.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameZh.Location = new System.Drawing.Point(25, 105);
            this.labNameZh.Name = "labNameZh";
            this.labNameZh.Size = new System.Drawing.Size(75, 26);
            this.labNameZh.TabIndex = 0;
            this.labNameZh.Text = "姓名：";
            // 
            // labNameEn
            // 
            this.labNameEn.AutoSize = true;
            this.labNameEn.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameEn.Location = new System.Drawing.Point(25, 148);
            this.labNameEn.Name = "labNameEn";
            this.labNameEn.Size = new System.Drawing.Size(173, 26);
            this.labNameEn.TabIndex = 1;
            this.labNameEn.Text = "English Name：";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(25, 195);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(75, 26);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "性別：";
            // 
            // labStarSign
            // 
            this.labStarSign.AutoSize = true;
            this.labStarSign.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStarSign.Location = new System.Drawing.Point(25, 242);
            this.labStarSign.Name = "labStarSign";
            this.labStarSign.Size = new System.Drawing.Size(75, 26);
            this.labStarSign.TabIndex = 3;
            this.labStarSign.Text = "星座：";
            // 
            // txtNameZh
            // 
            this.txtNameZh.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameZh.Location = new System.Drawing.Point(204, 96);
            this.txtNameZh.Name = "txtNameZh";
            this.txtNameZh.Size = new System.Drawing.Size(99, 35);
            this.txtNameZh.TabIndex = 4;
            // 
            // txtNameEn
            // 
            this.txtNameEn.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameEn.Location = new System.Drawing.Point(204, 148);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(99, 35);
            this.txtNameEn.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(204, 195);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(99, 35);
            this.txtGender.TabIndex = 6;
            // 
            // txtStarSign
            // 
            this.txtStarSign.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStarSign.Location = new System.Drawing.Point(204, 246);
            this.txtStarSign.Name = "txtStarSign";
            this.txtStarSign.Size = new System.Drawing.Size(99, 35);
            this.txtStarSign.TabIndex = 7;
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.White;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHello.Location = new System.Drawing.Point(11, 305);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(205, 95);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.White;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHi.Image")));
            this.btnSayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHi.Location = new System.Drawing.Point(276, 305);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(205, 95);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Frm_Hello1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtStarSign);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtNameEn);
            this.Controls.Add(this.txtNameZh);
            this.Controls.Add(this.labStarSign);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labNameEn);
            this.Controls.Add(this.labNameZh);
            this.DoubleBuffered = true;
            this.Name = "Frm_Hello1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNameZh;
        private System.Windows.Forms.Label labNameEn;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labStarSign;
        private System.Windows.Forms.TextBox txtNameZh;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStarSign;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
    }
}

