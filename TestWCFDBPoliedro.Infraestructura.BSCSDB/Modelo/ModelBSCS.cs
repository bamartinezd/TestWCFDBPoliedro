namespace TestWCFDBPoliedro.Infraestructura.BSCSDB.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBSCS : DbContext
    {
        public ModelBSCS()
            : base("name=ModelBSCS")
        {
        }

        public virtual DbSet<CONTRACT_ALL> CONTRACT_ALL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.OHXACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.PLCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.SCCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.SUBM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_EQU_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_REP_BILL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_REP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_REP_BILL_IDNO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_REP_IDNO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ITEMIZED_BILL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_IB_CATEGORIES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_IB_THRESHOLD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ARCHIVE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_DIR_ENTRY)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_OPERATOR_DIR)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_PSTN_DIR)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CALLS_ANONYM)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ASS_SERV)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ASS_EQU)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_ASS_CBB)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_CHECK)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_CLICKS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_CLICKS_DAY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_DURATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_USERLASTMOD)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_TOLLRATING)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.TMCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_D_TR1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_D_TR2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_D_TR3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_P_TR1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_P_TR2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_CRD_P_TR3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.IXCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.PENDING_IXCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_REQUEST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_INPREPAY)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_ALL>()
                .Property(e => e.CO_INPREPAY_PENDING)
                .IsUnicode(false);
        }
    }
}
