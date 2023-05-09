namespace HW_POS
{
    partial class Frm_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_POS));
            this.labMenu = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labTotalShow = new System.Windows.Forms.Label();
            this.labCountWay = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.labdiscount = new System.Windows.Forms.Label();
            this.labShopList = new System.Windows.Forms.Label();
            this.labShowShopList = new System.Windows.Forms.Label();
            this.btnAllDel = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWiskey = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(14, 62);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(256, 309);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Meun";
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(276, 62);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(224, 118);
            this.labTotal.TabIndex = 1;
            this.labTotal.Text = "菜單 Meun";
            // 
            // labTotalShow
            // 
            this.labTotalShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotalShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotalShow.Location = new System.Drawing.Point(302, 114);
            this.labTotalShow.Name = "labTotalShow";
            this.labTotalShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labTotalShow.Size = new System.Drawing.Size(182, 38);
            this.labTotalShow.TabIndex = 2;
            this.labTotalShow.Text = "NT$ 0";
            this.labTotalShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labCountWay
            // 
            this.labCountWay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCountWay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCountWay.Location = new System.Drawing.Point(276, 196);
            this.labCountWay.Name = "labCountWay";
            this.labCountWay.Size = new System.Drawing.Size(224, 118);
            this.labCountWay.TabIndex = 3;
            this.labCountWay.Text = "付款方式";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(284, 229);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(105, 39);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.Location = new System.Drawing.Point(395, 229);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(105, 39);
            this.btnCreditCard.TabIndex = 5;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // labdiscount
            // 
            this.labdiscount.AutoSize = true;
            this.labdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labdiscount.Cursor = System.Windows.Forms.Cursors.Default;
            this.labdiscount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labdiscount.Location = new System.Drawing.Point(328, 271);
            this.labdiscount.Name = "labdiscount";
            this.labdiscount.Size = new System.Drawing.Size(162, 26);
            this.labdiscount.TabIndex = 6;
            this.labdiscount.Text = "信用卡有9折優惠!";
            // 
            // labShopList
            // 
            this.labShopList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShopList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShopList.Location = new System.Drawing.Point(506, 62);
            this.labShopList.Name = "labShopList";
            this.labShopList.Size = new System.Drawing.Size(282, 309);
            this.labShopList.TabIndex = 7;
            this.labShopList.Text = "購物清單List";
            // 
            // labShowShopList
            // 
            this.labShowShopList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labShowShopList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowShopList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowShopList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowShopList.Location = new System.Drawing.Point(517, 101);
            this.labShowShopList.Name = "labShowShopList";
            this.labShowShopList.Size = new System.Drawing.Size(259, 213);
            this.labShowShopList.TabIndex = 8;
            this.labShowShopList.Text = "尚未購買";
            this.labShowShopList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAllDel
            // 
            this.btnAllDel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllDel.Location = new System.Drawing.Point(671, 317);
            this.btnAllDel.Name = "btnAllDel";
            this.btnAllDel.Size = new System.Drawing.Size(105, 39);
            this.btnAllDel.TabIndex = 9;
            this.btnAllDel.Text = "全部清除";
            this.btnAllDel.UseVisualStyleBackColor = true;
            this.btnAllDel.Click += new System.EventHandler(this.btnAllDel_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Image = ((System.Drawing.Image)(resources.GetObject("btnBeer.Image")));
            this.btnBeer.Location = new System.Drawing.Point(27, 114);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(104, 115);
            this.btnBeer.TabIndex = 10;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Image = ((System.Drawing.Image)(resources.GetObject("btnTequila.Image")));
            this.btnTequila.Location = new System.Drawing.Point(147, 114);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(104, 115);
            this.btnTequila.TabIndex = 11;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWiskey
            // 
            this.btnWiskey.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWiskey.Image = ((System.Drawing.Image)(resources.GetObject("btnWiskey.Image")));
            this.btnWiskey.Location = new System.Drawing.Point(27, 235);
            this.btnWiskey.Name = "btnWiskey";
            this.btnWiskey.Size = new System.Drawing.Size(104, 115);
            this.btnWiskey.TabIndex = 12;
            this.btnWiskey.Text = "威士忌\r\nWiskey\r\nNT350";
            this.btnWiskey.UseMnemonic = false;
            this.btnWiskey.UseVisualStyleBackColor = true;
            this.btnWiskey.Click += new System.EventHandler(this.btnWiskey_Click);
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Image = ((System.Drawing.Image)(resources.GetObject("btnWine.Image")));
            this.btnWine.Location = new System.Drawing.Point(147, 235);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(104, 115);
            this.btnWine.TabIndex = 13;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // Frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnWiskey);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.btnAllDel);
            this.Controls.Add(this.labShowShopList);
            this.Controls.Add(this.labShopList);
            this.Controls.Add(this.labdiscount);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labCountWay);
            this.Controls.Add(this.labTotalShow);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMenu);
            this.Name = "Frm_POS";
            this.Text = "Bar POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labTotalShow;
        private System.Windows.Forms.Label labCountWay;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Label labdiscount;
        private System.Windows.Forms.Label labShopList;
        private System.Windows.Forms.Label labShowShopList;
        private System.Windows.Forms.Button btnAllDel;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWiskey;
        private System.Windows.Forms.Button btnWine;
    }
}

