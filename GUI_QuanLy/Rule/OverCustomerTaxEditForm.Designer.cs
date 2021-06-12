namespace GUI_QuanLy.Rule
{
    partial class OverCustomerTaxEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverCustomerTaxEditForm));
            this.lbThirdCustomerTax = new DevExpress.XtraEditors.LabelControl();
            this.nudTaxPercent = new System.Windows.Forms.NumericUpDown();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThirdCustomerTax
            // 
            this.lbThirdCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbThirdCustomerTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbThirdCustomerTax.Appearance.Options.UseFont = true;
            this.lbThirdCustomerTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbThirdCustomerTax.Location = new System.Drawing.Point(55, 25);
            this.lbThirdCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.lbThirdCustomerTax.Name = "lbThirdCustomerTax";
            this.lbThirdCustomerTax.Size = new System.Drawing.Size(144, 13);
            this.lbThirdCustomerTax.TabIndex = 36;
            this.lbThirdCustomerTax.Text = "TỈ LỆ PHỤ THU KHÁCH THỨ 3:";
            // 
            // nudTaxPercent
            // 
            this.nudTaxPercent.Location = new System.Drawing.Point(223, 23);
            this.nudTaxPercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTaxPercent.Name = "nudTaxPercent";
            this.nudTaxPercent.Size = new System.Drawing.Size(74, 20);
            this.nudTaxPercent.TabIndex = 38;
            this.nudTaxPercent.Enter += new System.EventHandler(this.NudTaxPercent_Enter);
            this.nudTaxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudTaxPercent_KeyPress);
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(303, 25);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(21, 13);
            this.lbPercentage.TabIndex = 39;
            this.lbPercentage.Text = "(%)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Appearance.Image")));
            this.btnConfirm.Appearance.Options.UseImage = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(111, 62);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 40);
            this.btnConfirm.TabIndex = 42;
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
            this.btnCancel.Location = new System.Drawing.Point(236, 62);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // OverCustomerTaxEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 134);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.nudTaxPercent);
            this.Controls.Add(this.lbThirdCustomerTax);
            this.Name = "OverCustomerTaxEditForm";
            this.Text = "PHỤ THU KHÁCH THÊM";
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbThirdCustomerTax;
        private System.Windows.Forms.NumericUpDown nudTaxPercent;
        private System.Windows.Forms.Label lbPercentage;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}