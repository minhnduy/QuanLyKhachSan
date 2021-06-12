namespace GUI_QuanLy.Room
{
    partial class RoomLeaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomLeaseForm));
            this.imgEditRoom = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomDetailHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomDate = new DevExpress.XtraEditors.LabelControl();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.tbRoomDate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcCustomerList = new DevExpress.XtraEditors.GroupControl();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgEditRoom
            // 
            this.imgEditRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgEditRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgEditRoom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgEditRoom.Appearance.Image")));
            this.imgEditRoom.Appearance.Options.UseFont = true;
            this.imgEditRoom.Appearance.Options.UseImage = true;
            this.imgEditRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgEditRoom.ImageOptions.Image")));
            this.imgEditRoom.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgEditRoom.Location = new System.Drawing.Point(180, 8);
            this.imgEditRoom.Margin = new System.Windows.Forms.Padding(2);
            this.imgEditRoom.Name = "imgEditRoom";
            this.imgEditRoom.Size = new System.Drawing.Size(32, 32);
            this.imgEditRoom.TabIndex = 37;
            this.imgEditRoom.Click += new System.EventHandler(this.imgEditRoom_Click);
            // 
            // lbRoomDetailHeader
            // 
            this.lbRoomDetailHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomDetailHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomDetailHeader.Appearance.Options.UseFont = true;
            this.lbRoomDetailHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomDetailHeader.Location = new System.Drawing.Point(287, 8);
            this.lbRoomDetailHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomDetailHeader.Name = "lbRoomDetailHeader";
            this.lbRoomDetailHeader.Size = new System.Drawing.Size(204, 24);
            this.lbRoomDetailHeader.TabIndex = 38;
            this.lbRoomDetailHeader.Text = "PHIẾU THUÊ PHÒNG";
            this.lbRoomDetailHeader.Click += new System.EventHandler(this.lbRoomDetailHeader_Click);
            // 
            // lbRoomID
            // 
            this.lbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(216, 57);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbRoomID.TabIndex = 39;
            this.lbRoomID.Text = "PHÒNG:";
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomPrice.Appearance.Options.UseFont = true;
            this.lbRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomPrice.Location = new System.Drawing.Point(207, 89);
            this.lbRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbRoomPrice.TabIndex = 40;
            this.lbRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbRoomDate
            // 
            this.lbRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomDate.Appearance.Options.UseFont = true;
            this.lbRoomDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomDate.Location = new System.Drawing.Point(395, 89);
            this.lbRoomDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomDate.Name = "lbRoomDate";
            this.lbRoomDate.Size = new System.Drawing.Size(60, 13);
            this.lbRoomDate.TabIndex = 42;
            this.lbRoomDate.Text = "NGÀY THUÊ:";
            this.lbRoomDate.Click += new System.EventHandler(this.lbRoomDate_Click);
            // 
            // tbRoomID
            // 
            this.tbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomID.Location = new System.Drawing.Point(261, 54);
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.ReadOnly = true;
            this.tbRoomID.Size = new System.Drawing.Size(317, 20);
            this.tbRoomID.TabIndex = 45;
            this.tbRoomID.TabStop = false;
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomPrice.Location = new System.Drawing.Point(261, 86);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(117, 20);
            this.tbRoomPrice.TabIndex = 46;
            this.tbRoomPrice.TabStop = false;
            // 
            // tbRoomDate
            // 
            this.tbRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomDate.Location = new System.Drawing.Point(461, 86);
            this.tbRoomDate.Name = "tbRoomDate";
            this.tbRoomDate.ReadOnly = true;
            this.tbRoomDate.Size = new System.Drawing.Size(117, 20);
            this.tbRoomDate.TabIndex = 48;
            this.tbRoomDate.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gcCustomerList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 413);
            this.tableLayoutPanel1.TabIndex = 49;
         
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreate.Location = new System.Drawing.Point(368, 364);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(359, 47);
            this.btnCreate.TabIndex = 53;
            this.btnCreate.Text = "XÁC NHẬN";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(3, 364);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(359, 47);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "HUỶ BỎ";
            // 
            // gcCustomerList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gcCustomerList, 2);
            this.gcCustomerList.Controls.Add(this.dgvCustomerData);
            this.gcCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerList.Location = new System.Drawing.Point(3, 147);
            this.gcCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCustomerList.Name = "gcCustomerList";
            this.gcCustomerList.Size = new System.Drawing.Size(724, 213);
            this.gcCustomerList.TabIndex = 51;
            this.gcCustomerList.Text = "DANH MỤC KHÁCH THUÊ PHÒNG";
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AllowUserToAddRows = false;
            this.dgvCustomerData.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerTypeID,
            this.CustomerType,
            this.CustomerID,
            this.CustomerAddress});
            this.dgvCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerData.Enabled = false;
            this.dgvCustomerData.Location = new System.Drawing.Point(2, 23);
            this.dgvCustomerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomerData.MultiSelect = false;
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.ReadOnly = true;
            this.dgvCustomerData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCustomerData.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerData.RowTemplate.Height = 24;
            this.dgvCustomerData.Size = new System.Drawing.Size(720, 188);
            this.dgvCustomerData.TabIndex = 3;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "TÊN KHÁCH";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerTypeID
            // 
            this.CustomerTypeID.HeaderText = "MÃ LOẠI KHÁCH";
            this.CustomerTypeID.Name = "CustomerTypeID";
            this.CustomerTypeID.ReadOnly = true;
            this.CustomerTypeID.Visible = false;
            // 
            // CustomerType
            // 
            this.CustomerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerType.HeaderText = "LOẠI KHÁCH";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.HeaderText = "SỐ CMND";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerAddress.HeaderText = "ĐỊA CHỈ";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lbRoomID);
            this.panel1.Controls.Add(this.imgEditRoom);
            this.panel1.Controls.Add(this.lbRoomDetailHeader);
            this.panel1.Controls.Add(this.tbRoomID);
            this.panel1.Controls.Add(this.tbRoomDate);
            this.panel1.Controls.Add(this.lbRoomDate);
            this.panel1.Controls.Add(this.tbRoomPrice);
            this.panel1.Controls.Add(this.lbRoomPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 139);
            this.panel1.TabIndex = 50;
            // 
            // RoomLeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RoomLeaseForm";
            this.Text = "CHI TIẾT PHIẾU THUÊ PHÒNG";
            this.Load += new System.EventHandler(this.RoomLeaseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl imgEditRoom;
        private DevExpress.XtraEditors.LabelControl lbRoomDetailHeader;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbRoomDate;
        private System.Windows.Forms.TextBox tbRoomID;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl gcCustomerList;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
    }
}