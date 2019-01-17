using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VideoDemo.Models
{
    public partial class videoDBContext : DbContext
    {
        public videoDBContext()
        {
        }

        public videoDBContext(DbContextOptions<videoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Angular> Angular { get; set; }
        public virtual DbSet<Csharp> Csharp { get; set; }
        public virtual DbSet<Html> Html { get; set; }
        public virtual DbSet<Java> Java { get; set; }
        public virtual DbSet<Sql> Sql { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:videolearning.database.windows.net,1433;Initial Catalog=videoDB;Persist Security Info=False;User ID=mikkor;Password=Bootcamp1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=300;");
            }
        }
        
//        // <add name="northwindEntities"
//        connectionString="metadata=res://*/Models.NorthwindModel.csdl|res://*/Models.NorthwindModel.
//ssdl|res://*/Models.NorthwindModel.msl;provider=System.Data.SqlClient;provider connection
//string=&quot;data source = DESKTOP - 9HQUE97\SQLEXPRESS;initial catalog = northwind; integrated
//       security = True; MultipleActiveResultSets=True;App=EntityFramework&quot;"
//providerName="System.Data.EntityClient" />
            


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Angular>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("Angular");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.LinkText)
                    .HasColumnName("link_text")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Csharp>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("Csharp");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.LinkText)
                    .HasColumnName("link_text")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Html>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("Html");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.LinkText)
                    .HasColumnName("link_text")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Java>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("Java");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.LinkText)
                    .HasColumnName("link_text")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sql>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("SQL");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.LinkText)
                    .HasColumnName("link_text")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}