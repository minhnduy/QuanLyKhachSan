namespace GUI_QuanLy.Rule
{
    partial class MaxCustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxCustomerEditForm));
            this.lbMaxCustomers = new DevExpress.XtraEditors.LabelControl();
            this.nudMaxCustomers = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaxCustomers
            // 
            this.lbMaxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomers.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomers.Appearance.Options.UseFont = true;
            this.lbMaxCustomers.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomers.Location = new System.Drawing.Point(61, 35);
            this.lbMaxCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lbMaxCustomers.Name = "lbMaxCustomers";
            this.lbMaxCustomers.Size = new System.Drawing.Size(155, 13);
            this.lbMaxCustomers.TabIndex = 31;
            this.lbMaxCustomers.Text = "SỐ KHÁCH TỐI ĐA MỖI PHÒNG:";
            // 
            // nudMaxCustomers
            // 
            this.nudMaxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMaxCustomers.Location = new System.Drawing.Point(233, 33);
            this.nudMaxCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxCustomers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxCustomers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxCustomers.Name = "nudMaxCustomers";
            this.nudMaxCustomers.Size = new System.Drawing.Size(90, 20);
            this.nudMaxCustomers.TabIndex = 32;
            this.nudMaxCustomers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxCustomers.Enter += new System.EventHandler(this.NudMaxCustomers_Enter);
            this.nudMaxCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudMaxCustomers_KeyPress);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Appearance.Image")));
            this.btnConfirm.Appearance.Options.UseImage = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(116, 65);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 39);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Appearance.Image")));
            this.btnCancel.Appearance.Options.UseImage = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(257, 65);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 39);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MaxCustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 135);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudMaxCustomers);
            this.Controls.Add(this.lbMaxCustomers);
            this.Name = "MaxCustomerEditForm";
            this.Text = "SỐ KHÁCH TỐI ĐA MỖI PHÒNG";
            this.Load += new System.EventHandler(this.MaxCustomerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMaxCustomers;
        private System.Windows.Forms.NumericUpDown nudMaxCustomers;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}