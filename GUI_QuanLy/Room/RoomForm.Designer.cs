namespace GUI_QuanLy.Room
{
    partial class RoomForm
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
            this.imgEditRoom = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomStatus = new DevExpress.XtraEditors.LabelControl();
            this.cbRoomStatus = new System.Windows.Forms.ComboBox();
            this.lbRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.rtbRoomNote = new System.Windows.Forms.RichTextBox();
            this.lbRoomType = new DevExpress.XtraEditors.LabelControl();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imgEditRoom
            // 
            this.imgEditRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgEditRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgEditRoom.Appearance.Options.UseFont = true;
            this.imgEditRoom.Appearance.Options.UseImage = true;
            this.imgEditRoom.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgEditRoom.Location = new System.Drawing.Point(29, 4);
            this.imgEditRoom.Margin = new System.Windows.Forms.Padding(2);
            this.imgEditRoom.Name = "imgEditRoom";
            this.imgEditRoom.Size = new System.Drawing.Size(0, 13);
            this.imgEditRoom.TabIndex = 35;
            // 
            // lbRoomHeader
            // 
            this.lbRoomHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomHeader.Appearance.Options.UseFont = true;
            this.lbRoomHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomHeader.Location = new System.Drawing.Point(44, 11);
            this.lbRoomHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomHeader.Name = "lbRoomHeader";
            this.lbRoomHeader.Size = new System.Drawing.Size(300, 24);
            this.lbRoomHeader.TabIndex = 36;
            this.lbRoomHeader.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
            // 
            // lbRoomID
            // 
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.Appearance.Options.UseTextOptions = true;
            this.lbRoomID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(34, 50);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbRoomID.TabIndex = 38;
            this.lbRoomID.Text = "PHÒNG:";
            // 
            // tbRoomID
            // 
            this.tbRoomID.Location = new System.Drawing.Point(77, 47);
            this.tbRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomID.MaxLength = 10;
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.Size = new System.Drawing.Size(134, 20);
            this.tbRoomID.TabIndex = 39;
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomStatus.Appearance.Options.UseFont = true;
            this.lbRoomStatus.Appearance.Options.UseTextOptions = true;
            this.lbRoomStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomStatus.Location = new System.Drawing.Point(8, 82);
            this.lbRoomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(65, 13);
            this.lbRoomStatus.TabIndex = 40;
            this.lbRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // cbRoomStatus
            // 
            this.cbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomStatus.FormattingEnabled = true;
            this.cbRoomStatus.Location = new System.Drawing.Point(77, 79);
            this.cbRoomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoomStatus.Name = "cbRoomStatus";
            this.cbRoomStatus.Size = new System.Drawing.Size(134, 21);
            this.cbRoomStatus.TabIndex = 41;
            // 
            // lbRoomNote
            // 
            this.lbRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomNote.Appearance.Options.UseFont = true;
            this.lbRoomNote.Appearance.Options.UseTextOptions = true;
            this.lbRoomNote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomNote.Location = new System.Drawing.Point(27, 117);
            this.lbRoomNote.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomNote.Name = "lbRoomNote";
            this.lbRoomNote.Size = new System.Drawing.Size(46, 13);
            this.lbRoomNote.TabIndex = 42;
            this.lbRoomNote.Text = "GHI CHÚ:";
            // 
            // rtbRoomNote
            // 
            this.rtbRoomNote.BackColor = System.Drawing.SystemColors.Window;
            this.rtbRoomNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRoomNote.Location = new System.Drawing.Point(77, 117);
            this.rtbRoomNote.Margin = new System.Windows.Forms.Padding(2);
            this.rtbRoomNote.MaxLength = 50;
            this.rtbRoomNote.Name = "rtbRoomNote";
            this.rtbRoomNote.Size = new System.Drawing.Size(339, 67);
            this.rtbRoomNote.TabIndex = 43;
            this.rtbRoomNote.Text = "";
            // 
            // lbRoomType
            // 
            this.lbRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomType.Appearance.Options.UseFont = true;
            this.lbRoomType.Appearance.Options.UseTextOptions = true;
            this.lbRoomType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomType.Location = new System.Drawing.Point(239, 50);
            this.lbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbRoomType.TabIndex = 44;
            this.lbRoomType.Text = "LOẠI PHÒNG:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(309, 47);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(111, 21);
            this.cbRoomType.TabIndex = 45;
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomPrice.Appearance.Options.UseFont = true;
            this.lbRoomPrice.Appearance.Options.UseTextOptions = true;
            this.lbRoomPrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomPrice.Location = new System.Drawing.Point(257, 82);
            this.lbRoomPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbRoomPrice.TabIndex = 46;
            this.lbRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbRoomPrice.Location = new System.Drawing.Point(309, 79);
            this.tbRoomPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(111, 20);
            this.tbRoomPrice.TabIndex = 47;
            this.tbRoomPrice.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.cancel_32x32;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(239, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = global::GUI_QuanLy.Properties.Resources.apply_32x32;
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(106, 198);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 48;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 251);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbRoomPrice);
            this.Controls.Add(this.lbRoomPrice);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.rtbRoomNote);
            this.Controls.Add(this.lbRoomNote);
            this.Controls.Add(this.cbRoomStatus);
            this.Controls.Add(this.lbRoomStatus);
            this.Controls.Add(this.tbRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbRoomHeader);
            this.Controls.Add(this.imgEditRoom);
            this.MaximumSize = new System.Drawing.Size(459, 290);
            this.MinimumSize = new System.Drawing.Size(459, 290);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
            this.Load += new System.EventHandler(this.EditFormRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgEditRoom;
        private DevExpress.XtraEditors.LabelControl lbRoomHeader;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private System.Windows.Forms.TextBox tbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomStatus;
        private System.Windows.Forms.ComboBox cbRoomStatus;
        private DevExpress.XtraEditors.LabelControl lbRoomNote;
        private System.Windows.Forms.RichTextBox rtbRoomNote;
        private DevExpress.XtraEditors.LabelControl lbRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private DevExpress.XtraEditors.LabelControl lbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}