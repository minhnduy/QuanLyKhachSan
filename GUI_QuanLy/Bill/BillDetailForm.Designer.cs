namespace GUI_QuanLy.Bill
{
    partial class BillDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetailForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBillAddress = new System.Windows.Forms.TextBox();
            this.tbBillCustomer = new System.Windows.Forms.TextBox();
            this.tbBillDate = new System.Windows.Forms.TextBox();
            this.lbBillAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lbBillDate = new DevExpress.XtraEditors.LabelControl();
            this.lbBillHeader = new DevExpress.XtraEditors.LabelControl();
            this.imgRoomBill = new DevExpress.XtraEditors.LabelControl();
            this.gcBillData = new DevExpress.XtraEditors.GroupControl();
            this.dgvBillData = new System.Windows.Forms.DataGridView();
            this.PaidRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomRentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalCustomerSurcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignCustomerSurcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcBillDetail = new DevExpress.XtraEditors.GroupControl();
            this.lbBillTax = new DevExpress.XtraEditors.LabelControl();
            this.tbBillSurcharge = new System.Windows.Forms.TextBox();
            this.lbTaxCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCost = new DevExpress.XtraEditors.LabelControl();
            this.tbBillPrice = new System.Windows.Forms.TextBox();
            this.lbBillCostCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lbReceivedMoney = new DevExpress.XtraEditors.LabelControl();
            this.tbReceivedMoney = new System.Windows.Forms.TextBox();
            this.lbReceivedMoneyCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lbChange = new DevExpress.XtraEditors.LabelControl();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.lbChangeCurrency = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaxDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillData)).BeginInit();
            this.gcBillData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillDetail)).BeginInit();
            this.gcBillDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTaxDetail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gcBillData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gcBillDetail, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tbBillAddress);
            this.panel1.Controls.Add(this.tbBillCustomer);
            this.panel1.Controls.Add(this.tbBillDate);
            this.panel1.Controls.Add(this.lbBillAddress);
            this.panel1.Controls.Add(this.lbBillCustomer);
            this.panel1.Controls.Add(this.lbBillDate);
            this.panel1.Controls.Add(this.lbBillHeader);
            this.panel1.Controls.Add(this.imgRoomBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 156);
            this.panel1.TabIndex = 1;
            // 
            // tbBillAddress
            // 
            this.tbBillAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillAddress.Location = new System.Drawing.Point(260, 125);
            this.tbBillAddress.Name = "tbBillAddress";
            this.tbBillAddress.ReadOnly = true;
            this.tbBillAddress.Size = new System.Drawing.Size(221, 20);
            this.tbBillAddress.TabIndex = 54;
            // 
            // tbBillCustomer
            // 
            this.tbBillCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillCustomer.Location = new System.Drawing.Point(260, 89);
            this.tbBillCustomer.Name = "tbBillCustomer";
            this.tbBillCustomer.ReadOnly = true;
            this.tbBillCustomer.Size = new System.Drawing.Size(221, 20);
            this.tbBillCustomer.TabIndex = 53;
            // 
            // tbBillDate
            // 
            this.tbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillDate.Location = new System.Drawing.Point(260, 53);
            this.tbBillDate.Name = "tbBillDate";
            this.tbBillDate.ReadOnly = true;
            this.tbBillDate.Size = new System.Drawing.Size(221, 20);
            this.tbBillDate.TabIndex = 52;
            // 
            // lbBillAddress
            // 
            this.lbBillAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillAddress.Appearance.Options.UseFont = true;
            this.lbBillAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillAddress.Location = new System.Drawing.Point(210, 125);
            this.lbBillAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillAddress.Name = "lbBillAddress";
            this.lbBillAddress.Size = new System.Drawing.Size(44, 13);
            this.lbBillAddress.TabIndex = 51;
            this.lbBillAddress.Text = "ĐỊA CHỈ:";
            // 
            // lbBillCustomer
            // 
            this.lbBillCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomer.Appearance.Options.UseFont = true;
            this.lbBillCustomer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomer.Location = new System.Drawing.Point(165, 92);
            this.lbBillCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomer.Name = "lbBillCustomer";
            this.lbBillCustomer.Size = new System.Drawing.Size(89, 13);
            this.lbBillCustomer.TabIndex = 50;
            this.lbBillCustomer.Text = "KHÁCH/CƠ QUAN:";
            // 
            // lbBillDate
            // 
            this.lbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillDate.Appearance.Options.UseFont = true;
            this.lbBillDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillDate.Location = new System.Drawing.Point(155, 60);
            this.lbBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(99, 13);
            this.lbBillDate.TabIndex = 49;
            this.lbBillDate.Text = "NGÀY THANH TOÁN:";
            // 
            // lbBillHeader
            // 
            this.lbBillHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbBillHeader.Appearance.Options.UseFont = true;
            this.lbBillHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillHeader.Location = new System.Drawing.Point(217, 16);
            this.lbBillHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbBillHeader.Name = "lbBillHeader";
            this.lbBillHeader.Size = new System.Drawing.Size(332, 24);
            this.lbBillHeader.TabIndex = 48;
            this.lbBillHeader.Text = "CHI TIẾT HOÁ ĐƠN THANH TOÁN";
            // 
            // imgRoomBill
            // 
            this.imgRoomBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgRoomBill.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgRoomBill.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomBill.Appearance.Image")));
            this.imgRoomBill.Appearance.Options.UseFont = true;
            this.imgRoomBill.Appearance.Options.UseImage = true;
            this.imgRoomBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomBill.ImageOptions.Image")));
            this.imgRoomBill.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgRoomBill.Location = new System.Drawing.Point(155, 8);
            this.imgRoomBill.Margin = new System.Windows.Forms.Padding(2);
            this.imgRoomBill.Name = "imgRoomBill";
            this.imgRoomBill.Size = new System.Drawing.Size(32, 32);
            this.imgRoomBill.TabIndex = 47;
            // 
            // gcBillData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gcBillData, 2);
            this.gcBillData.Controls.Add(this.dgvBillData);
            this.gcBillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillData.Location = new System.Drawing.Point(3, 165);
            this.gcBillData.Name = "gcBillData";
            this.gcBillData.Size = new System.Drawing.Size(428, 238);
            this.gcBillData.TabIndex = 1;
            this.gcBillData.Text = "DANH MỤC THANH TOÁN";
            // 
            // dgvBillData
            // 
            this.dgvBillData.AllowUserToAddRows = false;
            this.dgvBillData.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaidRoomID,
            this.PaidRoomRentDays,
            this.PaidRoomPrice,
            this.AdditionalCustomerSurcharge,
            this.ForeignCustomerSurcharge,
            this.PaidRoomTotalPrice});
            this.dgvBillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillData.Location = new System.Drawing.Point(2, 23);
            this.dgvBillData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillData.MultiSelect = false;
            this.dgvBillData.Name = "dgvBillData";
            this.dgvBillData.ReadOnly = true;
            this.dgvBillData.RowTemplate.Height = 24;
            this.dgvBillData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillData.Size = new System.Drawing.Size(424, 213);
            this.dgvBillData.TabIndex = 3;
            this.dgvBillData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvBillData_RowPostPaint);
            // 
            // PaidRoomID
            // 
            this.PaidRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PaidRoomID.HeaderText = "PHÒNG";
            this.PaidRoomID.Name = "PaidRoomID";
            this.PaidRoomID.ReadOnly = true;
            this.PaidRoomID.Width = 67;
            // 
            // PaidRoomRentDays
            // 
            this.PaidRoomRentDays.HeaderText = "SỐ NGÀY THUÊ";
            this.PaidRoomRentDays.Name = "PaidRoomRentDays";
            this.PaidRoomRentDays.ReadOnly = true;
            this.PaidRoomRentDays.Width = 110;
            // 
            // PaidRoomPrice
            // 
            this.PaidRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.PaidRoomPrice.Name = "PaidRoomPrice";
            this.PaidRoomPrice.ReadOnly = true;
            // 
            // AdditionalCustomerSurcharge
            // 
            this.AdditionalCustomerSurcharge.HeaderText = "PHỤ THU KHÁCH THÊM (VND)";
            this.AdditionalCustomerSurcharge.Name = "AdditionalCustomerSurcharge";
            this.AdditionalCustomerSurcharge.ReadOnly = true;
            this.AdditionalCustomerSurcharge.Visible = false;
            // 
            // ForeignCustomerSurcharge
            // 
            this.ForeignCustomerSurcharge.HeaderText = "PHỤ THU KHÁCH NƯỚC NGOÀI (VND)";
            this.ForeignCustomerSurcharge.Name = "ForeignCustomerSurcharge";
            this.ForeignCustomerSurcharge.ReadOnly = true;
            this.ForeignCustomerSurcharge.Visible = false;
            // 
            // PaidRoomTotalPrice
            // 
            this.PaidRoomTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomTotalPrice.HeaderText = "THÀNH TIỀN (VND)";
            this.PaidRoomTotalPrice.Name = "PaidRoomTotalPrice";
            this.PaidRoomTotalPrice.ReadOnly = true;
            // 
            // gcBillDetail
            // 
            this.gcBillDetail.Controls.Add(this.lbChangeCurrency);
            this.gcBillDetail.Controls.Add(this.tbChange);
            this.gcBillDetail.Controls.Add(this.lbChange);
            this.gcBillDetail.Controls.Add(this.lbReceivedMoneyCurrency);
            this.gcBillDetail.Controls.Add(this.tbReceivedMoney);
            this.gcBillDetail.Controls.Add(this.lbReceivedMoney);
            this.gcBillDetail.Controls.Add(this.lbBillCostCurrency);
            this.gcBillDetail.Controls.Add(this.tbBillPrice);
            this.gcBillDetail.Controls.Add(this.lbBillCost);
            this.gcBillDetail.Controls.Add(this.lbTaxCurrency);
            this.gcBillDetail.Controls.Add(this.tbBillSurcharge);
            this.gcBillDetail.Controls.Add(this.lbBillTax);
            this.gcBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillDetail.Location = new System.Drawing.Point(437, 165);
            this.gcBillDetail.Name = "gcBillDetail";
            this.gcBillDetail.Size = new System.Drawing.Size(285, 238);
            this.gcBillDetail.TabIndex = 2;
            this.gcBillDetail.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // lbBillTax
            // 
            this.lbBillTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillTax.Appearance.Options.UseFont = true;
            this.lbBillTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillTax.Location = new System.Drawing.Point(38, 53);
            this.lbBillTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillTax.Name = "lbBillTax";
            this.lbBillTax.Size = new System.Drawing.Size(47, 13);
            this.lbBillTax.TabIndex = 55;
            this.lbBillTax.Text = "PHỤ THU:";
            // 
            // tbBillSurcharge
            // 
            this.tbBillSurcharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillSurcharge.Location = new System.Drawing.Point(91, 50);
            this.tbBillSurcharge.Name = "tbBillSurcharge";
            this.tbBillSurcharge.ReadOnly = true;
            this.tbBillSurcharge.Size = new System.Drawing.Size(113, 21);
            this.tbBillSurcharge.TabIndex = 56;
            // 
            // lbTaxCurrency
            // 
            this.lbTaxCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTaxCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbTaxCurrency.Appearance.Options.UseFont = true;
            this.lbTaxCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbTaxCurrency.Location = new System.Drawing.Point(210, 53);
            this.lbTaxCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTaxCurrency.Name = "lbTaxCurrency";
            this.lbTaxCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbTaxCurrency.TabIndex = 57;
            this.lbTaxCurrency.Text = "(VND)";
            // 
            // lbBillCost
            // 
            this.lbBillCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCost.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCost.Appearance.Options.UseFont = true;
            this.lbBillCost.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCost.Location = new System.Drawing.Point(43, 99);
            this.lbBillCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCost.Name = "lbBillCost";
            this.lbBillCost.Size = new System.Drawing.Size(42, 13);
            this.lbBillCost.TabIndex = 58;
            this.lbBillCost.Text = "GIÁ TRỊ:";
            // 
            // tbBillPrice
            // 
            this.tbBillPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillPrice.Location = new System.Drawing.Point(91, 96);
            this.tbBillPrice.Name = "tbBillPrice";
            this.tbBillPrice.ReadOnly = true;
            this.tbBillPrice.Size = new System.Drawing.Size(113, 21);
            this.tbBillPrice.TabIndex = 59;
            // 
            // lbBillCostCurrency
            // 
            this.lbBillCostCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCostCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCostCurrency.Appearance.Options.UseFont = true;
            this.lbBillCostCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCostCurrency.Location = new System.Drawing.Point(210, 99);
            this.lbBillCostCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCostCurrency.Name = "lbBillCostCurrency";
            this.lbBillCostCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbBillCostCurrency.TabIndex = 60;
            this.lbBillCostCurrency.Text = "(VND)";
            // 
            // lbReceivedMoney
            // 
            this.lbReceivedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceivedMoney.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbReceivedMoney.Appearance.Options.UseFont = true;
            this.lbReceivedMoney.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbReceivedMoney.Location = new System.Drawing.Point(27, 139);
            this.lbReceivedMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReceivedMoney.Name = "lbReceivedMoney";
            this.lbReceivedMoney.Size = new System.Drawing.Size(58, 13);
            this.lbReceivedMoney.TabIndex = 61;
            this.lbReceivedMoney.Text = "TIỀN NHẬN:";
            // 
            // tbReceivedMoney
            // 
            this.tbReceivedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReceivedMoney.Location = new System.Drawing.Point(91, 136);
            this.tbReceivedMoney.MaxLength = 15;
            this.tbReceivedMoney.Name = "tbReceivedMoney";
            this.tbReceivedMoney.Size = new System.Drawing.Size(113, 21);
            this.tbReceivedMoney.TabIndex = 62;
            this.tbReceivedMoney.Text = "0";
            this.tbReceivedMoney.TextChanged += new System.EventHandler(this.TbReceivedMoney_TextChanged);
            this.tbReceivedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbReceivedMoney_KeyPress);
            // 
            // lbReceivedMoneyCurrency
            // 
            this.lbReceivedMoneyCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceivedMoneyCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbReceivedMoneyCurrency.Appearance.Options.UseFont = true;
            this.lbReceivedMoneyCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbReceivedMoneyCurrency.Location = new System.Drawing.Point(210, 139);
            this.lbReceivedMoneyCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReceivedMoneyCurrency.Name = "lbReceivedMoneyCurrency";
            this.lbReceivedMoneyCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbReceivedMoneyCurrency.TabIndex = 63;
            this.lbReceivedMoneyCurrency.Text = "(VND)";
            // 
            // lbChange
            // 
            this.lbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChange.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbChange.Appearance.Options.UseFont = true;
            this.lbChange.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbChange.Location = new System.Drawing.Point(27, 181);
            this.lbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(58, 13);
            this.lbChange.TabIndex = 64;
            this.lbChange.Text = "TIỀN THỪA:";
            // 
            // tbChange
            // 
            this.tbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbChange.Location = new System.Drawing.Point(91, 181);
            this.tbChange.Name = "tbChange";
            this.tbChange.ReadOnly = true;
            this.tbChange.Size = new System.Drawing.Size(113, 21);
            this.tbChange.TabIndex = 65;
            // 
            // lbChangeCurrency
            // 
            this.lbChangeCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChangeCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbChangeCurrency.Appearance.Options.UseFont = true;
            this.lbChangeCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbChangeCurrency.Location = new System.Drawing.Point(210, 184);
            this.lbChangeCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbChangeCurrency.Name = "lbChangeCurrency";
            this.lbChangeCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbChangeCurrency.TabIndex = 66;
            this.lbChangeCurrency.Text = "(VND)";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(3, 408);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(211, 37);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "HUỶ BỎ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTaxDetail
            // 
            this.btnTaxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaxDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaxDetail.ImageOptions.Image")));
            this.btnTaxDetail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTaxDetail.Location = new System.Drawing.Point(220, 408);
            this.btnTaxDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaxDetail.Name = "btnTaxDetail";
            this.btnTaxDetail.Size = new System.Drawing.Size(211, 37);
            this.btnTaxDetail.TabIndex = 28;
            this.btnTaxDetail.Text = "CHI TIẾT PHỤ THU";
            this.btnTaxDetail.Click += new System.EventHandler(this.btnTaxDetail_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreate.Location = new System.Drawing.Point(437, 408);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(285, 37);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "THANH TOÁN HOÁ ĐƠN";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BillDetailForm";
            this.Text = "CHI TIẾT HÓA ĐƠN THANH TOÁN";
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillData)).EndInit();
            this.gcBillData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillDetail)).EndInit();
            this.gcBillDetail.ResumeLayout(false);
            this.gcBillDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBillAddress;
        private System.Windows.Forms.TextBox tbBillCustomer;
        private System.Windows.Forms.TextBox tbBillDate;
        private DevExpress.XtraEditors.LabelControl lbBillAddress;
        private DevExpress.XtraEditors.LabelControl lbBillCustomer;
        private DevExpress.XtraEditors.LabelControl lbBillDate;
        private DevExpress.XtraEditors.LabelControl lbBillHeader;
        private DevExpress.XtraEditors.LabelControl imgRoomBill;
        private DevExpress.XtraEditors.GroupControl gcBillData;
        private System.Windows.Forms.DataGridView dgvBillData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomRentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalCustomerSurcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignCustomerSurcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomTotalPrice;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnTaxDetail;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl gcBillDetail;
        private DevExpress.XtraEditors.LabelControl lbChangeCurrency;
        private System.Windows.Forms.TextBox tbChange;
        private DevExpress.XtraEditors.LabelControl lbChange;
        private DevExpress.XtraEditors.LabelControl lbReceivedMoneyCurrency;
        private System.Windows.Forms.TextBox tbReceivedMoney;
        private DevExpress.XtraEditors.LabelControl lbReceivedMoney;
        private DevExpress.XtraEditors.LabelControl lbBillCostCurrency;
        private System.Windows.Forms.TextBox tbBillPrice;
        private DevExpress.XtraEditors.LabelControl lbBillCost;
        private DevExpress.XtraEditors.LabelControl lbTaxCurrency;
        private System.Windows.Forms.TextBox tbBillSurcharge;
        private DevExpress.XtraEditors.LabelControl lbBillTax;
    }
}