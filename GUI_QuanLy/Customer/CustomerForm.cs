using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy.Customer
{
    public partial class CustomerForm : Form
    {
        public static String CustomerAction;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var dt = CustomerTypeBUS.GetCustomerTypeList();

            Dictionary<string, int> type = new Dictionary<string, int>();

            foreach (DataRow dr in dt.Rows)
            {
                type.Add(dr["TenLoaiKhachHang"].ToString(), Convert.ToInt32(dr["MaLoaiKhachHang"]));
            }

            this.cbCustomerType.DataSource = new BindingSource(type, null);
            this.cbCustomerType.DisplayMember = "Key";
            this.cbCustomerType.ValueMember = "Value";


            switch (CustomerAction)
            {
                case "AddForm":
                    {
                        this.lbCustomerHeader.Text = this.Text = "THÊM THÔNG TIN KHÁCH";
                        break;
                    }

                case "EditForm":
                    {
                        MainForm mainForm = (MainForm)Owner;
                        var customer = mainForm.GetSelectedCustomer();

                        this.lbCustomerHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
                        this.tbCustomerName.Text = customer.CustomerName;
                        this.tbCustomerID.Text = customer.CustomerID;
                        this.cbCustomerType.Text = CustomerTypeBUS.GetCustomerTypeByID(customer.CustomerTypeID);
                        this.rtbCustomerAddress.Text = customer.CustomerAddress;
                        break;
                    }
            }
            this.lbCustomerHeader.Left = (this.ClientSize.Width - lbCustomerHeader.Size.Width) / 2 + 32;
            this.imgCustomer.Left = this.lbCustomerHeader.Left - 45;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string[] data = { tbCustomerName.Text, tbCustomerID.Text, cbCustomerType.Text, rtbCustomerAddress.Text };

            if (data.Any(d => string.IsNullOrWhiteSpace(d)))
            {
                MessageBox.Show("Các thông tin không được để trống!", "THÊM THẤT BẠI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainForm mainForm = (MainForm)Owner;
                var customer = new RoomLeaseDetailDTO();
                customer.CustomerName = this.tbCustomerName.Text;
                customer.CustomerID = this.tbCustomerID.Text;
                customer.CustomerTypeID = ((KeyValuePair<string, int>)this.cbCustomerType.SelectedItem).Value;
                customer.CustomerAddress = this.rtbCustomerAddress.Text;

                switch (CustomerAction)
                {
                    case "AddForm":
                        {
                            MessageBox.Show("Thêm khách \"" + data[0] + "\" thành công!", "THÊM THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.AddCustomer(customer);
                            break;
                        }

                    case "EditForm":
                        {
                            MessageBox.Show("Sửa khách \"" + data[0] + "\" thành công!", "SỬA THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.EditCustomer(customer);
                            break;
                        }
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
