namespace GUI_QuanLy.CustomerType
{
    partial class CustomerTypeEditForm
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
            this.lbOldCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.tbCustomerType = new System.Windows.Forms.TextBox();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nudSurchagePercent = new System.Windows.Forms.NumericUpDown();
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
            this.imgAddRoomType.Location = new System.Drawing.Point(79, 22);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(0, 13);
            this.imgAddRoomType.TabIndex = 70;
            // 
            // lbEditCustomerTypeHeader
            // 
            this.lbEditCustomerTypeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditCustomerTypeHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditCustomerTypeHeader.Appearance.Options.UseFont = true;
            this.lbEditCustomerTypeHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditCustomerTypeHeader.Location = new System.Drawing.Point(129, 22);
            this.lbEditCustomerTypeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbEditCustomerTypeHeader.Name = "lbEditCustomerTypeHeader";
            this.lbEditCustomerTypeHeader.Size = new System.Drawing.Size(354, 24);
            this.lbEditCustomerTypeHeader.TabIndex = 71;
            this.lbEditCustomerTypeHeader.Text = "THAY ĐỔI THÔNG TIN LOẠI KHÁCH";
            // 
            // lbOldCustomerType
            // 
            this.lbOldCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOldCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOldCustomerType.Appearance.Options.UseFont = true;
            this.lbOldCustomerType.Appearance.Options.UseTextOptions = true;
            this.lbOldCustomerType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbOldCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbOldCustomerType.Location = new System.Drawing.Point(154, 68);
            this.lbOldCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.lbOldCustomerType.Name = "lbOldCustomerType";
            this.lbOldCustomerType.Size = new System.Drawing.Size(65, 13);
            this.lbOldCustomerType.TabIndex = 72;
            this.lbOldCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // tbCustomerType
            // 
            this.tbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerType.Location = new System.Drawing.Point(223, 65);
            this.tbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerType.Name = "tbCustomerType";
            this.tbCustomerType.ReadOnly = true;
            this.tbCustomerType.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerType.TabIndex = 73;
            this.tbCustomerType.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.apply_32x32;
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(129, 142);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 76;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.cancel_32x321;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(286, 142);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.Location = new System.Drawing.Point(172, 102);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "PHỤ THU:";
            // 
            // nudSurchagePercent
            // 
            this.nudSurchagePercent.Location = new System.Drawing.Point(228, 100);
            this.nudSurchagePercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSurchagePercent.Name = "nudSurchagePercent";
            this.nudSurchagePercent.Size = new System.Drawing.Size(96, 20);
            this.nudSurchagePercent.TabIndex = 84;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(330, 102);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(21, 13);
            this.lbPercentage.TabIndex = 87;
            this.lbPercentage.Text = "(%)";
            // 
            // CustomerTypeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 230);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.nudSurchagePercent);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbCustomerType);
            this.Controls.Add(this.lbOldCustomerType);
            this.Controls.Add(this.lbEditCustomerTypeHeader);
            this.Controls.Add(this.imgAddRoomType);
            this.Name = "CustomerTypeEditForm";
            this.Text = "THAY ĐỔI THÔNG TIN LOẠI KHÁCH";
            this.Load += new System.EventHandler(this.CustomerTypeEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSurchagePercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private DevExpress.XtraEditors.LabelControl lbEditCustomerTypeHeader;
        private DevExpress.XtraEditors.LabelControl lbOldCustomerType;
        private System.Windows.Forms.TextBox tbCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown nudSurchagePercent;
        private System.Windows.Forms.Label lbPercentage;
    }
}