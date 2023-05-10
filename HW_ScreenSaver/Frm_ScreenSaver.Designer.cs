namespace HW_ScreenSaver
{
    partial class Frm_ScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ScreenSaver));
            this.picPika = new System.Windows.Forms.PictureBox();
            this.timerGo = new System.Windows.Forms.Timer(this.components);
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPika)).BeginInit();
            this.SuspendLayout();
            // 
            // picPika
            // 
            this.picPika.Image = ((System.Drawing.Image)(resources.GetObject("picPika.Image")));
            this.picPika.Location = new System.Drawing.Point(12, 12);
            this.picPika.Name = "picPika";
            this.picPika.Size = new System.Drawing.Size(199, 200);
            this.picPika.TabIndex = 0;
            this.picPika.TabStop = false;
            // 
            // timerGo
            // 
            this.timerGo.Tick += new System.EventHandler(this.timerGo_Tick);
            // 
            // timerEnd
            // 
            this.timerEnd.Tick += new System.EventHandler(this.timerEnd_Tick);
            // 
            // Frm_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPika);
            this.Name = "Frm_ScreenSaver";
            this.Text = "Frm_ScreenSaver";
            this.Load += new System.EventHandler(this.Frm_ScreenSaver_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPika;
        private System.Windows.Forms.Timer timerGo;
        private System.Windows.Forms.Timer timerEnd;
    }
}

