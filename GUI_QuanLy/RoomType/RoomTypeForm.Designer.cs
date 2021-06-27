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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imgAddRoomType
            // 
            this.imgAddRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgAddRoomType.Appearance.Options.UseFont = true;
            this.imgAddRoomType.Appearance.Options.UseImage = true;
            this.imgAddRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgAddRoomType.Location = new System.Drawing.Point(65, 34);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(0, 13);
            this.imgAddRoomType.TabIndex = 60;
            // 
            // lbRoomTypeHeader
            // 
            this.lbRoomTypeHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomTypeHeader.Appearance.Options.UseFont = true;
            this.lbRoomTypeHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypeHeader.Location = new System.Drawing.Point(25, 23);
            this.lbRoomTypeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomTypeHeader.Name = "lbRoomTypeHeader";
            this.lbRoomTypeHeader.Size = new System.Drawing.Size(356, 24);
            this.lbRoomTypeHeader.TabIndex = 61;
            this.lbRoomTypeHeader.Text = "THAY ĐỔI THÔNG TIN LOẠI PHÒNG";
            // 
            // lbRoomType
            // 
            this.lbRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomType.Appearance.Options.UseFont = true;
            this.lbRoomType.Appearance.Options.UseTextOptions = true;
            this.lbRoomType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomType.Location = new System.Drawing.Point(62, 78);
            this.lbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbRoomType.TabIndex = 62;
            this.lbRoomType.Text = "LOẠI PHÒNG:";
            // 
            // lbRoomTypePrice
            // 
            this.lbRoomTypePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomTypePrice.Appearance.Options.UseFont = true;
            this.lbRoomTypePrice.Appearance.Options.UseTextOptions = true;
            this.lbRoomTypePrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomTypePrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypePrice.Location = new System.Drawing.Point(80, 117);
            this.lbRoomTypePrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomTypePrice.Name = "lbRoomTypePrice";
            this.lbRoomTypePrice.Size = new System.Drawing.Size(48, 13);
            this.lbRoomTypePrice.TabIndex = 63;
            this.lbRoomTypePrice.Text = "ĐƠN GIÁ:";
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(132, 75);
            this.tbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomType.MaxLength = 10;
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(134, 20);
            this.tbRoomType.TabIndex = 64;
            // 
            // tbRoomTypePrice
            // 
            this.tbRoomTypePrice.Location = new System.Drawing.Point(132, 114);
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
            this.lbCurrencyUnit.Location = new System.Drawing.Point(271, 117);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit.TabIndex = 66;
            this.lbCurrencyUnit.Text = "(VND)";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.cancel_32x32;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(180, 164);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.apply_32x32;
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(62, 164);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 67;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // RoomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbCurrencyUnit);
            this.Controls.Add(this.tbRoomTypePrice);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.lbRoomTypePrice);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.lbRoomTypeHeader);
            this.Controls.Add(this.imgAddRoomType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(411, 268);
            this.MinimumSize = new System.Drawing.Size(411, 268);
            this.Name = "RoomTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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