using Microsoft.EntityFrameworkCore;
using N8DatVeRapChieuPhim.Data;
using N8DatVeRapChieuPhim.Models;

namespace N8DatVeRapChieuPhim.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            // Nếu đã có dữ liệu thì không seed nữa
            if (await context.Phims.AnyAsync())
                return;

            #region Phim 
            var phims = new List<Phim>
            {
                new Phim { MaPhim = "P001", 
                    TenPhim = "Dune: Part Two",
                    TheLoai = "Khoa học viễn tưởng",
                    ThoiLuong = 165,
                    DaoDien = "Denis Villeneuve",
                    MoTa = "Cuộc hành trình của Paul Atreides tiếp tục trên hành tinh cát Arrakis.",
                    HinhAnh = "/images/phims/dune2.jpg"
                },
                new Phim
                {
                    MaPhim = "P002",
                    TenPhim = "Deadpool & Wolverine",
                    TheLoai = "Hành động, Hài",
                    ThoiLuong = 127,
                    DaoDien = "Shawn Levy",
                    MoTa = "Deadpool kết hợp cùng Wolverine trong một cuộc phiêu lưu đa vũ trụ.",
                    HinhAnh = "/images/phims/deadpool_wolverine.jpg"
                },
                new Phim
                {
                    MaPhim = "P003",
                    TenPhim = "Inside Out 2",
                    TheLoai = "Hoạt hình",
                    ThoiLuong = 96,
                    DaoDien = "Kelsey Mann",
                    MoTa = "Riley bước vào tuổi dậy thì với những cảm xúc mới đầy hỗn loạn.",
                    HinhAnh = "/images/phims/insideout2.jpg"
                },
                new Phim
                {
                    MaPhim = "P004",
                    TenPhim = "Godzilla x Kong: The New Empire",
                    TheLoai = "Hành động, Quái vật",
                    ThoiLuong = 115,
                    DaoDien = "Adam Wingard",
                    MoTa = "Godzilla và Kong đối đầu với mối đe dọa mới của Trái Đất.",
                    HinhAnh = "/images/phims/godzillaxkong.jpg"
                },
                new Phim
                {
                    MaPhim = "P005",
                    TenPhim = "Kung Fu Panda 4",
                    TheLoai = "Hoạt hình, Hài",
                    ThoiLuong = 94,
                    DaoDien = "Mike Mitchell",
                    MoTa = "Po trở lại với hành trình trở thành thủ lĩnh tinh thần.",
                    HinhAnh = "/images/phims/kungfupanda4.jpg"
                },
                new Phim
                {
                    MaPhim = "P006",
                    TenPhim = "A Quiet Place: Day One",
                    TheLoai = "Kinh dị",
                    ThoiLuong = 100,
                    DaoDien = "Michael Sarnoski",
                    MoTa = "Nguồn gốc của cuộc xâm lăng từ sinh vật săn mồi bằng âm thanh.",
                    HinhAnh = "/images/phims/aquietplace.jpg"
                },
                new Phim
                {
                    MaPhim = "P007",
                    TenPhim = "Joker: Folie à Deux",
                    TheLoai = "Tâm lý, Tội phạm",
                    ThoiLuong = 138,
                    DaoDien = "Todd Phillips",
                    MoTa = "Joker trở lại với một câu chuyện điên loạn và đầy ám ảnh.",
                    HinhAnh = "/images/phims/joker2.jpg"
                },
                new Phim
                {
                    MaPhim = "P008",
                    TenPhim = "Transformers One",
                    TheLoai = "Hành động, Hoạt hình",
                    ThoiLuong = 110,
                    DaoDien = "Josh Cooley",
                    MoTa = "Câu chuyện khởi nguồn của Optimus Prime và Megatron.",
                    HinhAnh = "/images/phims/transformersone.jpg"
                },
                new Phim
                {
                    MaPhim = "P009",
                    TenPhim = "Venom: The Last Dance",
                    TheLoai = "Hành động, Viễn tưởng",
                    ThoiLuong = 112,
                    DaoDien = "Kelly Marcel",
                    MoTa = "Cuộc đối đầu cuối cùng của Venom với kẻ thù mới.",
                    HinhAnh = "/images/phims/venom3.jpg"
                },
                new Phim
                {
                    MaPhim = "P010",
                    TenPhim = "Gladiator II",
                    TheLoai = "Sử thi, Hành động",
                    ThoiLuong = 155,
                    DaoDien = "Ridley Scott",
                    MoTa = "Phần tiếp theo của huyền thoại đấu trường La Mã.",
                    HinhAnh = "/images/phims/gladiator2.jpg"
                }
            };
            #endregion

            context.Phims.AddRange(phims);
            await context.SaveChangesAsync();
        }
    }
}
