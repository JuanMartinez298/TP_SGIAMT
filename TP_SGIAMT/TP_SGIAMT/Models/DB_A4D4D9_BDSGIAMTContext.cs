using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TP_SGIAMT.Models
{
    public partial class DB_A4D4D9_BDSGIAMTContext : DbContext
    {
        public DB_A4D4D9_BDSGIAMTContext()
        {
        }

        public DB_A4D4D9_BDSGIAMTContext(DbContextOptions<DB_A4D4D9_BDSGIAMTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TConcurso> TConcurso { get; set; }
        public virtual DbSet<TEstadoCon> TEstadoCon { get; set; }
        public virtual DbSet<TModalidadCon> TModalidadCon { get; set; }

        // Unable to generate entity type for table 'dbo.Usuario'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.T_Participante'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sql5045.site4now.net;Database=DB_A4D4D9_BDSGIAMT;User Id=DB_A4D4D9_BDSGIAMT_admin;Password=123456789gg;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TConcurso>(entity =>
            {
                entity.HasKey(e => e.PkIcIdConcurso);

                entity.ToTable("T_Concurso");

                entity.Property(e => e.PkIcIdConcurso).HasColumnName("PK_IC_IdConcurso");

                entity.Property(e => e.DcFechaConcurso)
                    .HasColumnName("DC_FechaConcurso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkIecIdEstado).HasColumnName("FK_IEC_IdEstado");

                entity.Property(e => e.IcCantidadNove).HasColumnName("IC_CantidadNove");

                entity.Property(e => e.IcCantidadSeri).HasColumnName("IC_CantidadSeri");

                entity.Property(e => e.VcLugarCon)
                    .HasColumnName("VC_LugarCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcNombreCon)
                    .HasColumnName("VC_NombreCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIecIdEstadoNavigation)
                    .WithMany(p => p.TConcurso)
                    .HasForeignKey(d => d.FkIecIdEstado)
                    .HasConstraintName("FK_T_Concurso_T_EstadoCon");
            });

            modelBuilder.Entity<TEstadoCon>(entity =>
            {
                entity.HasKey(e => e.PkIeIdEstado);

                entity.ToTable("T_EstadoCon");

                entity.Property(e => e.PkIeIdEstado)
                    .HasColumnName("PK_IE_IdEstado")
                    .ValueGeneratedNever();

                entity.Property(e => e.VeNombreEsta)
                    .HasColumnName("VE_NombreEsta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TModalidadCon>(entity =>
            {
                entity.HasKey(e => e.PkImIdModalidadCon);

                entity.ToTable("T_ModalidadCon");

                entity.Property(e => e.PkImIdModalidadCon)
                    .HasColumnName("PK_IM_IdModalidadCon")
                    .ValueGeneratedNever();

                entity.Property(e => e.VmNombreModCon)
                    .HasColumnName("VM_NombreModCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
