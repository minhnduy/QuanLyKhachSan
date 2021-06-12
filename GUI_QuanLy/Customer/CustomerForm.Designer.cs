﻿namespace GUI_QuanLy.Customer
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.imgCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerPassport = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.rtbCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imgCustomer
            // 
            this.imgCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgCustomer.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgCustomer.Appearance.Image")));
            this.imgCustomer.Appearance.Options.UseFont = true;
            this.imgCustomer.Appearance.Options.UseImage = true;
            this.imgCustomer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.imgCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgCustomer.ImageOptions.Image")));
            this.imgCustomer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgCustomer.Location = new System.Drawing.Point(69, 40);
            this.imgCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.imgCustomer.Name = "imgCustomer";
            this.imgCustomer.Size = new System.Drawing.Size(32, 32);
            this.imgCustomer.TabIndex = 71;
            // 
            // lbCustomerHeader
            // 
            this.lbCustomerHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbCustomerHeader.Appearance.Options.UseFont = true;
            this.lbCustomerHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCustomerHeader.LineColor = System.Drawing.Color.Transparent;
            this.lbCustomerHeader.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbCustomerHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerHeader.Location = new System.Drawing.Point(117, 48);
            this.lbCustomerHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerHeader.Name = "lbCustomerHeader";
            this.lbCustomerHeader.Size = new System.Drawing.Size(298, 24);
            this.lbCustomerHeader.TabIndex = 72;
            this.lbCustomerHeader.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerName.Appearance.Options.UseFont = true;
            this.lbCustomerName.Appearance.Options.UseTextOptions = true;
            this.lbCustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerName.Location = new System.Drawing.Point(69, 108);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(60, 13);
            this.lbCustomerName.TabIndex = 73;
            this.lbCustomerName.Text = "TÊN KHÁCH:";
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerType.Appearance.Options.UseFont = true;
            this.lbCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerType.Location = new System.Drawing.Point(64, 160);
            this.lbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(65, 13);
            this.lbCustomerType.TabIndex = 74;
            this.lbCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerAddress.Appearance.Options.UseFont = true;
            this.lbCustomerAddress.Appearance.Options.UseTextOptions = true;
            this.lbCustomerAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerAddress.Location = new System.Drawing.Point(85, 212);
            this.lbCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(44, 13);
            this.lbCustomerAddress.TabIndex = 75;
            this.lbCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerName.Location = new System.Drawing.Point(133, 108);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerName.MaxLength = 30;
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(282, 20);
            this.tbCustomerName.TabIndex = 76;
            // 
            // lbCustomerPassport
            // 
            this.lbCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerPassport.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerPassport.Appearance.Options.UseFont = true;
            this.lbCustomerPassport.Appearance.Options.UseTextOptions = true;
            this.lbCustomerPassport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerPassport.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerPassport.Location = new System.Drawing.Point(246, 160);
            this.lbCustomerPassport.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerPassport.Name = "lbCustomerPassport";
            this.lbCustomerPassport.Size = new System.Drawing.Size(50, 13);
            this.lbCustomerPassport.TabIndex = 77;
            this.lbCustomerPassport.Text = "SỐ CMND:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(133, 157);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(104, 21);
            this.cbCustomerType.TabIndex = 78;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerID.Location = new System.Drawing.Point(300, 158);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerID.MaxLength = 20;
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(115, 20);
            this.tbCustomerID.TabIndex = 79;
            // 
            // rtbCustomerAddress
            // 
            this.rtbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbCustomerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCustomerAddress.Location = new System.Drawing.Point(133, 210);
            this.rtbCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCustomerAddress.MaxLength = 50;
            this.rtbCustomerAddress.Name = "rtbCustomerAddress";
            this.rtbCustomerAddress.Size = new System.Drawing.Size(282, 95);
            this.rtbCustomerAddress.TabIndex = 80;
            this.rtbCustomerAddress.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(151, 309);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 42);
            this.btnConfirm.TabIndex = 81;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(279, 310);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 354);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbCustomerAddress);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.lbCustomerPassport);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbCustomerAddress);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCustomerHeader);
            this.Controls.Add(this.imgCustomer);
            this.Name = "CustomerForm";
            this.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgCustomer;
        private DevExpress.XtraEditors.LabelControl lbCustomerHeader;
        private DevExpress.XtraEditors.LabelControl lbCustomerName;
        private DevExpress.XtraEditors.LabelControl lbCustomerType;
        private DevExpress.XtraEditors.LabelControl lbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerName;
        private DevExpress.XtraEditors.LabelControl lbCustomerPassport;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.RichTextBox rtbCustomerAddress;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}