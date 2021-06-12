namespace GUI_QuanLy.RoomType
{
    partial class RoomTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeForm));
            this.imgAddRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomTypeHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomTypePrice = new DevExpress.XtraEditors.LabelControl();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomTypePrice = new System.Windows.Forms.TextBox();
            this.lbCurrencyUnit = new System.Windows.Forms.Label();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imgAddRoomType
            // 
            this.imgAddRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgAddRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgAddRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgAddRoomType.Appearance.Image")));
            this.imgAddRoomType.Appearance.Options.UseFont = true;
            this.imgAddRoomType.Appearance.Options.UseImage = true;
            this.imgAddRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgAddRoomType.ImageOptions.Image")));
            this.imgAddRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgAddRoomType.Location = new System.Drawing.Point(65, 34);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(32, 32);
            this.imgAddRoomType.TabIndex = 60;
            // 
            // lbRoomTypeHeader
            // 
            this.lbRoomTypeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomTypeHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomTypeHeader.Appearance.Options.UseFont = true;
            this.lbRoomTypeHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypeHeader.Location = new System.Drawing.Point(110, 42);
            this.lbRoomTypeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomTypeHeader.Name = "lbRoomTypeHeader";
            this.lbRoomTypeHeader.Size = new System.Drawing.Size(356, 24);
            this.lbRoomTypeHeader.TabIndex = 61;
            this.lbRoomTypeHeader.Text = "THAY ĐỔI THÔNG TIN LOẠI PHÒNG";
            // 
            // lbRoomType
            // 
            this.lbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomType.Appearance.Options.UseFont = true;
            this.lbRoomType.Appearance.Options.UseTextOptions = true;
            this.lbRoomType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomType.Location = new System.Drawing.Point(147, 97);
            this.lbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbRoomType.TabIndex = 62;
            this.lbRoomType.Text = "LOẠI PHÒNG:";
            // 
            // lbRoomTypePrice
            // 
            this.lbRoomTypePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomTypePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomTypePrice.Appearance.Options.UseFont = true;
            this.lbRoomTypePrice.Appearance.Options.UseTextOptions = true;
            this.lbRoomTypePrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomTypePrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypePrice.Location = new System.Drawing.Point(165, 136);
            this.lbRoomTypePrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomTypePrice.Name = "lbRoomTypePrice";
            this.lbRoomTypePrice.Size = new System.Drawing.Size(48, 13);
            this.lbRoomTypePrice.TabIndex = 63;
            this.lbRoomTypePrice.Text = "ĐƠN GIÁ:";
            // 
            // tbRoomType
            // 
            this.tbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomType.Location = new System.Drawing.Point(217, 94);
            this.tbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomType.MaxLength = 10;
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(134, 20);
            this.tbRoomType.TabIndex = 64;
            // 
            // tbRoomTypePrice
            // 
            this.tbRoomTypePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomTypePrice.Location = new System.Drawing.Point(217, 133);
            this.tbRoomTypePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomTypePrice.MaxLength = 10;
            this.tbRoomTypePrice.Name = "tbRoomTypePrice";
            this.tbRoomTypePrice.Size = new System.Drawing.Size(134, 20);
            this.tbRoomTypePrice.TabIndex = 65;
            this.tbRoomTypePrice.TextChanged += new System.EventHandler(this.TbRoomTypePrice_TextChanged);
            this.tbRoomTypePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRoomTypePrice_KeyPress);
            // 
            // lbCurrencyUnit
            // 
            this.lbCurrencyUnit.AutoSize = true;
            this.lbCurrencyUnit.Location = new System.Drawing.Point(356, 136);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit.TabIndex = 66;
            this.lbCurrencyUnit.Text = "(VND)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(147, 183);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 67;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(265, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // RoomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 271);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbCurrencyUnit);
            this.Controls.Add(this.tbRoomTypePrice);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.lbRoomTypePrice);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.lbRoomTypeHeader);
            this.Controls.Add(this.imgAddRoomType);
            this.Name = "RoomTypeForm";
            this.Text = "THÔNG TIN LOẠI PHÒNG";
            this.Load += new System.EventHandler(this.RoomTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private DevExpress.XtraEditors.LabelControl lbRoomTypeHeader;
        private DevExpress.XtraEditors.LabelControl lbRoomType;
        private DevExpress.XtraEditors.LabelControl lbRoomTypePrice;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomTypePrice;
        private System.Windows.Forms.Label lbCurrencyUnit;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}