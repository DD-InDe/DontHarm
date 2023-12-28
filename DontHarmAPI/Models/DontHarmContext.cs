using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DontHarmAPI.Models;

public partial class DontHarmContext : DbContext
{
    public DontHarmContext()
    {
    }

    public DontHarmContext(DbContextOptions<DontHarmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<LoginHistory> LoginHistories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderService> OrderServices { get; set; }

    public virtual DbSet<OrderServiceDestroyer> OrderServiceDestroyers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<SocialType> SocialTypes { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OE4PBCI\\SQLEXPRESS;Database=DontHarm;Trusted_connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3214EC0704FB68B2");

            entity.ToTable("Client");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Birthday).HasMaxLength(50);
            entity.Property(e => e.Ein).HasMaxLength(30);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Pas).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(30);

            entity.HasOne(d => d.Company).WithMany(p => p.Clients)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Client__CompanyI__31EC6D26");

            entity.HasOne(d => d.SocialType).WithMany(p => p.Clients)
                .HasForeignKey(d => d.SocialTypeId)
                .HasConstraintName("FK__Client__SocialTy__30F848ED");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3214EC0761B085D7");

            entity.ToTable("Company");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.InBik).HasColumnName("InBIK");
            entity.Property(e => e.InPc).HasColumnName("InPC");
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Ua).HasColumnType("text");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07A2DF8BC6");

            entity.ToTable("Employee");

            entity.Property(e => e.IpAddress).HasMaxLength(100);
            entity.Property(e => e.LastEnter).HasColumnType("date");
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Pas).HasMaxLength(100);
            entity.Property(e => e.TextServices).HasMaxLength(100);

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Employee__RoleId__267ABA7A");
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoginHis__3214EC07BC1DE991");

            entity.ToTable("LoginHistory");

            entity.Property(e => e.LogDate).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.LoginHistories)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__LoginHist__Emplo__29572725");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3214EC070B2F577D");

            entity.ToTable("Order");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__Order__StatusId__4F7CD00D");
        });

        modelBuilder.Entity<OrderService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderSer__3214EC07F7CE6E78");

            entity.ToTable("OrderService");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderServ__Order__52593CB8");

            entity.HasOne(d => d.Service).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__OrderServ__Servi__534D60F1");

            entity.HasOne(d => d.Status).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__OrderServ__Statu__5441852A");
        });

        modelBuilder.Entity<OrderServiceDestroyer>(entity =>
        {
            entity.HasKey(e => e.OrderServiceDestroyerId).HasName("PK__OrderSer__58F91D38C42B169F");

            entity.ToTable("OrderServiceDestroyer");

            entity.Property(e => e.AfterDestroy).HasColumnType("decimal(10, 10)");

            entity.HasOne(d => d.Employee).WithMany(p => p.OrderServiceDestroyers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__OrderServ__Emplo__5AEE82B9");

            entity.HasOne(d => d.OrderService).WithMany(p => p.OrderServiceDestroyers)
                .HasForeignKey(d => d.OrderServiceId)
                .HasConstraintName("FK__OrderServ__Order__5BE2A6F2");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC0707C0523E");

            entity.ToTable("Role");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Service__3214EC07A2B2F8DD");

            entity.ToTable("Service");

            entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<SocialType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SocialTy__3214EC07CB12B0F8");

            entity.ToTable("SocialType");

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status__3214EC07DA7F6A14");

            entity.ToTable("Status");

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
