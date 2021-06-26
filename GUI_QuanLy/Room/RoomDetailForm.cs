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
    public partial class RoomDetailForm : Form
    {
        public static String CustomerAction;
        public static String ID;
        public RoomDetailForm()
        {
            InitializeComponent();
        }
        public string RoomDetailFormAction;

        private void RoomDetailForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var room = mainForm.GetSelectedRoomFind();
            switch (RoomDetailFormAction)
            {
                case "AddRoom_Sua":
                    lbRoomDetailHeader.Text = "Thêm thông tin vật tư sửa phòng "+ room.RoomID;
                    break;
                case "AddRoom_Hong":
                    lbRoomDetailHeader.Text = "Thêm thông tin vật tư hỏng phòng " + room.RoomID;
                    break;
                case "EditRoom_Sua":
                    lbRoomDetailHeader.Text = "Sửa thông tin vật tư sửa phòng " + room.RoomID;
                    this.tbName.Text = mainForm.dvRoomDetail.CurrentRow.Cells["Vật tư đang sửa"].Value.ToString();
                    ID= mainForm.dvRoomDetail.CurrentRow.Cells["ID"].Value.ToString();
                    break;
                case "EditRoom_Hong":
                    lbRoomDetailHeader.Text = "Sửa thông tin vật tư hỏng phòng " + room.RoomID;
                    this.tbName.Text = mainForm.dvRoomDetail.CurrentRow.Cells["Vật tư bị hỏng"].Value.ToString();
                    ID = mainForm.dvRoomDetail.CurrentRow.Cells["ID"].Value.ToString();
                    break;
                default:
                    break;                    
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var room = mainForm.GetSelectedRoomFind();
            switch (RoomDetailFormAction)
            {
                case "AddRoom_Sua":
                    if (this.tbName.Text != "")
                    {
                        RoomDetailDTO roomdetail = new RoomDetailDTO();
                        roomdetail.RoomID = room.RoomID;
                        roomdetail.SUA_VAT_TU = tbName.Text;
                        roomdetail.HONG_VAT_TU = "";
                        if (RoomDetailBUS.InsertRoomDetail(roomdetail))
                        {
                            MessageBox.Show("Thêm thông tin vật tư tại phòng " + room.RoomID + " thành công!", "THÊM THÔNG TIN THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thông tin vật tư thất bại", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin vật tư không được để trống", "THÊM THÔNG TIN PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbName.Focus();
                    }
                    break;
                case "AddRoom_Hong":
                    if (this.tbName.Text != "")
                    {
                        RoomDetailDTO roomdetail = new RoomDetailDTO();
                        roomdetail.RoomID = room.RoomID;
                        roomdetail.SUA_VAT_TU = "";
                        roomdetail.HONG_VAT_TU = tbName.Text;
                        if (RoomDetailBUS.InsertRoomDetail(roomdetail))
                        {
                            MessageBox.Show("Thêm thông tin vật tư tại phòng " + room.RoomID + " thành công!", "THÊM THÔNG TIN THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thông tin vật tư thất bại", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin vật tư không được để trống", "THÊM THÔNG TIN PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbName.Focus();
                    }
                    break;
                case "EditRoom_Sua":
                    if (this.tbName.Text != "")
                    {
                        RoomDetailDTO roomdetail = new RoomDetailDTO();
                        roomdetail.RoomID = room.RoomID;
                        roomdetail.SUA_VAT_TU = tbName.Text;
                        roomdetail.HONG_VAT_TU = "";
                        roomdetail.ID = int.Parse(ID);
                        if (RoomDetailBUS.UpdateRoomDetail(roomdetail))
                        {
                            MessageBox.Show("Sửa thông tin vật tư tại phòng " + room.RoomID + " thành công!", "SỬA THÔNG TIN THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin vật tư thất bại", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin vật tư không được để trống", "SỬA THÔNG TIN PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbName.Focus();
                    }
                    break;
                case "EditRoom_Hong":
                    if (this.tbName.Text != "")
                    {
                        RoomDetailDTO roomdetail = new RoomDetailDTO();
                        roomdetail.RoomID = room.RoomID;
                        roomdetail.SUA_VAT_TU = "";
                        roomdetail.HONG_VAT_TU = tbName.Text;
                        roomdetail.ID = int.Parse(ID);
                        if (RoomDetailBUS.UpdateRoomDetail(roomdetail))
                        {
                            MessageBox.Show("Sửa thông tin vật tư tại phòng " + room.RoomID + " thành công!", "SỬA THÔNG TIN THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin vật tư thất bại", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin vật tư không được để trống", "SỬA THÔNG TIN PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbName.Focus();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
