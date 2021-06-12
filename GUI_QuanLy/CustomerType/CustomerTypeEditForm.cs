using BUS_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy.CustomerType
{
    public partial class CustomerTypeEditForm : Form
    {
        public CustomerTypeEditForm()
        {
            InitializeComponent();
        }

        private void CustomerTypeEditForm_Load(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Owner;
            this.tbCustomerType.Text = mainForm.GetSelectedCustomerType();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbCustomerType.Text))
            {
                MessageBox.Show("Các thông tin không được để trống",
                    "SỬA LOẠI KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var mainForm = (MainForm)Owner;
                var oldType = mainForm.GetSelectedCustomerType();
                var newType = this.tbCustomerType.Text;
                int num = Convert.ToInt16(this.nudSurchagePercent.Value);
                if (CustomerTypeBUS.UpdateCustomerType(oldType,newType,num))
                {
                    MessageBox.Show(
                    "Sửa loại khách thành công!",
                    "SỬA LOẠI KHÁCH THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    mainForm.ReLoadCustomerTypeList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    $"Loại khách {newType} đã tồn tại!",
                    "SỬA LOẠI KHÁCH THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
