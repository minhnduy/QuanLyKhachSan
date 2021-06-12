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

namespace GUI_QuanLy.Rule
{
    public partial class MaxCustomerEditForm : Form
    {
        public MaxCustomerEditForm()
        {
            InitializeComponent();
        }

        private void MaxCustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (RoomBUS.UpdateMaxCustomerInRoom(Convert.ToInt16(this.nudMaxCustomers.Value)))
            {
                MessageBox.Show(
                    "Chỉnh sửa số khách tối đa trong phòng thành công!\n" +
                    "Lưu ý: Số khách tối đa có thể quy định là " + this.nudMaxCustomers.Maximum.ToString() + " khách!",
                    "CHỈNH SỬA THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var mainForm = (MainForm)Owner;
                mainForm.ReLoadMaxCustomerInRoom();
                this.Close();
            }
            else MessageBox.Show(
                    "Chỉnh sửa số khách tối đa trong phòng thất bại!",
                    "CHỈNH SỬA THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NudMaxCustomers_Enter(object sender, EventArgs e)
        {
            this.nudMaxCustomers.Select(0, this.nudMaxCustomers.Text.Length);
        }
        private void NudMaxCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
