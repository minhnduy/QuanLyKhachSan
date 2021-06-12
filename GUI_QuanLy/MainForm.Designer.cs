﻿namespace GUI_QuanLy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcHotelManagement = new DevExpress.XtraTab.XtraTabControl();
            this.tabListRoom = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gcRoomData = new DevExpress.XtraEditors.GroupControl();
            this.rtbListRoomNote = new System.Windows.Forms.RichTextBox();
            this.lbListRoomNote = new System.Windows.Forms.Label();
            this.tbListRoomPrice = new System.Windows.Forms.TextBox();
            this.tbListRoomType = new System.Windows.Forms.TextBox();
            this.lbListRoomPrice = new System.Windows.Forms.Label();
            this.lbListRoomType = new System.Windows.Forms.Label();
            this.tbListRoomStatus = new System.Windows.Forms.TextBox();
            this.tbListRoomID = new System.Windows.Forms.TextBox();
            this.lbListRoomStatus = new System.Windows.Forms.Label();
            this.lbListRoomID = new System.Windows.Forms.Label();
            this.gcListRoom = new DevExpress.XtraEditors.GroupControl();
            this.dgvListRoom = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRoomEdit = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tabRoomLease = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcUpdateCustomer = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelLease = new DevExpress.XtraEditors.SimpleButton();
            this.gcCustomerLease = new DevExpress.XtraEditors.GroupControl();
            this.tbCustomerType = new System.Windows.Forms.TextBox();
            this.rtbCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.gcLeaseCustomerData = new DevExpress.XtraEditors.GroupControl();
            this.dgvLeaseCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRoomLease = new DevExpress.XtraEditors.GroupControl();
            this.tbLeaseRoomPrice = new System.Windows.Forms.TextBox();
            this.deLeaseRoomDate = new DevExpress.XtraEditors.DateEdit();
            this.cbLeaseRoomID = new System.Windows.Forms.ComboBox();
            this.btnLockRoom = new DevExpress.XtraEditors.SimpleButton();
            this.lbRoomPrice = new System.Windows.Forms.Label();
            this.lbRoomDate = new System.Windows.Forms.Label();
            this.lbRoomList = new System.Windows.Forms.Label();
            this.btnCreateLease = new DevExpress.XtraEditors.SimpleButton();
            this.tabRoomFind = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gcFindRoom = new DevExpress.XtraEditors.GroupControl();
            this.btnFindRoom = new DevExpress.XtraEditors.SimpleButton();
            this.cbFindRoomStatus = new System.Windows.Forms.ComboBox();
            this.cbFindRoomPrice = new System.Windows.Forms.ComboBox();
            this.cbFindRoomType = new System.Windows.Forms.ComboBox();
            this.cbFindRoomID = new System.Windows.Forms.ComboBox();
            this.lbFindRoomStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomID = new DevExpress.XtraEditors.LabelControl();
            this.gcRoomList = new DevExpress.XtraEditors.GroupControl();
            this.dgvFindRoom = new System.Windows.Forms.DataGridView();
            this.FindRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcFindroomData = new DevExpress.XtraEditors.GroupControl();
            this.tbFindRoomStatus = new System.Windows.Forms.TextBox();
            this.tbFindRoomType = new System.Windows.Forms.TextBox();
            this.rtbFindRoomNote = new System.Windows.Forms.RichTextBox();
            this.tbFindRoomPrice = new System.Windows.Forms.TextBox();
            this.tbFindRoomID = new System.Windows.Forms.TextBox();
            this.lbFindRoomStatus2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomType2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomPrice2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomID2 = new DevExpress.XtraEditors.LabelControl();
            this.tabRoomBill = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.gcRoomBill = new DevExpress.XtraEditors.GroupControl();
            this.dgvBillRoom = new System.Windows.Forms.DataGridView();
            this.PaidRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomRentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcBill = new DevExpress.XtraEditors.GroupControl();
            this.btnLockBill = new DevExpress.XtraEditors.SimpleButton();
            this.rtbBillCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.deBillDate = new DevExpress.XtraEditors.DateEdit();
            this.tbBillCustomerName = new System.Windows.Forms.TextBox();
            this.lbBillCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbBillDate = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.gcRoomBillData = new DevExpress.XtraEditors.GroupControl();
            this.btnDelBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tbBillRoomCost = new System.Windows.Forms.TextBox();
            this.tbBillRoomPrice = new System.Windows.Forms.TextBox();
            this.tbBillRoomDay = new System.Windows.Forms.TextBox();
            this.tbBillRoomID = new System.Windows.Forms.TextBox();
            this.lbBillRoomCost = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomDay = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomID = new DevExpress.XtraEditors.LabelControl();
            this.gcAddRoomBill = new DevExpress.XtraEditors.GroupControl();
            this.btnAddBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.cbAddBillRoomID = new System.Windows.Forms.ComboBox();
            this.lbAddBillRoomID = new DevExpress.XtraEditors.LabelControl();
            this.tabMonthReport = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gcMonthReportSelect = new DevExpress.XtraEditors.GroupControl();
            this.cbRevenueYear = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateMonthRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.cbRevenueMonth = new System.Windows.Forms.ComboBox();
            this.lbMonthRevenue = new DevExpress.XtraEditors.LabelControl();
            this.gcMonthReportList = new DevExpress.XtraEditors.GroupControl();
            this.dgvRevenueList = new System.Windows.Forms.DataGridView();
            this.ReportedRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedRoomRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedRoomPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRoomRules = new DevExpress.XtraTab.XtraTabPage();
            this.gcCustomerTypeList = new DevExpress.XtraEditors.GroupControl();
            this.btnEditCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.dgvCustomerType = new System.Windows.Forms.DataGridView();
            this.EditCustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCustomerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSurcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRoomTypeList = new DevExpress.XtraEditors.GroupControl();
            this.btnEditRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.EditRoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRoomTypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEditRule = new DevExpress.XtraEditors.GroupControl();
            this.lbAdditionalCustomerSurchargeValue = new DevExpress.XtraEditors.LabelControl();
            this.lbMaxCustomerValue = new DevExpress.XtraEditors.LabelControl();
            this.btnAdditionalCustomerSurcharge = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditMaxCustomerRule = new DevExpress.XtraEditors.SimpleButton();
            this.lbAdditionalCustomerSurcharge = new DevExpress.XtraEditors.LabelControl();
            this.lbMaxCustomerRule = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tcHotelManagement)).BeginInit();
            this.tcHotelManagement.SuspendLayout();
            this.tabListRoom.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomData)).BeginInit();
            this.gcRoomData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoom)).BeginInit();
            this.gcListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomEdit)).BeginInit();
            this.gcRoomEdit.SuspendLayout();
            this.tabRoomLease.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUpdateCustomer)).BeginInit();
            this.gcUpdateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerLease)).BeginInit();
            this.gcCustomerLease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaseCustomerData)).BeginInit();
            this.gcLeaseCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomLease)).BeginInit();
            this.gcRoomLease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deLeaseRoomDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLeaseRoomDate.Properties)).BeginInit();
            this.tabRoomFind.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoom)).BeginInit();
            this.gcFindRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).BeginInit();
            this.gcRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindroomData)).BeginInit();
            this.gcFindroomData.SuspendLayout();
            this.tabRoomBill.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomBill)).BeginInit();
            this.gcRoomBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            this.gcBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomBillData)).BeginInit();
            this.gcRoomBillData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddRoomBill)).BeginInit();
            this.gcAddRoomBill.SuspendLayout();
            this.tabMonthReport.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonthReportSelect)).BeginInit();
            this.gcMonthReportSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonthReportList)).BeginInit();
            this.gcMonthReportList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueList)).BeginInit();
            this.tabRoomRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerTypeList)).BeginInit();
            this.gcCustomerTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomTypeList)).BeginInit();
            this.gcRoomTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditRule)).BeginInit();
            this.gcEditRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHotelManagement
            // 
            this.tcHotelManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHotelManagement.Location = new System.Drawing.Point(0, 0);
            this.tcHotelManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcHotelManagement.Name = "tcHotelManagement";
            this.tcHotelManagement.RightToLeftLayout = DevExpress.Utils.DefaultBoolean.False;
            this.tcHotelManagement.SelectedTabPage = this.tabListRoom;
            this.tcHotelManagement.Size = new System.Drawing.Size(952, 693);
            this.tcHotelManagement.TabIndex = 1;
            this.tcHotelManagement.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabListRoom,
            this.tabRoomLease,
            this.tabRoomFind,
            this.tabRoomBill,
            this.tabMonthReport,
            this.tabRoomRules});
            this.tcHotelManagement.Click += new System.EventHandler(this.tcHotelManagement_Click);
            // 
            // tabListRoom
            // 
            this.tabListRoom.Controls.Add(this.tableLayoutPanel2);
            //this.tabListRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabListRoom.ImageOptions.Image")));
            this.tabListRoom.Name = "tabListRoom";
            this.tabListRoom.Size = new System.Drawing.Size(950, 649);
            this.tabListRoom.Text = "DANH MỤC PHÒNG";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.gcRoomData, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcListRoom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gcRoomEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(950, 649);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // gcRoomData
            // 
            this.gcRoomData.Controls.Add(this.rtbListRoomNote);
            this.gcRoomData.Controls.Add(this.lbListRoomNote);
            this.gcRoomData.Controls.Add(this.tbListRoomPrice);
            this.gcRoomData.Controls.Add(this.tbListRoomType);
            this.gcRoomData.Controls.Add(this.lbListRoomPrice);
            this.gcRoomData.Controls.Add(this.lbListRoomType);
            this.gcRoomData.Controls.Add(this.tbListRoomStatus);
            this.gcRoomData.Controls.Add(this.tbListRoomID);
            this.gcRoomData.Controls.Add(this.lbListRoomStatus);
            this.gcRoomData.Controls.Add(this.lbListRoomID);
            this.gcRoomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomData.Location = new System.Drawing.Point(3, 3);
            this.gcRoomData.Name = "gcRoomData";
            this.gcRoomData.Size = new System.Drawing.Size(744, 214);
            this.gcRoomData.TabIndex = 0;
            this.gcRoomData.Text = "THÔNG TIN PHÒNG";
            this.gcRoomData.Paint += new System.Windows.Forms.PaintEventHandler(this.gcRoomData_Paint);
            // 
            // rtbListRoomNote
            // 
            this.rtbListRoomNote.BackColor = System.Drawing.SystemColors.Control;
            this.rtbListRoomNote.Location = new System.Drawing.Point(108, 137);
            this.rtbListRoomNote.Name = "rtbListRoomNote";
            this.rtbListRoomNote.ReadOnly = true;
            this.rtbListRoomNote.Size = new System.Drawing.Size(491, 72);
            this.rtbListRoomNote.TabIndex = 9;
            this.rtbListRoomNote.Text = "";
            // 
            // lbListRoomNote
            // 
            this.lbListRoomNote.AutoSize = true;
            this.lbListRoomNote.Location = new System.Drawing.Point(29, 137);
            this.lbListRoomNote.Name = "lbListRoomNote";
            this.lbListRoomNote.Size = new System.Drawing.Size(53, 13);
            this.lbListRoomNote.TabIndex = 8;
            this.lbListRoomNote.Text = "GHI CHÚ:";
            // 
            // tbListRoomPrice
            // 
            this.tbListRoomPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tbListRoomPrice.Location = new System.Drawing.Point(436, 85);
            this.tbListRoomPrice.Name = "tbListRoomPrice";
            this.tbListRoomPrice.ReadOnly = true;
            this.tbListRoomPrice.Size = new System.Drawing.Size(163, 21);
            this.tbListRoomPrice.TabIndex = 7;
            // 
            // tbListRoomType
            // 
            this.tbListRoomType.BackColor = System.Drawing.SystemColors.Control;
            this.tbListRoomType.Location = new System.Drawing.Point(436, 38);
            this.tbListRoomType.Name = "tbListRoomType";
            this.tbListRoomType.ReadOnly = true;
            this.tbListRoomType.Size = new System.Drawing.Size(163, 21);
            this.tbListRoomType.TabIndex = 6;
            // 
            // lbListRoomPrice
            // 
            this.lbListRoomPrice.AutoSize = true;
            this.lbListRoomPrice.Location = new System.Drawing.Point(375, 90);
            this.lbListRoomPrice.Name = "lbListRoomPrice";
            this.lbListRoomPrice.Size = new System.Drawing.Size(55, 13);
            this.lbListRoomPrice.TabIndex = 5;
            this.lbListRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbListRoomType
            // 
            this.lbListRoomType.AutoSize = true;
            this.lbListRoomType.Location = new System.Drawing.Point(357, 41);
            this.lbListRoomType.Name = "lbListRoomType";
            this.lbListRoomType.Size = new System.Drawing.Size(73, 13);
            this.lbListRoomType.TabIndex = 4;
            this.lbListRoomType.Text = "LOẠI PHÒNG:";
            // 
            // tbListRoomStatus
            // 
            this.tbListRoomStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tbListRoomStatus.Location = new System.Drawing.Point(107, 90);
            this.tbListRoomStatus.Name = "tbListRoomStatus";
            this.tbListRoomStatus.ReadOnly = true;
            this.tbListRoomStatus.Size = new System.Drawing.Size(163, 21);
            this.tbListRoomStatus.TabIndex = 3;
            // 
            // tbListRoomID
            // 
            this.tbListRoomID.BackColor = System.Drawing.SystemColors.Control;
            this.tbListRoomID.Location = new System.Drawing.Point(107, 38);
            this.tbListRoomID.Name = "tbListRoomID";
            this.tbListRoomID.ReadOnly = true;
            this.tbListRoomID.Size = new System.Drawing.Size(163, 21);
            this.tbListRoomID.TabIndex = 2;
            this.tbListRoomID.TextChanged += new System.EventHandler(this.tbListRoomID_TextChanged);
            // 
            // lbListRoomStatus
            // 
            this.lbListRoomStatus.AutoSize = true;
            this.lbListRoomStatus.Location = new System.Drawing.Point(29, 93);
            this.lbListRoomStatus.Name = "lbListRoomStatus";
            this.lbListRoomStatus.Size = new System.Drawing.Size(72, 13);
            this.lbListRoomStatus.TabIndex = 1;
            this.lbListRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // lbListRoomID
            // 
            this.lbListRoomID.AutoSize = true;
            this.lbListRoomID.Location = new System.Drawing.Point(55, 41);
            this.lbListRoomID.Name = "lbListRoomID";
            this.lbListRoomID.Size = new System.Drawing.Size(46, 13);
            this.lbListRoomID.TabIndex = 0;
            this.lbListRoomID.Text = "PHÒNG:";
            // 
            // gcListRoom
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.gcListRoom, 2);
            this.gcListRoom.Controls.Add(this.dgvListRoom);
            this.gcListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListRoom.Location = new System.Drawing.Point(3, 223);
            this.gcListRoom.Name = "gcListRoom";
            this.gcListRoom.Size = new System.Drawing.Size(944, 423);
            this.gcListRoom.TabIndex = 2;
            this.gcListRoom.Text = "DANH MỤC PHÒNG";
            // 
            // dgvListRoom
            // 
            this.dgvListRoom.AllowUserToAddRows = false;
            this.dgvListRoom.AllowUserToDeleteRows = false;
            this.dgvListRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomType,
            this.RoomPrice,
            this.RoomStatus,
            this.RoomNote});
            this.dgvListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListRoom.Location = new System.Drawing.Point(2, 23);
            this.dgvListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListRoom.MultiSelect = false;
            this.dgvListRoom.Name = "dgvListRoom";
            this.dgvListRoom.ReadOnly = true;
            this.dgvListRoom.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListRoom.RowTemplate.Height = 24;
            this.dgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRoom.Size = new System.Drawing.Size(940, 398);
            this.dgvListRoom.TabIndex = 2;
            this.dgvListRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListRoom_CellContentClick);
            this.dgvListRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListRoom_CellEnter);
            this.dgvListRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "PHÒNG";
            this.RoomID.MaxInputLength = 10;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomType.DataPropertyName = "MaLoaiPhong";
            this.RoomType.HeaderText = "LOẠI PHÒNG";
            this.RoomType.MaxInputLength = 30;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomPrice.DataPropertyName = "DonGia";
            this.RoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // RoomStatus
            // 
            this.RoomStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomStatus.DataPropertyName = "TenTinhTrang";
            this.RoomStatus.HeaderText = "TÌNH TRẠNG";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.ReadOnly = true;
            // 
            // RoomNote
            // 
            this.RoomNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNote.DataPropertyName = "GhiChu";
            this.RoomNote.HeaderText = "GHI CHÚ";
            this.RoomNote.MaxInputLength = 50;
            this.RoomNote.Name = "RoomNote";
            this.RoomNote.ReadOnly = true;
            // 
            // gcRoomEdit
            // 
            this.gcRoomEdit.Controls.Add(this.btnDeleteRoom);
            this.gcRoomEdit.Controls.Add(this.btnEditRoom);
            this.gcRoomEdit.Controls.Add(this.btnAddRoom);
            this.gcRoomEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomEdit.Location = new System.Drawing.Point(753, 3);
            this.gcRoomEdit.Name = "gcRoomEdit";
            this.gcRoomEdit.Size = new System.Drawing.Size(194, 214);
            this.gcRoomEdit.TabIndex = 1;
            this.gcRoomEdit.Text = "HIỆU CHỈNH PHÒNG";
            // 
            // btnDeleteRoom
            // 
            //this.btnDeleteRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.ImageOptions.Image")));
            this.btnDeleteRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteRoom.Location = new System.Drawing.Point(52, 146);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteRoom.TabIndex = 2;
            this.btnDeleteRoom.Text = "XÓA";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnEditRoom
            // 
            //this.btnEditRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoom.ImageOptions.Image")));
            this.btnEditRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditRoom.Location = new System.Drawing.Point(52, 93);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(107, 47);
            this.btnEditRoom.TabIndex = 1;
            this.btnEditRoom.Text = "SỬA";
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnAddRoom
            // 
            //this.btnAddRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.ImageOptions.Image")));
            this.btnAddRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddRoom.Location = new System.Drawing.Point(52, 38);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(107, 49);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "THÊM";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // tabRoomLease
            // 
            this.tabRoomLease.Controls.Add(this.tableLayoutPanel1);
            //this.tabRoomLease.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRoomLease.ImageOptions.Image")));
            this.tabRoomLease.Name = "tabRoomLease";
            this.tabRoomLease.Size = new System.Drawing.Size(950, 649);
            this.tabRoomLease.Text = "LẬP PHIẾU THUÊ PHÒNG";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.gcUpdateCustomer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelLease, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gcCustomerLease, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gcLeaseCustomerData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcRoomLease, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateLease, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 649);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // gcUpdateCustomer
            // 
            this.gcUpdateCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gcUpdateCustomer.Controls.Add(this.btnEditCustomer);
            this.gcUpdateCustomer.Controls.Add(this.btnAddCustomer);
            this.gcUpdateCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUpdateCustomer.Location = new System.Drawing.Point(753, 3);
            this.gcUpdateCustomer.Name = "gcUpdateCustomer";
            this.gcUpdateCustomer.Size = new System.Drawing.Size(194, 232);
            this.gcUpdateCustomer.TabIndex = 2;
            this.gcUpdateCustomer.Text = "HIỆU CHỈNH KHÁCH";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            //this.btnDeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.ImageOptions.Image")));
            this.btnDeleteCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(42, 145);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "XÓA";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Enabled = false;
            //this.btnEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.ImageOptions.Image")));
            this.btnEditCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditCustomer.Location = new System.Drawing.Point(42, 92);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(107, 47);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "SỬA";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Enabled = false;
            //this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(42, 37);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(107, 49);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "THÊM";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCancelLease
            // 
            this.btnCancelLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelLease.Enabled = false;
            //this.btnCancelLease.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelLease.ImageOptions.Image")));
            this.btnCancelLease.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelLease.Location = new System.Drawing.Point(3, 598);
            this.btnCancelLease.Name = "btnCancelLease";
            this.btnCancelLease.Size = new System.Drawing.Size(294, 48);
            this.btnCancelLease.TabIndex = 1;
            this.btnCancelLease.Text = "HỦY PHIẾU THUÊ";
            this.btnCancelLease.Click += new System.EventHandler(this.btnCancelLease_Click);
            // 
            // gcCustomerLease
            // 
            this.gcCustomerLease.Controls.Add(this.tbCustomerType);
            this.gcCustomerLease.Controls.Add(this.rtbCustomerAddress);
            this.gcCustomerLease.Controls.Add(this.tbCustomerID);
            this.gcCustomerLease.Controls.Add(this.tbCustomerName);
            this.gcCustomerLease.Controls.Add(this.lbCustomerAddress);
            this.gcCustomerLease.Controls.Add(this.lbCustomerID);
            this.gcCustomerLease.Controls.Add(this.lbCustomerType);
            this.gcCustomerLease.Controls.Add(this.lbCustomerName);
            this.gcCustomerLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerLease.Location = new System.Drawing.Point(303, 3);
            this.gcCustomerLease.Name = "gcCustomerLease";
            this.gcCustomerLease.Size = new System.Drawing.Size(444, 232);
            this.gcCustomerLease.TabIndex = 1;
            this.gcCustomerLease.Text = "THÔNG TIN KHÁCH";
            // 
            // tbCustomerType
            // 
            this.tbCustomerType.Location = new System.Drawing.Point(78, 79);
            this.tbCustomerType.Name = "tbCustomerType";
            this.tbCustomerType.ReadOnly = true;
            this.tbCustomerType.Size = new System.Drawing.Size(109, 21);
            this.tbCustomerType.TabIndex = 10;
            // 
            // rtbCustomerAddress
            // 
            this.rtbCustomerAddress.Location = new System.Drawing.Point(78, 130);
            this.rtbCustomerAddress.Name = "rtbCustomerAddress";
            this.rtbCustomerAddress.ReadOnly = true;
            this.rtbCustomerAddress.Size = new System.Drawing.Size(287, 60);
            this.rtbCustomerAddress.TabIndex = 9;
            this.rtbCustomerAddress.Text = "";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(239, 79);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(126, 21);
            this.tbCustomerID.TabIndex = 8;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(78, 37);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.Size = new System.Drawing.Size(287, 21);
            this.tbCustomerName.TabIndex = 6;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(21, 130);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(51, 13);
            this.lbCustomerAddress.TabIndex = 5;
            this.lbCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(193, 82);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(40, 13);
            this.lbCustomerID.TabIndex = 4;
            this.lbCustomerID.Text = "CMND:";
            this.lbCustomerID.Click += new System.EventHandler(this.lbCustomerID_Click);
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Location = new System.Drawing.Point(5, 83);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(72, 13);
            this.lbCustomerType.TabIndex = 3;
            this.lbCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(5, 40);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(67, 13);
            this.lbCustomerName.TabIndex = 2;
            this.lbCustomerName.Text = "TÊN KHÁCH:";
            // 
            // gcLeaseCustomerData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gcLeaseCustomerData, 3);
            this.gcLeaseCustomerData.Controls.Add(this.dgvLeaseCustomer);
            this.gcLeaseCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLeaseCustomerData.Location = new System.Drawing.Point(3, 241);
            this.gcLeaseCustomerData.Name = "gcLeaseCustomerData";
            this.gcLeaseCustomerData.Size = new System.Drawing.Size(944, 351);
            this.gcLeaseCustomerData.TabIndex = 3;
            this.gcLeaseCustomerData.Text = "DANH SÁCH KHÁCH";
            // 
            // dgvLeaseCustomer
            // 
            this.dgvLeaseCustomer.AllowUserToAddRows = false;
            this.dgvLeaseCustomer.AllowUserToDeleteRows = false;
            this.dgvLeaseCustomer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLeaseCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaseCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerTypeID,
            this.CustomerType,
            this.CustomerID,
            this.CustomerAddress});
            this.dgvLeaseCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaseCustomer.Location = new System.Drawing.Point(2, 23);
            this.dgvLeaseCustomer.Name = "dgvLeaseCustomer";
            this.dgvLeaseCustomer.ReadOnly = true;
            this.dgvLeaseCustomer.Size = new System.Drawing.Size(940, 326);
            this.dgvLeaseCustomer.TabIndex = 3;
            this.dgvLeaseCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLeaseCustomer_CellEnter);
            this.dgvLeaseCustomer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLeaseCustomer_CellValueChanged);
            this.dgvLeaseCustomer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            this.dgvLeaseCustomer.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvLeaseCustomer_RowsAdded);
            this.dgvLeaseCustomer.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvLeaseCustomer_RowsRemoved);
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
            // gcRoomLease
            // 
            this.gcRoomLease.Controls.Add(this.tbLeaseRoomPrice);
            this.gcRoomLease.Controls.Add(this.deLeaseRoomDate);
            this.gcRoomLease.Controls.Add(this.cbLeaseRoomID);
            this.gcRoomLease.Controls.Add(this.btnLockRoom);
            this.gcRoomLease.Controls.Add(this.lbRoomPrice);
            this.gcRoomLease.Controls.Add(this.lbRoomDate);
            this.gcRoomLease.Controls.Add(this.lbRoomList);
            this.gcRoomLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomLease.Location = new System.Drawing.Point(3, 3);
            this.gcRoomLease.Name = "gcRoomLease";
            this.gcRoomLease.Size = new System.Drawing.Size(294, 232);
            this.gcRoomLease.TabIndex = 0;
            this.gcRoomLease.Text = "CHỌN PHÒNG THUÊ";
            this.gcRoomLease.Paint += new System.Windows.Forms.PaintEventHandler(this.gcRoomLease_Paint);
            // 
            // tbLeaseRoomPrice
            // 
            this.tbLeaseRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLeaseRoomPrice.Location = new System.Drawing.Point(81, 127);
            this.tbLeaseRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeaseRoomPrice.Name = "tbLeaseRoomPrice";
            this.tbLeaseRoomPrice.ReadOnly = true;
            this.tbLeaseRoomPrice.Size = new System.Drawing.Size(114, 21);
            this.tbLeaseRoomPrice.TabIndex = 21;
            this.tbLeaseRoomPrice.TabStop = false;
            this.tbLeaseRoomPrice.TextChanged += new System.EventHandler(this.tbLeaseRoomPrice_TextChanged);
            // 
            // deLeaseRoomDate
            // 
            this.deLeaseRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deLeaseRoomDate.EditValue = null;
            this.deLeaseRoomDate.Location = new System.Drawing.Point(81, 89);
            this.deLeaseRoomDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deLeaseRoomDate.Name = "deLeaseRoomDate";
            this.deLeaseRoomDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deLeaseRoomDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deLeaseRoomDate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deLeaseRoomDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deLeaseRoomDate.Size = new System.Drawing.Size(114, 20);
            this.deLeaseRoomDate.TabIndex = 20;
            // 
            // cbLeaseRoomID
            // 
            this.cbLeaseRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLeaseRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeaseRoomID.FormattingEnabled = true;
            this.cbLeaseRoomID.Location = new System.Drawing.Point(81, 46);
            this.cbLeaseRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeaseRoomID.Name = "cbLeaseRoomID";
            this.cbLeaseRoomID.Size = new System.Drawing.Size(114, 21);
            this.cbLeaseRoomID.Sorted = true;
            this.cbLeaseRoomID.TabIndex = 19;
            this.cbLeaseRoomID.SelectedIndexChanged += new System.EventHandler(this.CbNoteRoomID_SelectedIndexChanged);
            // 
            // btnLockRoom
            // 
            //this.btnLockRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLockRoom.ImageOptions.Image")));
            this.btnLockRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLockRoom.Location = new System.Drawing.Point(201, 68);
            this.btnLockRoom.Name = "btnLockRoom";
            this.btnLockRoom.Size = new System.Drawing.Size(79, 75);
            this.btnLockRoom.TabIndex = 1;
            this.btnLockRoom.Text = "CHỌN";
            this.btnLockRoom.EnabledChanged += new System.EventHandler(this.BtnLockLeaseRoom_EnabledChanged);
            this.btnLockRoom.Click += new System.EventHandler(this.btnLockRoom_Click);
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.AutoSize = true;
            this.lbRoomPrice.Location = new System.Drawing.Point(20, 130);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(55, 13);
            this.lbRoomPrice.TabIndex = 3;
            this.lbRoomPrice.Text = "ĐƠN GIÁ:";
            this.lbRoomPrice.Click += new System.EventHandler(this.lbRoomPrice_Click);
            // 
            // lbRoomDate
            // 
            this.lbRoomDate.AutoSize = true;
            this.lbRoomDate.Location = new System.Drawing.Point(8, 90);
            this.lbRoomDate.Name = "lbRoomDate";
            this.lbRoomDate.Size = new System.Drawing.Size(67, 13);
            this.lbRoomDate.TabIndex = 2;
            this.lbRoomDate.Text = "NGÀY THUÊ:";
            this.lbRoomDate.Click += new System.EventHandler(this.lbRoomDate_Click);
            // 
            // lbRoomList
            // 
            this.lbRoomList.AutoSize = true;
            this.lbRoomList.Location = new System.Drawing.Point(29, 46);
            this.lbRoomList.Name = "lbRoomList";
            this.lbRoomList.Size = new System.Drawing.Size(46, 13);
            this.lbRoomList.TabIndex = 1;
            this.lbRoomList.Text = "PHÒNG:";
            this.lbRoomList.Click += new System.EventHandler(this.lbRoomList_Click);
            // 
            // btnCreateLease
            // 
            this.btnCreateLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateLease.Enabled = false;
            //this.btnCreateLease.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateLease.ImageOptions.Image")));
            this.btnCreateLease.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateLease.Location = new System.Drawing.Point(753, 598);
            this.btnCreateLease.Name = "btnCreateLease";
            this.btnCreateLease.Size = new System.Drawing.Size(194, 48);
            this.btnCreateLease.TabIndex = 2;
            this.btnCreateLease.Text = "LẬP PHIẾU THUÊ";
            this.btnCreateLease.Click += new System.EventHandler(this.btnCreateLease_Click);
            // 
            // tabRoomFind
            // 
            this.tabRoomFind.Controls.Add(this.tableLayoutPanel3);
            //this.tabRoomFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRoomFind.ImageOptions.Image")));
            this.tabRoomFind.Name = "tabRoomFind";
            this.tabRoomFind.Size = new System.Drawing.Size(950, 649);
            this.tabRoomFind.Text = "TRA CỨU PHÒNG";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.gcFindRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gcRoomList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gcFindroomData, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(950, 649);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // gcFindRoom
            // 
            this.gcFindRoom.Controls.Add(this.btnFindRoom);
            this.gcFindRoom.Controls.Add(this.cbFindRoomStatus);
            this.gcFindRoom.Controls.Add(this.cbFindRoomPrice);
            this.gcFindRoom.Controls.Add(this.cbFindRoomType);
            this.gcFindRoom.Controls.Add(this.cbFindRoomID);
            this.gcFindRoom.Controls.Add(this.lbFindRoomStatus);
            this.gcFindRoom.Controls.Add(this.lbFindRoomPrice);
            this.gcFindRoom.Controls.Add(this.lbFindRoomType);
            this.gcFindRoom.Controls.Add(this.lbFindRoomID);
            this.gcFindRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFindRoom.Location = new System.Drawing.Point(3, 3);
            this.gcFindRoom.Name = "gcFindRoom";
            this.gcFindRoom.Size = new System.Drawing.Size(374, 253);
            this.gcFindRoom.TabIndex = 0;
            this.gcFindRoom.Text = "TÌM KIẾM PHÒNG";
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnFindRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFindRoom.ImageOptions.Image")));
            this.btnFindRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.btnFindRoom.Location = new System.Drawing.Point(255, 93);
            this.btnFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(92, 83);
            this.btnFindRoom.TabIndex = 14;
            this.btnFindRoom.Text = "\r\nTÌM KIẾM";
            this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
            // 
            // cbFindRoomStatus
            // 
            this.cbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomStatus.FormattingEnabled = true;
            this.cbFindRoomStatus.Location = new System.Drawing.Point(100, 185);
            this.cbFindRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomStatus.Name = "cbFindRoomStatus";
            this.cbFindRoomStatus.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomStatus.TabIndex = 13;
            // 
            // cbFindRoomPrice
            // 
            this.cbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomPrice.FormattingEnabled = true;
            this.cbFindRoomPrice.Location = new System.Drawing.Point(100, 144);
            this.cbFindRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomPrice.Name = "cbFindRoomPrice";
            this.cbFindRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomPrice.TabIndex = 12;
            // 
            // cbFindRoomType
            // 
            this.cbFindRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomType.FormattingEnabled = true;
            this.cbFindRoomType.Location = new System.Drawing.Point(100, 99);
            this.cbFindRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomType.Name = "cbFindRoomType";
            this.cbFindRoomType.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomType.TabIndex = 11;
            this.cbFindRoomType.SelectedIndexChanged += new System.EventHandler(this.CbFindRoomType_SelectedIndexChanged);
            // 
            // cbFindRoomID
            // 
            this.cbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomID.FormattingEnabled = true;
            this.cbFindRoomID.Location = new System.Drawing.Point(100, 57);
            this.cbFindRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomID.Name = "cbFindRoomID";
            this.cbFindRoomID.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomID.TabIndex = 10;
            // 
            // lbFindRoomStatus
            // 
            this.lbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomStatus.Appearance.Options.UseFont = true;
            this.lbFindRoomStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomStatus.Location = new System.Drawing.Point(29, 188);
            this.lbFindRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomStatus.Name = "lbFindRoomStatus";
            this.lbFindRoomStatus.Size = new System.Drawing.Size(65, 13);
            this.lbFindRoomStatus.TabIndex = 9;
            this.lbFindRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // lbFindRoomPrice
            // 
            this.lbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomPrice.Appearance.Options.UseFont = true;
            this.lbFindRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomPrice.Location = new System.Drawing.Point(46, 147);
            this.lbFindRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomPrice.Name = "lbFindRoomPrice";
            this.lbFindRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbFindRoomPrice.TabIndex = 7;
            this.lbFindRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbFindRoomType
            // 
            this.lbFindRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomType.Appearance.Options.UseFont = true;
            this.lbFindRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomType.Location = new System.Drawing.Point(28, 102);
            this.lbFindRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomType.Name = "lbFindRoomType";
            this.lbFindRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbFindRoomType.TabIndex = 5;
            this.lbFindRoomType.Text = "LOẠI PHÒNG:";
            // 
            // lbFindRoomID
            // 
            this.lbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomID.Appearance.Options.UseFont = true;
            this.lbFindRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomID.Location = new System.Drawing.Point(55, 60);
            this.lbFindRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomID.Name = "lbFindRoomID";
            this.lbFindRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbFindRoomID.TabIndex = 1;
            this.lbFindRoomID.Text = "PHÒNG:";
            // 
            // gcRoomList
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.gcRoomList, 2);
            this.gcRoomList.Controls.Add(this.dgvFindRoom);
            this.gcRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomList.Location = new System.Drawing.Point(3, 262);
            this.gcRoomList.Name = "gcRoomList";
            this.gcRoomList.Size = new System.Drawing.Size(944, 384);
            this.gcRoomList.TabIndex = 2;
            this.gcRoomList.Text = "DANH MỤC PHÒNG TRA CỨU";
            // 
            // dgvFindRoom
            // 
            this.dgvFindRoom.AllowUserToAddRows = false;
            this.dgvFindRoom.AllowUserToDeleteRows = false;
            this.dgvFindRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FindRoomID,
            this.FindRoomType,
            this.FindRoomPrice,
            this.FindRoomStatus,
            this.FindRoomNote});
            this.dgvFindRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFindRoom.Location = new System.Drawing.Point(2, 23);
            this.dgvFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFindRoom.MultiSelect = false;
            this.dgvFindRoom.Name = "dgvFindRoom";
            this.dgvFindRoom.ReadOnly = true;
            this.dgvFindRoom.RowTemplate.Height = 24;
            this.dgvFindRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindRoom.Size = new System.Drawing.Size(940, 359);
            this.dgvFindRoom.TabIndex = 16;
            this.dgvFindRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindRoom_CellContentClick);
            this.dgvFindRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFoundRoom_CellEnter);
            this.dgvFindRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // FindRoomID
            // 
            this.FindRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomID.DataPropertyName = "MaPhong";
            this.FindRoomID.HeaderText = "PHÒNG";
            this.FindRoomID.Name = "FindRoomID";
            this.FindRoomID.ReadOnly = true;
            // 
            // FindRoomType
            // 
            this.FindRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomType.DataPropertyName = "MaLoaiPhong";
            this.FindRoomType.HeaderText = "LOẠI PHÒNG";
            this.FindRoomType.Name = "FindRoomType";
            this.FindRoomType.ReadOnly = true;
            // 
            // FindRoomPrice
            // 
            this.FindRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomPrice.DataPropertyName = "DonGia";
            this.FindRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.FindRoomPrice.Name = "FindRoomPrice";
            this.FindRoomPrice.ReadOnly = true;
            // 
            // FindRoomStatus
            // 
            this.FindRoomStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomStatus.DataPropertyName = "TenTinhTrang";
            this.FindRoomStatus.HeaderText = "TÌNH TRẠNG";
            this.FindRoomStatus.Name = "FindRoomStatus";
            this.FindRoomStatus.ReadOnly = true;
            // 
            // FindRoomNote
            // 
            this.FindRoomNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomNote.DataPropertyName = "GhiChu";
            this.FindRoomNote.HeaderText = "GHI CHÚ";
            this.FindRoomNote.Name = "FindRoomNote";
            this.FindRoomNote.ReadOnly = true;
            // 
            // gcFindroomData
            // 
            this.gcFindroomData.Controls.Add(this.tbFindRoomStatus);
            this.gcFindroomData.Controls.Add(this.tbFindRoomType);
            this.gcFindroomData.Controls.Add(this.rtbFindRoomNote);
            this.gcFindroomData.Controls.Add(this.tbFindRoomPrice);
            this.gcFindroomData.Controls.Add(this.tbFindRoomID);
            this.gcFindroomData.Controls.Add(this.lbFindRoomStatus2);
            this.gcFindroomData.Controls.Add(this.lbFindRoomType2);
            this.gcFindroomData.Controls.Add(this.lbFindRoomNote);
            this.gcFindroomData.Controls.Add(this.lbFindRoomPrice2);
            this.gcFindroomData.Controls.Add(this.lbFindRoomID2);
            this.gcFindroomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFindroomData.Location = new System.Drawing.Point(383, 3);
            this.gcFindroomData.Name = "gcFindroomData";
            this.gcFindroomData.Size = new System.Drawing.Size(564, 253);
            this.gcFindroomData.TabIndex = 1;
            this.gcFindroomData.Text = "THÔNG TIN PHÒNG";
            this.gcFindroomData.Paint += new System.Windows.Forms.PaintEventHandler(this.gcFindroomData_Paint);
            // 
            // tbFindRoomStatus
            // 
            this.tbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomStatus.Location = new System.Drawing.Point(342, 99);
            this.tbFindRoomStatus.Name = "tbFindRoomStatus";
            this.tbFindRoomStatus.ReadOnly = true;
            this.tbFindRoomStatus.Size = new System.Drawing.Size(118, 21);
            this.tbFindRoomStatus.TabIndex = 23;
            this.tbFindRoomStatus.TabStop = false;
            // 
            // tbFindRoomType
            // 
            this.tbFindRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomType.Location = new System.Drawing.Point(343, 55);
            this.tbFindRoomType.Name = "tbFindRoomType";
            this.tbFindRoomType.ReadOnly = true;
            this.tbFindRoomType.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomType.TabIndex = 22;
            this.tbFindRoomType.TabStop = false;
            // 
            // rtbFindRoomNote
            // 
            this.rtbFindRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFindRoomNote.BackColor = System.Drawing.SystemColors.Control;
            this.rtbFindRoomNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFindRoomNote.Location = new System.Drawing.Point(126, 150);
            this.rtbFindRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFindRoomNote.Name = "rtbFindRoomNote";
            this.rtbFindRoomNote.ReadOnly = true;
            this.rtbFindRoomNote.Size = new System.Drawing.Size(334, 61);
            this.rtbFindRoomNote.TabIndex = 21;
            this.rtbFindRoomNote.TabStop = false;
            this.rtbFindRoomNote.Text = "";
            // 
            // tbFindRoomPrice
            // 
            this.tbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomPrice.Location = new System.Drawing.Point(126, 97);
            this.tbFindRoomPrice.Name = "tbFindRoomPrice";
            this.tbFindRoomPrice.ReadOnly = true;
            this.tbFindRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomPrice.TabIndex = 20;
            this.tbFindRoomPrice.TabStop = false;
            // 
            // tbFindRoomID
            // 
            this.tbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomID.Location = new System.Drawing.Point(126, 55);
            this.tbFindRoomID.Name = "tbFindRoomID";
            this.tbFindRoomID.ReadOnly = true;
            this.tbFindRoomID.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomID.TabIndex = 19;
            this.tbFindRoomID.TabStop = false;
            // 
            // lbFindRoomStatus2
            // 
            this.lbFindRoomStatus2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomStatus2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomStatus2.Appearance.Options.UseFont = true;
            this.lbFindRoomStatus2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomStatus2.Location = new System.Drawing.Point(271, 102);
            this.lbFindRoomStatus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomStatus2.Name = "lbFindRoomStatus2";
            this.lbFindRoomStatus2.Size = new System.Drawing.Size(65, 13);
            this.lbFindRoomStatus2.TabIndex = 18;
            this.lbFindRoomStatus2.Text = "TÌNH TRẠNG:";
            // 
            // lbFindRoomType2
            // 
            this.lbFindRoomType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomType2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomType2.Appearance.Options.UseFont = true;
            this.lbFindRoomType2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomType2.Location = new System.Drawing.Point(271, 58);
            this.lbFindRoomType2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomType2.Name = "lbFindRoomType2";
            this.lbFindRoomType2.Size = new System.Drawing.Size(66, 13);
            this.lbFindRoomType2.TabIndex = 17;
            this.lbFindRoomType2.Text = "LOẠI PHÒNG:";
            // 
            // lbFindRoomNote
            // 
            this.lbFindRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomNote.Appearance.Options.UseFont = true;
            this.lbFindRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomNote.Location = new System.Drawing.Point(74, 150);
            this.lbFindRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomNote.Name = "lbFindRoomNote";
            this.lbFindRoomNote.Size = new System.Drawing.Size(46, 13);
            this.lbFindRoomNote.TabIndex = 16;
            this.lbFindRoomNote.Text = "GHI CHÚ:";
            // 
            // lbFindRoomPrice2
            // 
            this.lbFindRoomPrice2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomPrice2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomPrice2.Appearance.Options.UseFont = true;
            this.lbFindRoomPrice2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomPrice2.Location = new System.Drawing.Point(72, 100);
            this.lbFindRoomPrice2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomPrice2.Name = "lbFindRoomPrice2";
            this.lbFindRoomPrice2.Size = new System.Drawing.Size(48, 13);
            this.lbFindRoomPrice2.TabIndex = 7;
            this.lbFindRoomPrice2.Text = "ĐƠN GIÁ:";
            // 
            // lbFindRoomID2
            // 
            this.lbFindRoomID2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomID2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomID2.Appearance.Options.UseFont = true;
            this.lbFindRoomID2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomID2.Location = new System.Drawing.Point(81, 58);
            this.lbFindRoomID2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomID2.Name = "lbFindRoomID2";
            this.lbFindRoomID2.Size = new System.Drawing.Size(39, 13);
            this.lbFindRoomID2.TabIndex = 1;
            this.lbFindRoomID2.Text = "PHÒNG:";
            this.lbFindRoomID2.Click += new System.EventHandler(this.lbFindRoomID2_Click);
            // 
            // tabRoomBill
            // 
            this.tabRoomBill.Controls.Add(this.tableLayoutPanel4);
            //this.tabRoomBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRoomBill.ImageOptions.Image")));
            this.tabRoomBill.Name = "tabRoomBill";
            this.tabRoomBill.Size = new System.Drawing.Size(950, 649);
            this.tabRoomBill.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.Controls.Add(this.btnCreateBillRoom, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.gcRoomBill, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.gcBill, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancelBillRoom, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.gcRoomBillData, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gcAddRoomBill, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(950, 649);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnCreateBillRoom
            // 
            this.btnCreateBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateBillRoom.Enabled = false;
            //this.btnCreateBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBillRoom.ImageOptions.Image")));
            this.btnCreateBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateBillRoom.Location = new System.Drawing.Point(753, 610);
            this.btnCreateBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBillRoom.Name = "btnCreateBillRoom";
            this.btnCreateBillRoom.Size = new System.Drawing.Size(194, 37);
            this.btnCreateBillRoom.TabIndex = 28;
            this.btnCreateBillRoom.Text = "LẬP HOÁ ĐƠN";
            this.btnCreateBillRoom.Click += new System.EventHandler(this.btnCreateBillRoom_Click);
            // 
            // gcRoomBill
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.gcRoomBill, 3);
            this.gcRoomBill.Controls.Add(this.dgvBillRoom);
            this.gcRoomBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomBill.Location = new System.Drawing.Point(3, 307);
            this.gcRoomBill.Name = "gcRoomBill";
            this.gcRoomBill.Size = new System.Drawing.Size(944, 298);
            this.gcRoomBill.TabIndex = 3;
            this.gcRoomBill.Text = "DANH MỤC THANH TOÁN";
            // 
            // dgvBillRoom
            // 
            this.dgvBillRoom.AllowUserToAddRows = false;
            this.dgvBillRoom.AllowUserToDeleteRows = false;
            this.dgvBillRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaidRoomID,
            this.PaidRoomRentDays,
            this.PaidRoomPrice,
            this.OverCustomerTax,
            this.ForeignCustomerTax,
            this.PaidRoomTotalPrice});
            this.dgvBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillRoom.Location = new System.Drawing.Point(2, 23);
            this.dgvBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillRoom.MultiSelect = false;
            this.dgvBillRoom.Name = "dgvBillRoom";
            this.dgvBillRoom.ReadOnly = true;
            this.dgvBillRoom.RowTemplate.Height = 24;
            this.dgvBillRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillRoom.Size = new System.Drawing.Size(940, 273);
            this.dgvBillRoom.TabIndex = 3;
            this.dgvBillRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBillRoom_CellEnter);
            this.dgvBillRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            this.dgvBillRoom.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvBillRoom_RowsAdded);
            this.dgvBillRoom.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvBillRoom_RowsRemoved);
            // 
            // PaidRoomID
            // 
            this.PaidRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomID.DataPropertyName = "MaPhong";
            this.PaidRoomID.HeaderText = "PHÒNG";
            this.PaidRoomID.Name = "PaidRoomID";
            this.PaidRoomID.ReadOnly = true;
            // 
            // PaidRoomRentDays
            // 
            this.PaidRoomRentDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomRentDays.DataPropertyName = "SoNgayThue";
            this.PaidRoomRentDays.HeaderText = "SỐ NGÀY THUÊ";
            this.PaidRoomRentDays.Name = "PaidRoomRentDays";
            this.PaidRoomRentDays.ReadOnly = true;
            // 
            // PaidRoomPrice
            // 
            this.PaidRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomPrice.DataPropertyName = "DonGia";
            this.PaidRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.PaidRoomPrice.Name = "PaidRoomPrice";
            this.PaidRoomPrice.ReadOnly = true;
            // 
            // OverCustomerTax
            // 
            this.OverCustomerTax.HeaderText = "PHỤ THU KHÁCH THÊM (VND)";
            this.OverCustomerTax.Name = "OverCustomerTax";
            this.OverCustomerTax.ReadOnly = true;
            this.OverCustomerTax.Visible = false;
            // 
            // ForeignCustomerTax
            // 
            this.ForeignCustomerTax.HeaderText = "PHỤ THU KHÁCH NƯỚC NGOÀI (VND)";
            this.ForeignCustomerTax.Name = "ForeignCustomerTax";
            this.ForeignCustomerTax.ReadOnly = true;
            this.ForeignCustomerTax.Visible = false;
            // 
            // PaidRoomTotalPrice
            // 
            this.PaidRoomTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomTotalPrice.DataPropertyName = "ThanhTien";
            this.PaidRoomTotalPrice.HeaderText = "THÀNH TIỀN (VND)";
            this.PaidRoomTotalPrice.Name = "PaidRoomTotalPrice";
            this.PaidRoomTotalPrice.ReadOnly = true;
            // 
            // gcBill
            // 
            this.gcBill.Controls.Add(this.btnLockBill);
            this.gcBill.Controls.Add(this.rtbBillCustomerAddress);
            this.gcBill.Controls.Add(this.deBillDate);
            this.gcBill.Controls.Add(this.tbBillCustomerName);
            this.gcBill.Controls.Add(this.lbBillCustomerAddress);
            this.gcBill.Controls.Add(this.lbBillDate);
            this.gcBill.Controls.Add(this.lbBillCustomerName);
            this.gcBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBill.Location = new System.Drawing.Point(3, 3);
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(369, 298);
            this.gcBill.TabIndex = 0;
            this.gcBill.Text = "THÔNG TIN THANH TOÁN";
            // 
            // btnLockBill
            // 
            this.btnLockBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnLockBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLockBill.ImageOptions.Image")));
            this.btnLockBill.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLockBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLockBill.Location = new System.Drawing.Point(246, 100);
            this.btnLockBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockBill.Name = "btnLockBill";
            this.btnLockBill.Size = new System.Drawing.Size(106, 138);
            this.btnLockBill.TabIndex = 18;
            this.btnLockBill.Text = "\r\nXÁC NHẬN";
            this.btnLockBill.EnabledChanged += new System.EventHandler(this.BtnLockBill_EnabledChanged);
            this.btnLockBill.Click += new System.EventHandler(this.btnLockBill_Click);
            // 
            // rtbBillCustomerAddress
            // 
            this.rtbBillCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbBillCustomerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbBillCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBillCustomerAddress.Location = new System.Drawing.Point(83, 186);
            this.rtbBillCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbBillCustomerAddress.Name = "rtbBillCustomerAddress";
            this.rtbBillCustomerAddress.Size = new System.Drawing.Size(157, 53);
            this.rtbBillCustomerAddress.TabIndex = 10;
            this.rtbBillCustomerAddress.Text = "";
            // 
            // deBillDate
            // 
            this.deBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deBillDate.EditValue = null;
            this.deBillDate.Location = new System.Drawing.Point(83, 144);
            this.deBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deBillDate.Name = "deBillDate";
            this.deBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBillDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBillDate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deBillDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deBillDate.Size = new System.Drawing.Size(157, 20);
            this.deBillDate.TabIndex = 9;
            // 
            // tbBillCustomerName
            // 
            this.tbBillCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillCustomerName.Location = new System.Drawing.Point(83, 100);
            this.tbBillCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBillCustomerName.MaxLength = 30;
            this.tbBillCustomerName.Name = "tbBillCustomerName";
            this.tbBillCustomerName.Size = new System.Drawing.Size(157, 21);
            this.tbBillCustomerName.TabIndex = 8;
            // 
            // lbBillCustomerAddress
            // 
            this.lbBillCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomerAddress.Appearance.Options.UseFont = true;
            this.lbBillCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomerAddress.Location = new System.Drawing.Point(33, 188);
            this.lbBillCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomerAddress.Name = "lbBillCustomerAddress";
            this.lbBillCustomerAddress.Size = new System.Drawing.Size(44, 13);
            this.lbBillCustomerAddress.TabIndex = 7;
            this.lbBillCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // lbBillDate
            // 
            this.lbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillDate.Appearance.Options.UseFont = true;
            this.lbBillDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillDate.Location = new System.Drawing.Point(23, 147);
            this.lbBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(54, 13);
            this.lbBillDate.TabIndex = 5;
            this.lbBillDate.Text = "NGÀY TRẢ:";
            // 
            // lbBillCustomerName
            // 
            this.lbBillCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomerName.Appearance.Options.UseFont = true;
            this.lbBillCustomerName.Appearance.Options.UseTextOptions = true;
            this.lbBillCustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbBillCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomerName.Location = new System.Drawing.Point(17, 95);
            this.lbBillCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomerName.Name = "lbBillCustomerName";
            this.lbBillCustomerName.Size = new System.Drawing.Size(60, 26);
            this.lbBillCustomerName.TabIndex = 1;
            this.lbBillCustomerName.Text = "TÊN KHÁCH/\r\nCƠ QUAN:";
            // 
            // btnCancelBillRoom
            // 
            this.btnCancelBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelBillRoom.Enabled = false;
            //this.btnCancelBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelBillRoom.ImageOptions.Image")));
            this.btnCancelBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelBillRoom.Location = new System.Drawing.Point(3, 610);
            this.btnCancelBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBillRoom.Name = "btnCancelBillRoom";
            this.btnCancelBillRoom.Size = new System.Drawing.Size(369, 37);
            this.btnCancelBillRoom.TabIndex = 16;
            this.btnCancelBillRoom.Text = "HUỶ HOÁ ĐƠN";
            this.btnCancelBillRoom.Click += new System.EventHandler(this.btnCancelBillRoom_Click);
            // 
            // gcRoomBillData
            // 
            this.gcRoomBillData.Controls.Add(this.btnDelBillRoom);
            this.gcRoomBillData.Controls.Add(this.tbBillRoomCost);
            this.gcRoomBillData.Controls.Add(this.tbBillRoomPrice);
            this.gcRoomBillData.Controls.Add(this.tbBillRoomDay);
            this.gcRoomBillData.Controls.Add(this.tbBillRoomID);
            this.gcRoomBillData.Controls.Add(this.lbBillRoomCost);
            this.gcRoomBillData.Controls.Add(this.lbBillRoomPrice);
            this.gcRoomBillData.Controls.Add(this.lbBillRoomDay);
            this.gcRoomBillData.Controls.Add(this.lbBillRoomID);
            this.gcRoomBillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomBillData.Location = new System.Drawing.Point(378, 3);
            this.gcRoomBillData.Name = "gcRoomBillData";
            this.gcRoomBillData.Size = new System.Drawing.Size(369, 298);
            this.gcRoomBillData.TabIndex = 1;
            this.gcRoomBillData.Text = "THÔNG TIN PHÒNG";
            // 
            // btnDelBillRoom
            // 
            this.btnDelBillRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelBillRoom.Enabled = false;
            //this.btnDelBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelBillRoom.ImageOptions.Image")));
            this.btnDelBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDelBillRoom.Location = new System.Drawing.Point(231, 105);
            this.btnDelBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelBillRoom.Name = "btnDelBillRoom";
            this.btnDelBillRoom.Size = new System.Drawing.Size(106, 133);
            this.btnDelBillRoom.TabIndex = 27;
            this.btnDelBillRoom.Text = "\r\nXÓA";
            this.btnDelBillRoom.Click += new System.EventHandler(this.btnDelBillRoom_Click);
            // 
            // tbBillRoomCost
            // 
            this.tbBillRoomCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomCost.Location = new System.Drawing.Point(88, 211);
            this.tbBillRoomCost.Name = "tbBillRoomCost";
            this.tbBillRoomCost.ReadOnly = true;
            this.tbBillRoomCost.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomCost.TabIndex = 26;
            this.tbBillRoomCost.TabStop = false;
            // 
            // tbBillRoomPrice
            // 
            this.tbBillRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomPrice.Location = new System.Drawing.Point(88, 178);
            this.tbBillRoomPrice.Name = "tbBillRoomPrice";
            this.tbBillRoomPrice.ReadOnly = true;
            this.tbBillRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomPrice.TabIndex = 25;
            this.tbBillRoomPrice.TabStop = false;
            // 
            // tbBillRoomDay
            // 
            this.tbBillRoomDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomDay.Location = new System.Drawing.Point(88, 144);
            this.tbBillRoomDay.Name = "tbBillRoomDay";
            this.tbBillRoomDay.ReadOnly = true;
            this.tbBillRoomDay.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomDay.TabIndex = 24;
            this.tbBillRoomDay.TabStop = false;
            // 
            // tbBillRoomID
            // 
            this.tbBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomID.Location = new System.Drawing.Point(88, 105);
            this.tbBillRoomID.Name = "tbBillRoomID";
            this.tbBillRoomID.ReadOnly = true;
            this.tbBillRoomID.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomID.TabIndex = 23;
            this.tbBillRoomID.TabStop = false;
            // 
            // lbBillRoomCost
            // 
            this.lbBillRoomCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomCost.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomCost.Appearance.Options.UseFont = true;
            this.lbBillRoomCost.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomCost.Location = new System.Drawing.Point(18, 214);
            this.lbBillRoomCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomCost.Name = "lbBillRoomCost";
            this.lbBillRoomCost.Size = new System.Drawing.Size(64, 13);
            this.lbBillRoomCost.TabIndex = 19;
            this.lbBillRoomCost.Text = "THÀNH TIỀN:";
            // 
            // lbBillRoomPrice
            // 
            this.lbBillRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomPrice.Appearance.Options.UseFont = true;
            this.lbBillRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomPrice.Location = new System.Drawing.Point(34, 181);
            this.lbBillRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomPrice.Name = "lbBillRoomPrice";
            this.lbBillRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbBillRoomPrice.TabIndex = 18;
            this.lbBillRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbBillRoomDay
            // 
            this.lbBillRoomDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomDay.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomDay.Appearance.Options.UseFont = true;
            this.lbBillRoomDay.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomDay.Location = new System.Drawing.Point(5, 147);
            this.lbBillRoomDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomDay.Name = "lbBillRoomDay";
            this.lbBillRoomDay.Size = new System.Drawing.Size(77, 13);
            this.lbBillRoomDay.TabIndex = 17;
            this.lbBillRoomDay.Text = "SỐ NGÀY THUÊ:";
            // 
            // lbBillRoomID
            // 
            this.lbBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomID.Appearance.Options.UseFont = true;
            this.lbBillRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomID.Location = new System.Drawing.Point(43, 108);
            this.lbBillRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomID.Name = "lbBillRoomID";
            this.lbBillRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbBillRoomID.TabIndex = 16;
            this.lbBillRoomID.Text = "PHÒNG:";
            // 
            // gcAddRoomBill
            // 
            this.gcAddRoomBill.Controls.Add(this.btnAddBillRoom);
            this.gcAddRoomBill.Controls.Add(this.cbAddBillRoomID);
            this.gcAddRoomBill.Controls.Add(this.lbAddBillRoomID);
            this.gcAddRoomBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAddRoomBill.Location = new System.Drawing.Point(753, 3);
            this.gcAddRoomBill.Name = "gcAddRoomBill";
            this.gcAddRoomBill.Size = new System.Drawing.Size(194, 298);
            this.gcAddRoomBill.TabIndex = 2;
            this.gcAddRoomBill.Text = "THÊM PHÒNG TRẢ";
            // 
            // btnAddBillRoom
            // 
            this.btnAddBillRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBillRoom.Enabled = false;
            //this.btnAddBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBillRoom.ImageOptions.Image")));
            this.btnAddBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddBillRoom.Location = new System.Drawing.Point(37, 168);
            this.btnAddBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBillRoom.Name = "btnAddBillRoom";
            this.btnAddBillRoom.Size = new System.Drawing.Size(120, 64);
            this.btnAddBillRoom.TabIndex = 24;
            this.btnAddBillRoom.Text = "THÊM";
            this.btnAddBillRoom.Click += new System.EventHandler(this.btnAddBillRoom_Click);
            // 
            // cbAddBillRoomID
            // 
            this.cbAddBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAddBillRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddBillRoomID.Enabled = false;
            this.cbAddBillRoomID.FormattingEnabled = true;
            this.cbAddBillRoomID.Location = new System.Drawing.Point(37, 139);
            this.cbAddBillRoomID.Name = "cbAddBillRoomID";
            this.cbAddBillRoomID.Size = new System.Drawing.Size(120, 21);
            this.cbAddBillRoomID.Sorted = true;
            this.cbAddBillRoomID.TabIndex = 23;
            // 
            // lbAddBillRoomID
            // 
            this.lbAddBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAddBillRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAddBillRoomID.Appearance.Options.UseFont = true;
            this.lbAddBillRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAddBillRoomID.Location = new System.Drawing.Point(63, 108);
            this.lbAddBillRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAddBillRoomID.Name = "lbAddBillRoomID";
            this.lbAddBillRoomID.Size = new System.Drawing.Size(71, 13);
            this.lbAddBillRoomID.TabIndex = 22;
            this.lbAddBillRoomID.Text = "CHỌN PHÒNG:";
            // 
            // tabMonthReport
            // 
            this.tabMonthReport.Controls.Add(this.tableLayoutPanel5);
            //this.tabMonthReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabMonthReport.ImageOptions.Image")));
            this.tabMonthReport.Name = "tabMonthReport";
            this.tabMonthReport.Size = new System.Drawing.Size(950, 649);
            this.tabMonthReport.Text = "BÁO CÁO DOANH THU";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gcMonthReportSelect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gcMonthReportList, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(950, 649);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // gcMonthReportSelect
            // 
            this.gcMonthReportSelect.Controls.Add(this.cbRevenueYear);
            this.gcMonthReportSelect.Controls.Add(this.labelControl1);
            this.gcMonthReportSelect.Controls.Add(this.btnCreateMonthRevenue);
            this.gcMonthReportSelect.Controls.Add(this.cbRevenueMonth);
            this.gcMonthReportSelect.Controls.Add(this.lbMonthRevenue);
            this.gcMonthReportSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMonthReportSelect.Location = new System.Drawing.Point(3, 3);
            this.gcMonthReportSelect.Name = "gcMonthReportSelect";
            this.gcMonthReportSelect.Size = new System.Drawing.Size(944, 253);
            this.gcMonthReportSelect.TabIndex = 0;
            this.gcMonthReportSelect.Text = "TRA CỨU DOANG THU";
            // 
            // cbRevenueYear
            // 
            this.cbRevenueYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRevenueYear.FormattingEnabled = true;
            this.cbRevenueYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbRevenueYear.Location = new System.Drawing.Point(522, 108);
            this.cbRevenueYear.Name = "cbRevenueYear";
            this.cbRevenueYear.Size = new System.Drawing.Size(74, 21);
            this.cbRevenueYear.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.Location = new System.Drawing.Point(490, 111);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "NĂM:";
            // 
            // btnCreateMonthRevenue
            // 
            this.btnCreateMonthRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnCreateMonthRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMonthRevenue.ImageOptions.Image")));
            this.btnCreateMonthRevenue.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateMonthRevenue.Location = new System.Drawing.Point(649, 96);
            this.btnCreateMonthRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateMonthRevenue.Name = "btnCreateMonthRevenue";
            this.btnCreateMonthRevenue.Size = new System.Drawing.Size(120, 41);
            this.btnCreateMonthRevenue.TabIndex = 5;
            this.btnCreateMonthRevenue.Text = "XUẤT";
            this.btnCreateMonthRevenue.Click += new System.EventHandler(this.btnCreateMonthRevenue_Click);
            // 
            // cbRevenueMonth
            // 
            this.cbRevenueMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRevenueMonth.FormattingEnabled = true;
            this.cbRevenueMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbRevenueMonth.Location = new System.Drawing.Point(363, 108);
            this.cbRevenueMonth.Name = "cbRevenueMonth";
            this.cbRevenueMonth.Size = new System.Drawing.Size(121, 21);
            this.cbRevenueMonth.TabIndex = 4;
            // 
            // lbMonthRevenue
            // 
            this.lbMonthRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMonthRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMonthRevenue.Appearance.Options.UseFont = true;
            this.lbMonthRevenue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMonthRevenue.Location = new System.Drawing.Point(257, 111);
            this.lbMonthRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMonthRevenue.Name = "lbMonthRevenue";
            this.lbMonthRevenue.Size = new System.Drawing.Size(100, 13);
            this.lbMonthRevenue.TabIndex = 1;
            this.lbMonthRevenue.Text = "DOANH THU THÁNG:";
            // 
            // gcMonthReportList
            // 
            this.gcMonthReportList.Controls.Add(this.dgvRevenueList);
            this.gcMonthReportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMonthReportList.Location = new System.Drawing.Point(3, 262);
            this.gcMonthReportList.Name = "gcMonthReportList";
            this.gcMonthReportList.Size = new System.Drawing.Size(944, 384);
            this.gcMonthReportList.TabIndex = 1;
            this.gcMonthReportList.Text = "DANH MỤC DOANH THU";
            // 
            // dgvRevenueList
            // 
            this.dgvRevenueList.AllowUserToAddRows = false;
            this.dgvRevenueList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevenueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportedRoomType,
            this.ReportedRoomRevenue,
            this.ReportedRoomPercentage});
            this.dgvRevenueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenueList.Location = new System.Drawing.Point(2, 23);
            this.dgvRevenueList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRevenueList.Name = "dgvRevenueList";
            this.dgvRevenueList.ReadOnly = true;
            this.dgvRevenueList.RowTemplate.Height = 24;
            this.dgvRevenueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenueList.Size = new System.Drawing.Size(940, 359);
            this.dgvRevenueList.TabIndex = 3;
            // 
            // ReportedRoomType
            // 
            this.ReportedRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomType.DataPropertyName = "LoaiPhong";
            this.ReportedRoomType.HeaderText = "LOẠI PHÒNG";
            this.ReportedRoomType.Name = "ReportedRoomType";
            this.ReportedRoomType.ReadOnly = true;
            // 
            // ReportedRoomRevenue
            // 
            this.ReportedRoomRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomRevenue.DataPropertyName = "DoanhThu";
            this.ReportedRoomRevenue.HeaderText = "DOANH THU (VND)";
            this.ReportedRoomRevenue.Name = "ReportedRoomRevenue";
            this.ReportedRoomRevenue.ReadOnly = true;
            // 
            // ReportedRoomPercentage
            // 
            this.ReportedRoomPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomPercentage.DataPropertyName = "TiLe";
            this.ReportedRoomPercentage.HeaderText = "TỈ LỆ (%)";
            this.ReportedRoomPercentage.Name = "ReportedRoomPercentage";
            this.ReportedRoomPercentage.ReadOnly = true;
            // 
            // tabRoomRules
            // 
            this.tabRoomRules.Controls.Add(this.gcCustomerTypeList);
            this.tabRoomRules.Controls.Add(this.gcRoomTypeList);
            this.tabRoomRules.Controls.Add(this.gcEditRule);
            //this.tabRoomRules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRoomRules.ImageOptions.Image")));
            this.tabRoomRules.Name = "tabRoomRules";
            this.tabRoomRules.Size = new System.Drawing.Size(950, 649);
            this.tabRoomRules.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // gcCustomerTypeList
            // 
            this.gcCustomerTypeList.Controls.Add(this.btnEditCustomerType);
            this.gcCustomerTypeList.Controls.Add(this.btnDelCustomerType);
            this.gcCustomerTypeList.Controls.Add(this.btnAddCustomerType);
            this.gcCustomerTypeList.Controls.Add(this.dgvCustomerType);
            this.gcCustomerTypeList.Location = new System.Drawing.Point(451, 221);
            this.gcCustomerTypeList.Name = "gcCustomerTypeList";
            this.gcCustomerTypeList.Size = new System.Drawing.Size(446, 417);
            this.gcCustomerTypeList.TabIndex = 2;
            this.gcCustomerTypeList.Text = "DANH MỤC CÁC LOẠI KHÁCH";
            // 
            // btnEditCustomerType
            // 
            //this.btnEditCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerType.Appearance.Image")));
            this.btnEditCustomerType.Appearance.Options.UseImage = true;
            //this.btnEditCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerType.ImageOptions.Image")));
            this.btnEditCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditCustomerType.Location = new System.Drawing.Point(307, 372);
            this.btnEditCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCustomerType.Name = "btnEditCustomerType";
            this.btnEditCustomerType.Size = new System.Drawing.Size(134, 41);
            this.btnEditCustomerType.TabIndex = 6;
            this.btnEditCustomerType.Text = "SỬA LOẠI KHÁCH";
            this.btnEditCustomerType.Click += new System.EventHandler(this.btnEditCustomerType_Click);
            // 
            // btnDelCustomerType
            // 
            //this.btnDelCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCustomerType.Appearance.Image")));
            this.btnDelCustomerType.Appearance.Options.UseImage = true;
            //this.btnDelCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCustomerType.ImageOptions.Image")));
            this.btnDelCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelCustomerType.Location = new System.Drawing.Point(153, 372);
            this.btnDelCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCustomerType.Name = "btnDelCustomerType";
            this.btnDelCustomerType.Size = new System.Drawing.Size(148, 41);
            this.btnDelCustomerType.TabIndex = 5;
            this.btnDelCustomerType.Text = "XOÁ LOẠI KHÁCH";
            this.btnDelCustomerType.Click += new System.EventHandler(this.btnDelCustomerType_Click);
            // 
            // btnAddCustomerType
            // 
            //this.btnAddCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerType.Appearance.Image")));
            this.btnAddCustomerType.Appearance.Options.UseImage = true;
            //this.btnAddCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerType.ImageOptions.Image")));
            this.btnAddCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCustomerType.Location = new System.Drawing.Point(5, 372);
            this.btnAddCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomerType.Name = "btnAddCustomerType";
            this.btnAddCustomerType.Size = new System.Drawing.Size(142, 41);
            this.btnAddCustomerType.TabIndex = 4;
            this.btnAddCustomerType.Text = "THÊM LOẠI KHÁCH";
            this.btnAddCustomerType.Click += new System.EventHandler(this.btnAddCustomerType_Click);
            // 
            // dgvCustomerType
            // 
            this.dgvCustomerType.AllowUserToAddRows = false;
            this.dgvCustomerType.AllowUserToDeleteRows = false;
            this.dgvCustomerType.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCustomerTypeID,
            this.EditCustomerTypeName,
            this.CustomerSurcharge});
            this.dgvCustomerType.Location = new System.Drawing.Point(0, 25);
            this.dgvCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomerType.Name = "dgvCustomerType";
            this.dgvCustomerType.ReadOnly = true;
            this.dgvCustomerType.RowTemplate.Height = 24;
            this.dgvCustomerType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerType.Size = new System.Drawing.Size(438, 343);
            this.dgvCustomerType.TabIndex = 1;
            this.dgvCustomerType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // EditCustomerTypeID
            // 
            this.EditCustomerTypeID.DataPropertyName = "MaLoaiKhachHang";
            this.EditCustomerTypeID.HeaderText = "MÃ LOẠI KHÁCH";
            this.EditCustomerTypeID.Name = "EditCustomerTypeID";
            this.EditCustomerTypeID.ReadOnly = true;
            this.EditCustomerTypeID.Visible = false;
            // 
            // EditCustomerTypeName
            // 
            this.EditCustomerTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditCustomerTypeName.DataPropertyName = "TenLoaiKhachHang";
            this.EditCustomerTypeName.HeaderText = "LOẠI KHÁCH";
            this.EditCustomerTypeName.Name = "EditCustomerTypeName";
            this.EditCustomerTypeName.ReadOnly = true;
            // 
            // CustomerSurcharge
            // 
            this.CustomerSurcharge.DataPropertyName = "HeSoPhuThu";
            this.CustomerSurcharge.HeaderText = "HỆ SỐ PHỤ THU (%)";
            this.CustomerSurcharge.Name = "CustomerSurcharge";
            this.CustomerSurcharge.ReadOnly = true;
            this.CustomerSurcharge.Width = 150;
            // 
            // gcRoomTypeList
            // 
            this.gcRoomTypeList.Controls.Add(this.btnEditRoomType);
            this.gcRoomTypeList.Controls.Add(this.btnDelRoomType);
            this.gcRoomTypeList.Controls.Add(this.btnAddRoomType);
            this.gcRoomTypeList.Controls.Add(this.dgvRoomType);
            this.gcRoomTypeList.Location = new System.Drawing.Point(3, 221);
            this.gcRoomTypeList.Name = "gcRoomTypeList";
            this.gcRoomTypeList.Size = new System.Drawing.Size(446, 417);
            this.gcRoomTypeList.TabIndex = 1;
            this.gcRoomTypeList.Text = "ĐƠN GIÁ CÁC LOẠI PHÒNG";
            // 
            // btnEditRoomType
            // 
            //this.btnEditRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoomType.Appearance.Image")));
            this.btnEditRoomType.Appearance.Options.UseImage = true;
            //this.btnEditRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoomType.ImageOptions.Image")));
            this.btnEditRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditRoomType.Location = new System.Drawing.Point(296, 372);
            this.btnEditRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRoomType.Name = "btnEditRoomType";
            this.btnEditRoomType.Size = new System.Drawing.Size(146, 41);
            this.btnEditRoomType.TabIndex = 5;
            this.btnEditRoomType.Text = "SỬA LOẠI PHÒNG";
            this.btnEditRoomType.Click += new System.EventHandler(this.btnEditRoomType_Click);
            // 
            // btnDelRoomType
            // 
            //this.btnDelRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoomType.Appearance.Image")));
            this.btnDelRoomType.Appearance.Options.UseImage = true;
            //this.btnDelRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoomType.ImageOptions.Image")));
            this.btnDelRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelRoomType.Location = new System.Drawing.Point(147, 372);
            this.btnDelRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelRoomType.Name = "btnDelRoomType";
            this.btnDelRoomType.Size = new System.Drawing.Size(143, 41);
            this.btnDelRoomType.TabIndex = 4;
            this.btnDelRoomType.Text = "XOÁ LOẠI PHÒNG";
            this.btnDelRoomType.Click += new System.EventHandler(this.btnDelRoomType_Click);
            // 
            // btnAddRoomType
            // 
            //this.btnAddRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoomType.Appearance.Image")));
            this.btnAddRoomType.Appearance.Options.UseImage = true;
            //this.btnAddRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoomType.ImageOptions.Image")));
            this.btnAddRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddRoomType.Location = new System.Drawing.Point(5, 372);
            this.btnAddRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(136, 41);
            this.btnAddRoomType.TabIndex = 3;
            this.btnAddRoomType.Text = "THÊM LOẠI PHÒNG";
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.AllowUserToAddRows = false;
            this.dgvRoomType.AllowUserToDeleteRows = false;
            this.dgvRoomType.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditRoomTypeID,
            this.EditRoomTypePrice});
            this.dgvRoomType.Location = new System.Drawing.Point(5, 25);
            this.dgvRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            this.dgvRoomType.RowTemplate.Height = 24;
            this.dgvRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomType.Size = new System.Drawing.Size(441, 343);
            this.dgvRoomType.TabIndex = 1;
            this.dgvRoomType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // EditRoomTypeID
            // 
            this.EditRoomTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditRoomTypeID.DataPropertyName = "MaLoaiPhong";
            this.EditRoomTypeID.HeaderText = "LOẠI PHÒNG";
            this.EditRoomTypeID.Name = "EditRoomTypeID";
            this.EditRoomTypeID.ReadOnly = true;
            // 
            // EditRoomTypePrice
            // 
            this.EditRoomTypePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditRoomTypePrice.DataPropertyName = "DonGia";
            this.EditRoomTypePrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.EditRoomTypePrice.Name = "EditRoomTypePrice";
            this.EditRoomTypePrice.ReadOnly = true;
            // 
            // gcEditRule
            // 
            this.gcEditRule.Controls.Add(this.lbAdditionalCustomerSurchargeValue);
            this.gcEditRule.Controls.Add(this.lbMaxCustomerValue);
            this.gcEditRule.Controls.Add(this.btnAdditionalCustomerSurcharge);
            this.gcEditRule.Controls.Add(this.btnEditMaxCustomerRule);
            this.gcEditRule.Controls.Add(this.lbAdditionalCustomerSurcharge);
            this.gcEditRule.Controls.Add(this.lbMaxCustomerRule);
            this.gcEditRule.Location = new System.Drawing.Point(3, 27);
            this.gcEditRule.Name = "gcEditRule";
            this.gcEditRule.Size = new System.Drawing.Size(890, 188);
            this.gcEditRule.TabIndex = 0;
            this.gcEditRule.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // lbAdditionalCustomerSurchargeValue
            // 
            this.lbAdditionalCustomerSurchargeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdditionalCustomerSurchargeValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAdditionalCustomerSurchargeValue.Appearance.Options.UseFont = true;
            this.lbAdditionalCustomerSurchargeValue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAdditionalCustomerSurchargeValue.Location = new System.Drawing.Point(393, 85);
            this.lbAdditionalCustomerSurchargeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdditionalCustomerSurchargeValue.Name = "lbAdditionalCustomerSurchargeValue";
            this.lbAdditionalCustomerSurchargeValue.Size = new System.Drawing.Size(5, 13);
            this.lbAdditionalCustomerSurchargeValue.TabIndex = 41;
            this.lbAdditionalCustomerSurchargeValue.Text = "?";
            // 
            // lbMaxCustomerValue
            // 
            this.lbMaxCustomerValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomerValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomerValue.Appearance.Options.UseFont = true;
            this.lbMaxCustomerValue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomerValue.Location = new System.Drawing.Point(393, 43);
            this.lbMaxCustomerValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaxCustomerValue.Name = "lbMaxCustomerValue";
            this.lbMaxCustomerValue.Size = new System.Drawing.Size(5, 13);
            this.lbMaxCustomerValue.TabIndex = 37;
            this.lbMaxCustomerValue.Text = "?";
            // 
            // btnAdditionalCustomerSurcharge
            // 
            this.btnAdditionalCustomerSurcharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnAdditionalCustomerSurcharge.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAdditionalCustomerSurcharge.Appearance.Image")));
            this.btnAdditionalCustomerSurcharge.Appearance.Options.UseImage = true;
            //this.btnAdditionalCustomerSurcharge.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdditionalCustomerSurcharge.ImageOptions.Image")));
            this.btnAdditionalCustomerSurcharge.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdditionalCustomerSurcharge.Location = new System.Drawing.Point(453, 78);
            this.btnAdditionalCustomerSurcharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdditionalCustomerSurcharge.Name = "btnAdditionalCustomerSurcharge";
            this.btnAdditionalCustomerSurcharge.Size = new System.Drawing.Size(96, 24);
            this.btnAdditionalCustomerSurcharge.TabIndex = 35;
            this.btnAdditionalCustomerSurcharge.Text = "THAY ĐỔI";
            this.btnAdditionalCustomerSurcharge.Click += new System.EventHandler(this.btnAdditionalCustomerSurcharge_Click);
            // 
            // btnEditMaxCustomerRule
            // 
            this.btnEditMaxCustomerRule.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnEditMaxCustomerRule.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMaxCustomerRule.Appearance.Image")));
            this.btnEditMaxCustomerRule.Appearance.Options.UseImage = true;
            //this.btnEditMaxCustomerRule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMaxCustomerRule.ImageOptions.Image")));
            this.btnEditMaxCustomerRule.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditMaxCustomerRule.Location = new System.Drawing.Point(453, 36);
            this.btnEditMaxCustomerRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMaxCustomerRule.Name = "btnEditMaxCustomerRule";
            this.btnEditMaxCustomerRule.Size = new System.Drawing.Size(96, 24);
            this.btnEditMaxCustomerRule.TabIndex = 34;
            this.btnEditMaxCustomerRule.Text = "THAY ĐỔI";
            this.btnEditMaxCustomerRule.Click += new System.EventHandler(this.btnEditMaxCustomerRule_Click);
            // 
            // lbAdditionalCustomerSurcharge
            // 
            this.lbAdditionalCustomerSurcharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdditionalCustomerSurcharge.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAdditionalCustomerSurcharge.Appearance.Options.UseFont = true;
            this.lbAdditionalCustomerSurcharge.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAdditionalCustomerSurcharge.Location = new System.Drawing.Point(232, 85);
            this.lbAdditionalCustomerSurcharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdditionalCustomerSurcharge.Name = "lbAdditionalCustomerSurcharge";
            this.lbAdditionalCustomerSurcharge.Size = new System.Drawing.Size(149, 13);
            this.lbAdditionalCustomerSurcharge.TabIndex = 32;
            this.lbAdditionalCustomerSurcharge.Text = "TỶ LỆ PHỤ THU KHÁCH THỨ 3: ";
            this.lbAdditionalCustomerSurcharge.Click += new System.EventHandler(this.lbAdditionalCustomerSurcharge_Click);
            // 
            // lbMaxCustomerRule
            // 
            this.lbMaxCustomerRule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomerRule.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomerRule.Appearance.Options.UseFont = true;
            this.lbMaxCustomerRule.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomerRule.Location = new System.Drawing.Point(232, 43);
            this.lbMaxCustomerRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaxCustomerRule.Name = "lbMaxCustomerRule";
            this.lbMaxCustomerRule.Size = new System.Drawing.Size(155, 13);
            this.lbMaxCustomerRule.TabIndex = 30;
            this.lbMaxCustomerRule.Text = "SỐ KHÁCH TỐI ĐA MỖI PHÒNG:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 693);
            this.Controls.Add(this.tcHotelManagement);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH SẠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcHotelManagement)).EndInit();
            this.tcHotelManagement.ResumeLayout(false);
            this.tabListRoom.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomData)).EndInit();
            this.gcRoomData.ResumeLayout(false);
            this.gcRoomData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoom)).EndInit();
            this.gcListRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomEdit)).EndInit();
            this.gcRoomEdit.ResumeLayout(false);
            this.tabRoomLease.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUpdateCustomer)).EndInit();
            this.gcUpdateCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerLease)).EndInit();
            this.gcCustomerLease.ResumeLayout(false);
            this.gcCustomerLease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaseCustomerData)).EndInit();
            this.gcLeaseCustomerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomLease)).EndInit();
            this.gcRoomLease.ResumeLayout(false);
            this.gcRoomLease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deLeaseRoomDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLeaseRoomDate.Properties)).EndInit();
            this.tabRoomFind.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoom)).EndInit();
            this.gcFindRoom.ResumeLayout(false);
            this.gcFindRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).EndInit();
            this.gcRoomList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindroomData)).EndInit();
            this.gcFindroomData.ResumeLayout(false);
            this.gcFindroomData.PerformLayout();
            this.tabRoomBill.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomBill)).EndInit();
            this.gcRoomBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            this.gcBill.ResumeLayout(false);
            this.gcBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomBillData)).EndInit();
            this.gcRoomBillData.ResumeLayout(false);
            this.gcRoomBillData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddRoomBill)).EndInit();
            this.gcAddRoomBill.ResumeLayout(false);
            this.gcAddRoomBill.PerformLayout();
            this.tabMonthReport.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMonthReportSelect)).EndInit();
            this.gcMonthReportSelect.ResumeLayout(false);
            this.gcMonthReportSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonthReportList)).EndInit();
            this.gcMonthReportList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueList)).EndInit();
            this.tabRoomRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerTypeList)).EndInit();
            this.gcCustomerTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomTypeList)).EndInit();
            this.gcRoomTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditRule)).EndInit();
            this.gcEditRule.ResumeLayout(false);
            this.gcEditRule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcHotelManagement;
        private DevExpress.XtraTab.XtraTabPage tabListRoom;
        private DevExpress.XtraTab.XtraTabPage tabRoomLease;
        private DevExpress.XtraTab.XtraTabPage tabRoomFind;
        private DevExpress.XtraTab.XtraTabPage tabRoomBill;
        private DevExpress.XtraTab.XtraTabPage tabMonthReport;
        private DevExpress.XtraTab.XtraTabPage tabRoomRules;
        private DevExpress.XtraEditors.GroupControl gcRoomData;
        private System.Windows.Forms.Label lbListRoomID;
        private DevExpress.XtraEditors.GroupControl gcRoomEdit;
        private System.Windows.Forms.RichTextBox rtbListRoomNote;
        private System.Windows.Forms.Label lbListRoomNote;
        private System.Windows.Forms.TextBox tbListRoomPrice;
        private System.Windows.Forms.TextBox tbListRoomType;
        private System.Windows.Forms.Label lbListRoomPrice;
        private System.Windows.Forms.Label lbListRoomType;
        private System.Windows.Forms.TextBox tbListRoomStatus;
        private System.Windows.Forms.TextBox tbListRoomID;
        private System.Windows.Forms.Label lbListRoomStatus;
        private DevExpress.XtraEditors.GroupControl gcListRoom;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRoom;
        private DevExpress.XtraEditors.SimpleButton btnEditRoom;
        private DevExpress.XtraEditors.SimpleButton btnAddRoom;
        private DevExpress.XtraEditors.GroupControl gcRoomLease;
        private System.Windows.Forms.Label lbRoomPrice;
        private System.Windows.Forms.Label lbRoomDate;
        private System.Windows.Forms.Label lbRoomList;
        private DevExpress.XtraEditors.GroupControl gcCustomerLease;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.Label lbCustomerName;
        private DevExpress.XtraEditors.SimpleButton btnLockRoom;
        private DevExpress.XtraEditors.GroupControl gcUpdateCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private System.Windows.Forms.RichTextBox rtbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerID;
        private DevExpress.XtraEditors.GroupControl gcLeaseCustomerData;
        private DevExpress.XtraEditors.SimpleButton btnDeleteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomer;
        private System.Windows.Forms.TextBox tbCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnCreateLease;
        private DevExpress.XtraEditors.SimpleButton btnCancelLease;
        private System.Windows.Forms.DataGridView dgvLeaseCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private DevExpress.XtraEditors.GroupControl gcFindRoom;
        private System.Windows.Forms.ComboBox cbFindRoomStatus;
        private System.Windows.Forms.ComboBox cbFindRoomPrice;
        private System.Windows.Forms.ComboBox cbFindRoomType;
        private System.Windows.Forms.ComboBox cbFindRoomID;
        private DevExpress.XtraEditors.LabelControl lbFindRoomStatus;
        private DevExpress.XtraEditors.LabelControl lbFindRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbFindRoomType;
        private DevExpress.XtraEditors.LabelControl lbFindRoomID;
        private DevExpress.XtraEditors.SimpleButton btnFindRoom;
        private DevExpress.XtraEditors.GroupControl gcFindroomData;
        private DevExpress.XtraEditors.LabelControl lbFindRoomNote;
        private DevExpress.XtraEditors.LabelControl lbFindRoomPrice2;
        private DevExpress.XtraEditors.LabelControl lbFindRoomID2;
        private DevExpress.XtraEditors.GroupControl gcRoomList;
        private System.Windows.Forms.DataGridView dgvFindRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomNote;
        private System.Windows.Forms.TextBox tbFindRoomStatus;
        private System.Windows.Forms.TextBox tbFindRoomType;
        private System.Windows.Forms.RichTextBox rtbFindRoomNote;
        private System.Windows.Forms.TextBox tbFindRoomPrice;
        private System.Windows.Forms.TextBox tbFindRoomID;
        private DevExpress.XtraEditors.LabelControl lbFindRoomStatus2;
        private DevExpress.XtraEditors.LabelControl lbFindRoomType2;
        private DevExpress.XtraEditors.GroupControl gcRoomBill;
        private DevExpress.XtraEditors.SimpleButton btnCreateBillRoom;
        private DevExpress.XtraEditors.SimpleButton btnCancelBillRoom;
        private System.Windows.Forms.DataGridView dgvBillRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomRentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomTotalPrice;
        private DevExpress.XtraEditors.GroupControl gcAddRoomBill;
        private DevExpress.XtraEditors.SimpleButton btnAddBillRoom;
        private System.Windows.Forms.ComboBox cbAddBillRoomID;
        private DevExpress.XtraEditors.LabelControl lbAddBillRoomID;
        private DevExpress.XtraEditors.GroupControl gcRoomBillData;
        private DevExpress.XtraEditors.SimpleButton btnDelBillRoom;
        private System.Windows.Forms.TextBox tbBillRoomCost;
        private System.Windows.Forms.TextBox tbBillRoomPrice;
        private System.Windows.Forms.TextBox tbBillRoomDay;
        private System.Windows.Forms.TextBox tbBillRoomID;
        private DevExpress.XtraEditors.LabelControl lbBillRoomCost;
        private DevExpress.XtraEditors.LabelControl lbBillRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbBillRoomDay;
        private DevExpress.XtraEditors.LabelControl lbBillRoomID;
        private DevExpress.XtraEditors.GroupControl gcBill;
        private DevExpress.XtraEditors.SimpleButton btnLockBill;
        private System.Windows.Forms.RichTextBox rtbBillCustomerAddress;
        private DevExpress.XtraEditors.DateEdit deBillDate;
        private System.Windows.Forms.TextBox tbBillCustomerName;
        private DevExpress.XtraEditors.LabelControl lbBillCustomerAddress;
        private DevExpress.XtraEditors.LabelControl lbBillDate;
        private DevExpress.XtraEditors.LabelControl lbBillCustomerName;
        private DevExpress.XtraEditors.GroupControl gcMonthReportList;
        private System.Windows.Forms.DataGridView dgvRevenueList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomPercentage;
        private DevExpress.XtraEditors.GroupControl gcMonthReportSelect;
        private DevExpress.XtraEditors.SimpleButton btnCreateMonthRevenue;
        private System.Windows.Forms.ComboBox cbRevenueMonth;
        private DevExpress.XtraEditors.LabelControl lbMonthRevenue;
        private DevExpress.XtraEditors.GroupControl gcEditRule;
        private DevExpress.XtraEditors.GroupControl gcCustomerTypeList;
        private DevExpress.XtraEditors.GroupControl gcRoomTypeList;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnDelCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomerType;
        private System.Windows.Forms.DataGridView dgvCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnEditRoomType;
        private DevExpress.XtraEditors.SimpleButton btnDelRoomType;
        private DevExpress.XtraEditors.SimpleButton btnAddRoomType;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditRoomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditRoomTypePrice;
        private DevExpress.XtraEditors.LabelControl lbMaxCustomerValue;
        private DevExpress.XtraEditors.SimpleButton btnAdditionalCustomerSurcharge;
        private DevExpress.XtraEditors.SimpleButton btnEditMaxCustomerRule;
        private DevExpress.XtraEditors.LabelControl lbAdditionalCustomerSurcharge;
        private DevExpress.XtraEditors.LabelControl lbMaxCustomerRule;
        private System.Windows.Forms.ComboBox cbRevenueYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvListRoom;
        private DevExpress.XtraEditors.LabelControl lbAdditionalCustomerSurchargeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbLeaseRoomPrice;
        private DevExpress.XtraEditors.DateEdit deLeaseRoomDate;
        private System.Windows.Forms.ComboBox cbLeaseRoomID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCustomerTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSurcharge;
    }
}

