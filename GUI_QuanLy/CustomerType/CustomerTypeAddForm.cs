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
    public partial class CustomerTypeAddForm : Form
    {
        public CustomerTypeAddForm()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.tbCustomerType.Text))
            {
                MessageBox.Show("Các thông tin không được để trống",
                    "THÊM LOẠI KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var customerType = this.tbCustomerType.Text;
                
                if (CustomerTypeBUS.InsertCustomerType(customerType, Convert.ToInt16(this.nudSurchagePercent.Value)))
                {
                    MessageBox.Show(
                    "Thêm loại khách " + customerType + " thành công!",
                    "THÊM LOẠI KHÁCH THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    var mainForm = (MainForm)Owner;
                    mainForm.ReLoadCustomerTypeList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    "Loại khách " + customerType + " đã tồn tại!",
                    "THÊM LOẠI KHÁCH THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerTypeAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
