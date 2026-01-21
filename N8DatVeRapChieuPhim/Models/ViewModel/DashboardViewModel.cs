namespace N8DatVeRapChieuPhim.Models.ViewModel
{
    public class DashboardViewModel
    {
        // Tổng số phim
        public int TongPhim { get; set; }

        // Tổng số phòng chiếu
        public int TongPhongChieu { get; set; }

        // Tổng số suất chiếu
        public int TongSuatChieu { get; set; }

        // Tổng số vé đã bán
        public int TongVeDaBan { get; set; }

        // Tổng doanh thu (VNĐ)
        public decimal TongDoanhThu { get; set; }
    }
}
