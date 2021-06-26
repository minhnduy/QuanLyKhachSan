namespace GUI_QuanLy.CustomerType
{
    partial class CustomerTypeAddForm
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
            this.imgAddRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbEditCustomerTypeHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomTypePrice = new DevExpress.XtraEditors.LabelControl();
            this.tbCustomerType = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nudSurchagePercent = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurchagePercent)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAddRoomType
            // 
            this.imgAddRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgAddRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgAddRoomType.Appearance.Options.UseFont = true;
            this.imgAddRoomType.Appearance.Options.UseImage = true;
            this.imgAddRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgAddRoomType.Location = new System.Drawing.Point(4, -1);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(0, 13);
            this.imgAddRoomType.TabIndex = 78;
            // 
            // lbEditCustomerTypeHeader
            // 
            this.lbEditCustomerTypeHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditCustomerTypeHeader.Appearance.Options.UseFont = true;
            this.lbEditCustomerTypeHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditCustomerTypeHeader.Location = new System.Drawing.Point(23, 11);
            this.lbEditCustomerTypeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbEditCustomerTypeHeader.Name = "lbEditCustomerTypeHeader";
            this.lbEditCustomerTypeHeader.Size = new System.Drawing.Size(311, 24);
            this.lbEditCustomerTypeHeader.TabIndex = 79;
            this.lbEditCustomerTypeHeader.Text = "THÊM THÔNG TIN LOẠI KHÁCH";
            // 
            // lbRoomTypePrice
            // 
            this.lbRoomTypePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomTypePrice.Appearance.Options.UseFont = true;
            this.lbRoomTypePrice.Appearance.Options.UseTextOptions = true;
            this.lbRoomTypePrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomTypePrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypePrice.Location = new System.Drawing.Point(23, 53);
            this.lbRoomTypePrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomTypePrice.Name = "lbRoomTypePrice";
            this.lbRoomTypePrice.Size = new System.Drawing.Size(65, 13);
            this.lbRoomTypePrice.TabIndex = 80;
            this.lbRoomTypePrice.Text = "LOẠI KHÁCH:";
            // 
            // tbCustomerType
            // 
            this.tbCustomerType.Location = new System.Drawing.Point(93, 50);
            this.tbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerType.MaxLength = 30;
            this.tbCustomerType.Name = "tbCustomerType";
            this.tbCustomerType.Size = new System.Drawing.Size(143, 20);
            this.tbCustomerType.TabIndex = 81;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.Location = new System.Drawing.Point(41, 83);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "PHỤ THU:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // nudSurchagePercent
            // 
            this.nudSurchagePercent.Location = new System.Drawing.Point(93, 81);
            this.nudSurchagePercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSurchagePercent.Name = "nudSurchagePercent";
            this.nudSurchagePercent.Size = new System.Drawing.Size(96, 20);
            this.nudSurchagePercent.TabIndex = 83;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.ImageOptions.SvgImage = global::GUI_QuanLy.Properties.Resources.actions_add;
            this.btnConfirm.Location = new System.Drawing.Point(53, 115);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 84;
            this.btnConfirm.Text = "THÊM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.cancel_32x32;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(189, 115);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(195, 88);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(21, 13);
            this.lbPercentage.TabIndex = 86;
            this.lbPercentage.Text = "(%)";
            // 
            // CustomerTypeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 170);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudSurchagePercent);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbCustomerType);
            this.Controls.Add(this.lbRoomTypePrice);
            this.Controls.Add(this.lbEditCustomerTypeHeader);
            this.Controls.Add(this.imgAddRoomType);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 209);
            this.MinimumSize = new System.Drawing.Size(365, 209);
            this.Name = "CustomerTypeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM THÔNG TIN LOẠI KHÁCH";
            this.Load += new System.EventHandler(this.CustomerTypeAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSurchagePercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private DevExpress.XtraEditors.LabelControl lbEditCustomerTypeHeader;
        private DevExpress.XtraEditors.LabelControl lbRoomTypePrice;
        private System.Windows.Forms.TextBox tbCustomerType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown nudSurchagePercent;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label lbPercentage;
    }
}