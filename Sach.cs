using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStoreManagement
{
    public partial class Sach : Form
    {
        DBHelper dBHelper = new DBHelper();
        public Sach()
        {
            InitializeComponent();
            LoadData();

        }

        public void LoadData()
        {
            string query = "Select * from vvSach";
            DataTable dataTable = new DataTable();
            dataTable = dBHelper.ExecuteQuery(query);
            dBHelper.FillDataGridView(dgdSach, dataTable);

            string cbquery = "SELECT sMaNXB, sTenNXB FROM tblNXB";
            dBHelper.FillComboBox(cbbNXB, cbquery, "sTenNXB", "sMaNXB");
        }

        private void dgdSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            var row = dgdSach.Rows[e.RowIndex];
            txtMasach.Text = row.Cells["Mã sách"].Value?.ToString() ?? "";
            txtTensach.Text = row.Cells["Tên sách"].Value?.ToString() ?? "";
            txtTheloai.Text = row.Cells["Thể loại"].Value?.ToString() ?? "";
            txtSoluong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtGia.Text = row.Cells["Giá"].Value?.ToString() ?? "";
            txtNamxuatban.Text = row.Cells["Năm xuất bản"].Value?.ToString() ?? "";
            txtTacgia.Text = row.Cells["Tác giả"].Value?.ToString() ?? "";
            cbbNXB.Text = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMasach",txtMasach.Text),
                new SqlParameter("@sTensach",txtTensach.Text),
                new SqlParameter("@sMaNXB",cbbNXB.SelectedValue),
                new SqlParameter("@sTacgia",txtTacgia.Text),
                new SqlParameter("@sTheloai",txtTheloai.Text),
                new SqlParameter("@iGia",Convert.ToInt32(txtGia.Text)),
                new SqlParameter("@iSL",Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@iNamXB",Convert.ToInt32(txtNamxuatban.Text)),
            };
            dBHelper.ExecuteNonQuery("ThemSach", parameters, CommandType.StoredProcedure);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMasach",txtMasach.Text),
                new SqlParameter("@sTensach",txtTensach.Text),
                new SqlParameter("@sMaNXB",cbbNXB.SelectedValue),
                new SqlParameter("@sTacgia",txtTacgia.Text),
                new SqlParameter("@sTheloai",txtTheloai.Text),
                new SqlParameter("@iGia",Convert.ToInt32(txtGia.Text)),
                new SqlParameter("@iSL",Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@iNamXB",Convert.ToInt32(txtNamxuatban.Text)),
            };
            dBHelper.ExecuteNonQuery("SuaSach", parameters, CommandType.StoredProcedure);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMasach",txtMasach.Text)
            };
            dBHelper.ExecuteNonQuery("XoaSach", parameters, CommandType.StoredProcedure);
            LoadData();
            ClearInput();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void ClearInput()
        {
            txtGia.Text = string.Empty;
            txtMasach.Text = string.Empty;
            txtNamxuatban.Text = string.Empty;
            txtSoluong.Text = string.Empty;
            txtTacgia.Text = string.Empty;
            txtTensach.Text = string.Empty;
            txtTheloai.Text = string.Empty;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@TuKhoa",txtTimkiem.Text)
            };
            DataTable dt = new DataTable();
            dt = dBHelper.ExecuteQuery("TimKiemSachTheoTen", parameters, CommandType.StoredProcedure);
            dBHelper.FillDataGridView(dgdSach, dt);
        }

        //private void dgdSach_RowValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgdSach.Rows[e.RowIndex].IsNewRow) return;

        //    DataGridViewRow row = dgdSach.Rows[e.RowIndex];
        //    string masach = row.Cells["Mã sách"].Value?.ToString() ?? "";
        //    string tensach = row.Cells["Tên sách"].Value?.ToString() ?? "";
        //    string theloai = row.Cells["Thể loại"].Value?.ToString() ?? "";
        //    int soluong = Convert.ToInt32(row.Cells["Số lượng"].Value?.ToString() ?? "");
        //    int gia = Convert.ToInt32(row.Cells["Giá"].Value?.ToString() ?? "");
        //    int namxb = Convert.ToInt32(row.Cells["Năm xuất bản"].Value?.ToString() ?? "");
        //    string tacgia = row.Cells["Tác giả"].Value?.ToString() ?? "";
        //    string tenNXB = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";

        //    string sql = "SELECT sMaNXB FROM tblNXB WHERE sTenNXB = @TenNXB";
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@TenNXB", tenNXB)
        //    };

        //    object result = dBHelper.ExecuteScalar(sql, parameters);
        //    if (result == null)
        //    {
        //        MessageBox.Show("Không tìm thấy Nhà xuất bản.");
        //        return;
        //    }

        //    string maNXB = result.ToString();

        //    var parameter = new SqlParameter[]
        //    {
        //        new SqlParameter("@sMasach",masach),
        //        new SqlParameter("@sTensach",tensach),
        //        new SqlParameter("@sMaNXB",maNXB),
        //        new SqlParameter("@sTacgia",tacgia),
        //        new SqlParameter("@sTheloai",theloai),
        //        new SqlParameter("@iGia",gia),
        //        new SqlParameter("@iSL",soluong),
        //        new SqlParameter("@iNamXB",namxb),
        //    };
        //    if (CheckIfBookExists(masach))
        //    {
        //        dBHelper.ExecuteNonQuery("SuaSach", parameter, CommandType.StoredProcedure);
        //    }
        //    else
        //    {
        //        dBHelper.ExecuteNonQuery("ThemSach", parameter, CommandType.StoredProcedure);
        //    }

        //}

        private bool CheckIfBookExists(string masach)
        {
            string sql = "SELECT COUNT(*) FROM tblSach WHERE sMasach = @sMasach";
            SqlParameter[] parameters = {
            new SqlParameter("@sMasach", masach)
            };
            object result = dBHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgdSach.Rows)
            {
                if (row.IsNewRow) continue;

                string masach = row.Cells["Mã sách"].Value?.ToString() ?? "";
                string tensach = row.Cells["Tên sách"].Value?.ToString() ?? "";
                string theloai = row.Cells["Thể loại"].Value?.ToString() ?? "";
                string tacgia = row.Cells["Tác giả"].Value?.ToString() ?? "";
                string tenNXB = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";

                // Chuyển đổi số an toàn
                bool isSoLuongValid = int.TryParse(row.Cells["Số lượng"].Value?.ToString(), out int soluong);
                bool isGiaValid = int.TryParse(row.Cells["Giá"].Value?.ToString(), out int gia);
                bool isNamXBValid = int.TryParse(row.Cells["Năm xuất bản"].Value?.ToString(), out int namxb);

                if (!isSoLuongValid || !isGiaValid || !isNamXBValid)
                {
                    MessageBox.Show("Dữ liệu số không hợp lệ ở dòng chứa mã sách: " + masach);
                    continue;
                }

                // Lấy mã NXB từ tên NXB
                string sql = "SELECT sMaNXB FROM tblNXB WHERE sTenNXB = @TenNXB";
                SqlParameter[] parameters = {
                    new SqlParameter("@TenNXB", tenNXB)
                };

                object result = dBHelper.ExecuteScalar(sql, parameters);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy Nhà xuất bản: {tenNXB} cho sách: {masach}");
                    continue;
                }

                string maNXB = result.ToString();

                var parameter = new SqlParameter[]
                {
                    new SqlParameter("@sMasach", masach),
                    new SqlParameter("@sTensach", tensach),
                    new SqlParameter("@sMaNXB", maNXB),
                    new SqlParameter("@sTacgia", tacgia),
                    new SqlParameter("@sTheloai", theloai),
                    new SqlParameter("@iGia", gia),
                    new SqlParameter("@iSL", soluong),
                    new SqlParameter("@iNamXB", namxb),
                };

                if (CheckIfBookExists(masach))
                {
                    dBHelper.ExecuteNonQuery("SuaSach", parameter, CommandType.StoredProcedure);
                }
                else
                {
                    dBHelper.ExecuteNonQuery("ThemSach", parameter, CommandType.StoredProcedure);
                }
            }

            MessageBox.Show("Đã lưu thành công!");
            LoadData(); // Nếu có hàm load lại dữ liệu
        }

    }
}
