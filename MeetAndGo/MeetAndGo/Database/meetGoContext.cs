using Microsoft.EntityFrameworkCore;

namespace MeetAndGo.Database
{
    public partial class meetGoContext : DbContext
    {
        public meetGoContext()
        {
        }

        public meetGoContext(DbContextOptions<meetGoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<BuildingReview> BuildingReview { get; set; }
        public virtual DbSet<CanceledBuilding> CanceledBuilding { get; set; }
        public virtual DbSet<CanceledOffice> CanceledOffice { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<OfficeReview> OfficeReview { get; set; }
        public virtual DbSet<RentedBuilding> RentedBuilding { get; set; }
        public virtual DbSet<RentedOffice> RentedOffice { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TypeOfBuilding> TypeOfBuilding { get; set; }
        public virtual DbSet<TypeOfOffice> TypeOfOffice { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<UserAccountRole> UserAccountRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4E77JCE;Database=meetGo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_City_Building_CityId");

                entity.HasOne(d => d.TypeOfBuilding)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.TypeOfBuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_TypeOfBuilding_Building_TypeOfBuildingId");
            });

            modelBuilder.Entity<BuildingReview>(entity =>
            {
                entity.HasKey(e => new { e.BuildingReviewId, e.UserId, e.BuildingId })
                    .HasName("Pk_BuildingReview_BuildingReviewIdUserIdBuildingId");

                entity.Property(e => e.BuildingReviewId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.BuildingReview)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Building_BuildingReview_BuildingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BuildingReview)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_BuildingReview_UserId");
            });

            modelBuilder.Entity<CanceledBuilding>(entity =>
            {
                entity.Property(e => e.FeePrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.CanceledBuilding)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Building_CanceledBuilding_BuildingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CanceledBuilding)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_CanceledBuilding_UserId");
            });

            modelBuilder.Entity<CanceledOffice>(entity =>
            {
                entity.HasKey(e => new { e.CanceledOfficeId, e.OfficeId, e.UserId })
                    .HasName("Pk_CanceledOffice_CanceledOfficeIdOfficeIdUserId");

                entity.Property(e => e.CanceledOfficeId).ValueGeneratedOnAdd();

                entity.Property(e => e.FeePrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.CanceledOffice)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Office_CanceledOffice_OfficeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CanceledOffice)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_CanceledOffice_UserId");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Country_City_CountryId");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_City_Office_CityId");

                entity.HasOne(d => d.TypeOfOffice)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.TypeOfOfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_TypeOfOffice_Office_TypeOfOfficeId");
            });

            modelBuilder.Entity<OfficeReview>(entity =>
            {
                entity.HasKey(e => new { e.OfficeReviewId, e.UserId, e.OfficeId })
                    .HasName("Pk_OfficeReview_OfficeReviewIdUserIdOfficeId");

                entity.Property(e => e.OfficeReviewId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficeReview)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Office_OfficeReview_OfficeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OfficeReview)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_OfficeReview_UserId");
            });

            modelBuilder.Entity<RentedBuilding>(entity =>
            {
                entity.HasKey(e => new { e.RentedBuildingId, e.BuildingId, e.UserId })
                    .HasName("Pk_RentedBuilding_RentedBuildingIdBuildingIdUserId");

                entity.Property(e => e.RentedBuildingId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.RentedBuilding)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Building_RentedBuilding_BuildingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentedBuilding)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_RentedBuilding_UserId");
            });

            modelBuilder.Entity<RentedOffice>(entity =>
            {
                entity.HasKey(e => new { e.RentedOfficeId, e.OfficeId })
                    .HasName("Pk_RentedOffice_RentedOfficeIdOfficeId");

                entity.Property(e => e.RentedOfficeId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.RentedOffice)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Office_RentedOffice_OfficeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentedOffice)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_RentedOffice_UserId");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.UserId })
                    .HasName("Pk_Transactions_TransactionIdUserId");

                entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_User_Transactions_UserId");
            });

            modelBuilder.Entity<TypeOfBuilding>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeOfOffice>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Role_User_RoleId");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_UserAccount_User_UserAccountId");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserAccountRole>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserAccountRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Role_UserAccountRole_RoleId");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.UserAccountRole)
                    .HasForeignKey(d => d.UserAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_UserAccount_UserAccountRole_UserAccountId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
