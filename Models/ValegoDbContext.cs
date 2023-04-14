using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ValegoProject.Models;

public partial class ValegoDbContext : DbContext
{
    public ValegoDbContext()
    {
    }

    public ValegoDbContext(DbContextOptions<ValegoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NetWork> NetWorks { get; set; }

    public virtual DbSet<Rede> Redes { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-97L1R409\\SQLEXPRESS;Database=ValegoDB; user=helmer;password=yonnich123;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NetWork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NetWork__3214EC075397EA8A");

            entity.ToTable("NetWork");

            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("_Enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("_Name");
            entity.Property(e => e.NetworkName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Network_Name");
            entity.Property(e => e.NetworkSymbol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TokenExplorer)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TransactionExplorer)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rede>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Networks__3214EC0737A4BE46");

            entity.Property(e => e.Asset)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MaxFee).HasColumnName("maxFee");
            entity.Property(e => e.TokenAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WithdrawalFee).HasColumnName("withdrawalFee");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wallet__3214EC07992A023A");

            entity.ToTable("Wallet");

            entity.Property(e => e.Asset)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CuurencyType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Enable).HasColumnName("_Enable");
            entity.Property(e => e.MajorCurrency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("_Name");

            entity.HasOne(d => d.Networks).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.NetworksId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wallet__Networks__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
