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
        private string link = @"Data Source=NOKIA-E490\SQLExpress;Initial Catalog=QUANLYTHPT;Integrated Security=True";
        private SqlConnection connect;
        private SqlCommand command;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
        }

        private void btn_Monhoc_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 232);
            pn_Hocsinh.Visible = false;
        }

        private void btn_Tkb_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 288);
            pn_Hocsinh.Visible = false;
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
                    str += "INSERT HOCSINH ([MAHOCSINH], [HOTENHOCSINH], [NGAYSINH], [GIOITINH], [DIACHI], [SDTPH], [MALOP]) VALUES(N'"+txt_Them_maHS.Text+"', N'"+txt_Them_tenHS.Text+"', CAST(N'"+date_NS_hs.Value.ToString("yyyy/MM/dd")+"' AS Date), N'"+check_them_Nam_hs.Text+"', N'"+txt_Them_Diachi_hs.Text+"', N'"+txt_Them_sdt_phhs.Text+"',N'"+cb_them_malop_HS.Text+"')";
                }
                if (check_them_Nu_hs.Checked == true)
                {
                    str += "INSERT HOCSINH ([MAHOCSINH], [HOTENHOCSINH], [NGAYSINH], [GIOITINH], [DIACHI], [SDTPH], [MALOP]) VALUES(N'"+txt_Them_maHS.Text+ "', N'" + txt_Them_tenHS.Text + "', CAST(N'" + date_NS_hs.Value.ToString("yyyy/MM/dd") + "' AS Date), N'" + check_them_Nu_hs.Text + "', N'"+txt_Them_Diachi_hs.Text+"', N'"+txt_Them_sdt_phhs.Text+"',N'"+cb_them_malop_HS.Text + "')";
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
            if(e.ColumnIndex==7)
            {
                pn_Sua_HS.Visible = true;
                txt_Sua_maHS.Text = tb_hocsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Sua_tenHS.Text= tb_hocsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                date_Sua_ngaysinh.Text= tb_hocsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(tb_hocsinh.Rows[e.RowIndex].Cells[3].Value.ToString()==check_Sua_namHS.Text)
                {
                    check_Sua_namHS.Checked = true;
                    check_Sua_Nu_HS.Checked = false;
                }
                if(tb_hocsinh.Rows[e.RowIndex].Cells[3].Value.ToString()==check_Sua_Nu_HS.Text)
                {
                    check_Sua_Nu_HS.Checked = true;
                    check_Sua_namHS.Checked = false;
                }
                txt_Sua_diachiHS.Text= tb_hocsinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Sua_sdtphHS.Text= tb_hocsinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_Sua_MalopHS.Text= tb_hocsinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else
            {
                if(e.ColumnIndex==8)
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
    }
}
