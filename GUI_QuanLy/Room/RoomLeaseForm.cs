using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy.Room
{
    public partial class RoomLeaseForm : Form
    {
        public RoomLeaseForm()
        {
            InitializeComponent();
        }

        private void lbRoomType_Click(object sender, EventArgs e)
        {

        }

        private void lbRoomDetailHeader_Click(object sender, EventArgs e)
        {

        }

        private void imgEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void lbRoomDate_Click(object sender, EventArgs e)
        {

        }

        private void RoomLeaseForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var room = mainForm.GetRoomLease();

            this.tbRoomID.Text = room.RoomID;
            this.tbRoomPrice.Text = room.RoomPrice.ToString("N0") + " VND";
            this.tbRoomDate.Text = DateTime.ParseExact(room.LeaseDate, "M/d/yyyy", CultureInfo.InvariantCulture).ToString("d/M/yyyy");

            var rows = mainForm.GetAllRowsCustomerInNote();
            foreach (DataGridViewRow row in rows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dgvCustomerData.Rows.Add(rowData);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var lease = new RoomLeaseDTO();
            MainForm mainForm = (MainForm)Owner;
            lease.RoomID = this.tbRoomID.Text;
            lease.RoomPrice = Int64.Parse(this.tbRoomPrice.Text.Split()[0].Replace(",", ""));
            lease.LeaseDate = DateTime.ParseExact(tbRoomDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("d");

            var rows = mainForm.GetAllRowsCustomerInNote();
            lease.CustomerAmount = rows.Count;

            foreach (DataGridViewRow row in rows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
            }
            if (RoomLeaseBUS.InsertRoomLease(lease))
            {
                RoomLeaseDetailDTO detail = new RoomLeaseDetailDTO();
                detail.LeaseID = RoomLeaseBUS.GetLastLeaseIDOfRoom(lease.RoomID);

                foreach (DataGridViewRow row in dgvCustomerData.Rows)
                {
                    detail.CustomerName = row.Cells["CustomerName"].Value.ToString();
                    detail.CustomerID = row.Cells["CustomerID"].Value.ToString();
                    detail.CustomerTypeID = Convert.ToInt32(row.Cells["CustomerTypeID"].Value);
                    detail.CustomerAddress = row.Cells["CustomerAddress"].Value.ToString();
                    RoomLeaseDetailBUS.InsertDetail(detail);
                }

                mainForm.ReLoadAvailableRoom();
                mainForm.ReLoadRoomData();
                mainForm.ReCreateLease();

                MessageBox.Show("Lập phiếu thuê phòng " + lease.RoomID + " thành công!", "LẬP PHIẾU THUÊ PHÒNG THÀNH CÔNG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
