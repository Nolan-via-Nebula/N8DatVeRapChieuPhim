using Microsoft.EntityFrameworkCore;
using N8DatVeRapChieuPhim.Models;
using System.Reflection.Emit;

namespace N8DatVeRapChieuPhim.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Bảng Phim
        public DbSet<Phim> Phims { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "NvN",
                    PasswordHash = ("270826"),
                    Role = "Admin"
                }
            );

            // Cấu hình cho Phim
            modelBuilder.Entity<Phim>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.MaPhim)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.TenPhim)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.TheLoai)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.ThoiLuong)
                    .IsRequired();
                entity.Property(e => e.DaoDien)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.MoTa)
                    .IsRequired()
                    .HasMaxLength(1500);
                entity.Property(e => e.HinhAnh)
                    .IsRequired()
                    .HasMaxLength(200);

                // Mã phim là duy nhất
                entity.HasIndex(p => p.MaPhim).IsUnique();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.PasswordHash)
                    .IsRequired();
                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20);
                // Username là duy nhất
                entity.HasIndex(u => u.UserName).IsUnique();
            });

        }

    }
}