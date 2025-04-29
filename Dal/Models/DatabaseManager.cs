using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class DatabaseManager : DbContext
{
    public DatabaseManager()
    {
    }

    public DatabaseManager(DbContextOptions<DatabaseManager> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invitation> Invitations { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\c#\\HollProject\\Dal\\database\\Halldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC0732B98CB9");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Invitation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC072C1FDC76");

            entity.ToTable("Invitation");

            entity.Property(e => e.SecretaryId).HasColumnName("secretaryId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Invitations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invitation_ToTable");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07EFD41596");

            entity.ToTable("Menu");

            entity.Property(e => e.Product)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Worker__3214EC07C0EBE5E7");

            entity.ToTable("Worker");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Bonus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.WorkerType).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
