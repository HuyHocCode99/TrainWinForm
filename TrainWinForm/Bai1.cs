using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainWinForm
{
    public partial class frmQuanLiSV : Form
    {
        DataTable tbSinhVien = new DataTable();

        public frmQuanLiSV()
        {
            InitializeComponent();
        }
        public class SinhVien
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public string Lop { get; set; }

            // Constructor
            public SinhVien(string maSV, string hoTen, string lop)
            {
                this.MaSV = maSV;
                this.HoTen = hoTen;
                this.Lop = lop;
            }


        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMASV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in tbSinhVien.Rows)
            {
                if (row["Mã Sinh Viên"].ToString() == txtMASV.Text)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // tạo một dòng mới trong datatable
            DataRow newRow = tbSinhVien.NewRow();
            newRow["Mã Sinh Viên"] = txtMASV.Text;
            newRow["Họ Tên"] = txtHoTen.Text;
            newRow["Lớp"] = txtLop.Text;
            // add vào datatable
            tbSinhVien.Rows.Add(newRow);

            txtHoTen.Clear();
            txtLop.Clear();
            txtMASV.Clear();

        }

        private void frmQuanLiSV_Load(object sender, EventArgs e)
        {
            tbSinhVien.Columns.Add("Mã Sinh Viên",typeof(string));
            tbSinhVien.Columns.Add("Họ Tên", typeof(string));
            tbSinhVien.Columns.Add("Lớp", typeof(string));
            drvSinhVien.DataSource = tbSinhVien;
        }

        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(drvSinhVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in drvSinhVien.SelectedRows)
                {
                    drvSinhVien.Rows.RemoveAt(row.Index); //row.Index có thể tự phân biệt được chuột đang chỉ vào đâu

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLiSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
