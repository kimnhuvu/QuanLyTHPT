using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLyHocSinhTHPT
{
    public partial class Form2 : Form
    {
        private string link = @"Data Source=SCORPION;Initial Catalog=QUANLYTHPT;Integrated Security=True";
        private SqlConnection connect;
        private SqlCommand command;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYTHPTDataSet1.THOIKHOABIEU' table. You can move, or remove it, as needed.
            this.tHOIKHOABIEUTableAdapter.Fill(this.qUANLYTHPTDataSet1.THOIKHOABIEU);
            // TODO: This line of code loads data into the 'qUANLYTHPTDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter1.Fill(this.qUANLYTHPTDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qUANLYTHPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qUANLYTHPTDataSet.MONHOC);
            // TODO: This line of code loads data into the 'qUANLYTHPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qUANLYTHPTDataSet.LOP);
            // TODO: This line of code loads data into the 'qUANLYTHPTDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qUANLYTHPTDataSet.HOCSINH);

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_HocSinh_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 58);
            pn_Hocsinh.Dock = DockStyle.Fill;
            pn_Hocsinh.Visible = true;
        }

        private void btn_Giaovien_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 116);
            pn_Hocsinh.Visible = false;
        }

        private void btn_Lop_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 174);
            pn_Hocsinh.Visible = false;
            pn_Lop.Visible = true;
        }

        private void btn_Monhoc_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 232);
            pn_Hocsinh.Visible = false;
            pn_Lop.Visible = false;

            pn_monhoc.Visible = true;
            pn_monhoc.Dock = DockStyle.Fill;
        }

        private void btn_Tkb_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 288);

            pn_Lop.Visible = false;
            pn_Hocsinh.Visible = false;
            pn_monhoc.Visible = false;

            pn_tkb.Visible = true;
            pn_tkb.Dock = DockStyle.Fill;
        }

        private void btn_add_hs_Click(object sender, EventArgs e)
        {
            pn_them_hs.Visible = true;
        }

        private void btn_huy_Them_Click(object sender, EventArgs e)
        {
            pn_them_hs.Visible = false;
        }

        private void btn_Xacnhan_them_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                string str = "";
                if (check_them_Nam_hs.Checked == true)
                {
                    str += "INSERT HOCSINH ([MAHOCSINH], [HOTENHOCSINH], [NGAYSINH], [GIOITINH], [DIACHI], [SDTPH], [MALOP]) VALUES(N'" + txt_Them_maHS.Text + "', N'" + txt_Them_tenHS.Text + "', CAST(N'" + date_NS_hs.Value.ToString("yyyy/MM/dd") + "' AS Date), N'" + check_them_Nam_hs.Text + "', N'" + txt_Them_Diachi_hs.Text + "', N'" + txt_Them_sdt_phhs.Text + "',N'" + cb_them_malop_HS.Text + "')";
                }
                if (check_them_Nu_hs.Checked == true)
                {
                    str += "INSERT HOCSINH ([MAHOCSINH], [HOTENHOCSINH], [NGAYSINH], [GIOITINH], [DIACHI], [SDTPH], [MALOP]) VALUES(N'" + txt_Them_maHS.Text + "', N'" + txt_Them_tenHS.Text + "', CAST(N'" + date_NS_hs.Value.ToString("yyyy/MM/dd") + "' AS Date), N'" + check_them_Nu_hs.Text + "', N'" + txt_Them_Diachi_hs.Text + "', N'" + txt_Them_sdt_phhs.Text + "',N'" + cb_them_malop_HS.Text + "')";
                }
                command = new SqlCommand(str, connect);
                command.ExecuteNonQuery();
            }
            Form2_Load(sender, e);
            pn_them_hs.Visible = false;
        }

        private void btn_Huy_sua_Click(object sender, EventArgs e)
        {
            pn_Sua_HS.Visible = false;
        }

        private void btn_Xacnhan_Sua_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                string str = "update HOCSINH set HOTENHOCSINH=N'" + txt_Sua_tenHS.Text + "',DIACHI=N'" + txt_Sua_diachiHS.Text + "',SDTPH='" + txt_Sua_sdtphHS.Text + "',MALOP='" + cb_Sua_MalopHS.Text + "',NGAYSINH='" + date_Sua_ngaysinh.Value.ToString("yyyy/MM/dd") + "' where MAHOCSINH='" + txt_Sua_maHS.Text + "'";
                if (check_Sua_namHS.Checked == true)
                {
                    str += "UPDATE HOCSINH set GIOITINH=N'" + check_Sua_namHS.Text + "' WHERE MAHOCSINH='" + txt_Sua_maHS.Text + "'";
                }
                if (check_Sua_Nu_HS.Checked == true)
                {
                    str += "UPDATE HOCSINH set GIOITINH=N'" + check_Sua_Nu_HS.Text + "' WHERE MAHOCSINH='" + txt_Sua_maHS.Text + "'";
                }
                command = new SqlCommand(str, connect);
                command.ExecuteNonQuery();
            }
            Form2_Load(sender, e);
            pn_Sua_HS.Visible = false;
        }

        private void tb_hocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                pn_Sua_HS.Visible = true;
                txt_Sua_maHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Sua_tenHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                date_Sua_ngaysinh.Text = tb_hocsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (tb_hocsinh.Rows[e.RowIndex].Cells[3].Value.ToString() == check_Sua_namHS.Text)
                {
                    check_Sua_namHS.Checked = true;
                    check_Sua_Nu_HS.Checked = false;
                }
                if (tb_hocsinh.Rows[e.RowIndex].Cells[3].Value.ToString() == check_Sua_Nu_HS.Text)
                {
                    check_Sua_Nu_HS.Checked = true;
                    check_Sua_namHS.Checked = false;
                }
                txt_Sua_diachiHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Sua_sdtphHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_Sua_MalopHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 8)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from HOCSINH where MAHOCSINH = '" + tb_hocsinh.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        Form2_Load(sender, e);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult result = MessageBox.Show("Thông báo", "bạn có chắc muốn xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (connect = new SqlConnection(link))
                    {
                        connect.Open();
                        command = new SqlCommand("Delete from LOP where MALOP = '" + bang_Lop.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                        command.ExecuteNonQuery();
                    }
                    Form2_Load(sender, e);
                }
            }
            else
            {
                if (e.ColumnIndex == 4)
                {
                    tb_malop.Text = bang_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tb_tenlop.Text = bang_Lop.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tb_siso.Text = bang_Lop.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tb_maGVCN.Text = bang_Lop.Rows[e.RowIndex].Cells[3].Value.ToString();
                    pn_sualop.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_themlop.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update LOP set TENLOP = N'" + tb_tenlop.Text + "', SISO = '" + tb_siso.Text + "', MAGVCN = '" + tb_maGVCN.Text + "'" +
                    "where MALOP = '" + tb_malop.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sualop.Visible = false;
            Form2_Load(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert LOP values('" + tb_add_malop.Text + "', N'" + tb_add_tenlop.Text + "', '" + tb_add_siso.Text + "', '" + tb_add_maGVCN.Text + "')", connect);
                command.ExecuteNonQuery();
            }
            pn_themlop.Visible = false;
            Form2_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pn_themlop.Visible = false;
        }

        private void btn_cancel_sua_Click(object sender, EventArgs e)
        {
            pn_sualop.Visible = false;
        }

        private void btn_them_monhoc_Click(object sender, EventArgs e)
        {
            pn_them_mh.Visible = true;
        }

        private void btn_huy_them_mh_Click(object sender, EventArgs e)
        {
            pn_them_mh.Visible = false;
        }

        private void btn_huy_sua_mh_Click(object sender, EventArgs e)
        {
            pn_sua_mh.Visible = false;
        }

        private void btn_them_mh_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert MONHOC values('" + tb_ma_mh_them.Text + "', N'" + tb_ten_mh_them.Text + "', '" + tb_ma_tt_them.Text + "', '" + tb_ma_gv_them.Text + "')", connect);
                command.ExecuteNonQuery();
            }
            pn_them_mh.Visible = false;
            Form2_Load(sender, e);
        }

        private void btn_sua_mh_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update MONHOC set TENMONHOC = N'" + tb_ten_mh_sua.Text + "', MATOTRUONG = '" + tb_ma_tt_sua.Text + "', MAGIAOVIEN = '" + tb_ma_gv_sua.Text + "'" +
                    "where MAMONHOC = '" + tb_ma_mh_sua.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sua_mh.Visible = false;
            Form2_Load(sender, e);
        }

        private void bang_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                pn_sua_mh.Visible = true;
                tb_ma_mh_sua.Text = bang_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_ten_mh_sua.Text = bang_monhoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_ma_tt_sua.Text = bang_monhoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_ma_gv_sua.Text = bang_monhoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa môn học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from THOIKHOABIEU where MAMONHOC = '" + bang_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();

                            command = new SqlCommand("delete from MONHOC where MAMONHOC = '" + bang_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        Form2_Load(sender, e);
                    }
                }
            }
        }

        private void them_tkb_Click(object sender, EventArgs e)
        {
            pn_them_tkb.Visible = true;
        }

        private void btn_them_tkb_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert THOIKHOABIEU values('" + tb_ma_tkb_them.Text + "', N'" + tb_ma_gv_them_tkb.Text + "', '" + tb_ma_lop_them_tkb.Text + "', '" + tb_ma_mh_them_tkb.Text + "', '" + tb_ngay_them_tkb.Text + "')", connect);
                command.ExecuteNonQuery();
            }
            pn_them_tkb.Visible = false;
            Form2_Load(sender, e);
        }

        private void btn_huy_them_tkb_Click(object sender, EventArgs e)
        {
            pn_them_tkb.Visible = false;
        }

        private void btn_sua_tkb_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update THOIKHOABIEU set MAGIAOVIEN = N'" + tb_ma_gv_sua_tkb.Text + "', MALOP = '" + tb_ma_lop_sua_tkb.Text + "', MAMONHOC = '" + tb_ma_mh_sua_tkb.Text + "', NGAY = '" + tb_ngay_sua_tkb.Text + "'" +
                    "where MATKB = '" + tb_ma_tkb_sua.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sua_tkb.Visible = false;
            Form2_Load(sender, e);
        }

        private void btn_huy_sua_tkb_Click(object sender, EventArgs e)
        {
            pn_sua_tkb.Visible = false;
        }

        private void bang_tkb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                pn_sua_tkb.Visible = true;

                tb_ma_tkb_sua.Text = bang_tkb.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_ma_gv_sua_tkb.Text = bang_tkb.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_ma_lop_sua_tkb.Text = bang_tkb.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_ma_mh_sua_tkb.Text = bang_tkb.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_ngay_sua_tkb.Text = bang_tkb.Rows[e.RowIndex].Cells[4].Value.ToString();

                //pn_sua_tkb.BringToFront();
            }
            else
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thời khóa biểu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from THOIKHOABIEU where MATKB = '" + bang_tkb.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        Form2_Load(sender, e);
                    }
                }
            }
        }
    }
}
