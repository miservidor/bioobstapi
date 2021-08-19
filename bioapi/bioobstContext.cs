using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class bioobstContext : DbContext
    {
        public bioobstContext()
        {
        }

        public bioobstContext(DbContextOptions<bioobstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<AdressLiefer> AdressLiefer { get; set; }
        public virtual DbSet<Artikel> Artikel { get; set; }
        public virtual DbSet<Artikelgruppe> Artikelgruppe { get; set; }
        public virtual DbSet<Kunde> Kunde { get; set; }
        public virtual DbSet<Rechnung> Rechnung { get; set; }
        public virtual DbSet<RechnungDetail> RechnungDetail { get; set; }
        public virtual DbSet<Steuer> Steuer { get; set; }
        public virtual DbSet<Testtable> Testtable { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userlevelpermissions> Userlevelpermissions { get; set; }
        public virtual DbSet<Userlevels> Userlevels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.*/
                optionsBuilder.UseMySql("server=85.215.236.86;port=3306;database=bioobst;user=bioobst;password=Wahlwies.2021", x => x.ServerVersion("8.0.24-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>(entity =>
            {
                entity.HasKey(e => e.Idadressen)
                    .HasName("PRIMARY");

                entity.ToTable("adress");

                entity.Property(e => e.Idadressen).HasColumnName("idadressen");

                entity.Property(e => e.Idkunde).HasColumnName("idkunde");

                entity.Property(e => e.KontaktEmail)
                    .HasColumnName("kontakt_email")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Landiso)
                    .HasColumnName("landiso")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ort)
                    .HasColumnName("ort")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Plz)
                    .HasColumnName("plz")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Straße)
                    .HasColumnName("straße")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<AdressLiefer>(entity =>
            {
                entity.HasKey(e => e.IdadressLiefer)
                    .HasName("PRIMARY");

                entity.ToTable("adress_liefer");

                entity.Property(e => e.IdadressLiefer).HasColumnName("idadress_liefer");

                entity.Property(e => e.Idkunde).HasColumnName("idkunde");

                entity.Property(e => e.KontaktEmal)
                    .HasColumnName("kontakt_emal")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.KontaktName)
                    .HasColumnName("kontakt_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Landiso)
                    .HasColumnName("landiso")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ort)
                    .HasColumnName("ort")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Plz)
                    .HasColumnName("plz")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Straße)
                    .HasColumnName("straße")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Artikel>(entity =>
            {
                entity.HasKey(e => e.Idartikel)
                    .HasName("PRIMARY");

                entity.ToTable("artikel");

                entity.Property(e => e.Idartikel).HasColumnName("idartikel");

                entity.Property(e => e.Artikelcol)
                    .HasColumnName("artikelcol")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Artikelgruppeid).HasColumnName("artikelgruppeid");

                entity.Property(e => e.Artikelnummer)
                    .HasColumnName("artikelnummer")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Beschreibung)
                    .HasColumnName("beschreibung")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bezeichnung)
                    .HasColumnName("bezeichnung")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mengeneinheit)
                    .HasColumnName("mengeneinheit")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Preis)
                    .HasColumnName("preis")
                    .HasColumnType("double(8,2)");

                entity.Property(e => e.Steuerid).HasColumnName("steuerid");

                entity.Property(e => e.Zusatz)
                    .HasColumnName("zusatz")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Artikelgruppe>(entity =>
            {
                entity.HasKey(e => e.Idartikelgruppe)
                    .HasName("PRIMARY");

                entity.ToTable("artikelgruppe");

                entity.HasIndex(e => e.Idartikelgruppe)
                    .HasName("idartikelgruppe_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idartikelgruppe).HasColumnName("idartikelgruppe");

                entity.Property(e => e.Artikelgruppecod)
                    .HasColumnName("artikelgruppecod")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Beschreibung)
                    .HasColumnName("beschreibung")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bezeichnung)
                    .HasColumnName("bezeichnung")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Parentid).HasColumnName("parentid");
            });

            modelBuilder.Entity<Kunde>(entity =>
            {
                entity.HasKey(e => e.Idkunde)
                    .HasName("PRIMARY");

                entity.ToTable("kunde");

                entity.Property(e => e.Idkunde).HasColumnName("idkunde");

                entity.Property(e => e.Createdat)
                    .HasColumnName("createdat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Anrede)
    .HasColumnName("anrede")
    .HasColumnType("varchar(45)")
    .HasCharSet("utf8mb4")
    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gruppekundeid).HasColumnName("gruppekundeid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Firma)
                    .HasColumnName("firma")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nummer)
                    .HasColumnName("nummer")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rabattgruppe)
                    .HasColumnName("rabattgruppe")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Steuernummer)
                    .HasColumnName("steuernummer")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefon1)
                    .HasColumnName("telefon1")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefon2)
                    .HasColumnName("telefon2")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Rechnung>(entity =>
            {
                entity.HasKey(e => e.Idrechnung)
                    .HasName("PRIMARY");

                entity.ToTable("rechnung");

                entity.Property(e => e.Idrechnung).HasColumnName("idrechnung");

                entity.Property(e => e.Beschreibung)
                    .HasColumnName("beschreibung")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idkunde).HasColumnName("idkunde");

                entity.Property(e => e.LieferAddressid).HasColumnName("liefer_addressid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rechnungnummer)
                    .HasColumnName("rechnungnummer")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<RechnungDetail>(entity =>
            {
                entity.HasKey(e => e.IdrechnungDetail)
                    .HasName("PRIMARY");

                entity.ToTable("rechnung_detail");

                entity.Property(e => e.IdrechnungDetail).HasColumnName("idrechnung_detail");

                entity.Property(e => e.Bezeichnung)
                    .HasColumnName("bezeichnung")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Einheit)
                    .HasColumnName("einheit")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Idartikel).HasColumnName("idartikel");

                entity.Property(e => e.Idrechnung).HasColumnName("idrechnung");

                entity.Property(e => e.Menge)
                    .HasColumnName("menge")
                    .HasColumnType("double(8,2)");

                entity.Property(e => e.Nettopreis)
                    .HasColumnName("nettopreis")
                    .HasColumnType("double(8,2)");

                entity.Property(e => e.Rechnungnummer)
                    .HasColumnName("rechnungnummer")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Steuer)
                    .HasColumnName("steuer")
                    .HasColumnType("double(8,2)");

                entity.Property(e => e.Zusatz)
                    .HasColumnName("zusatz")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Steuer>(entity =>
            {
                entity.HasKey(e => e.Idsteuer)
                    .HasName("PRIMARY");

                entity.ToTable("steuer");

                entity.Property(e => e.Idsteuer).HasColumnName("idsteuer");

                entity.Property(e => e.Steuerart)
                    .HasColumnName("steuerart")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Steuerbezeichnung)
                    .HasColumnName("steuerbezeichnung")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Steuercode)
                    .HasColumnName("steuercode")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Steuerrunden)
                    .HasColumnName("steuerrunden")
                    .HasColumnType("double(8,2)");
            });

            modelBuilder.Entity<Testtable>(entity =>
            {
                entity.HasKey(e => e.Idtesttable)
                    .HasName("PRIMARY");

                entity.ToTable("testtable");

                entity.Property(e => e.Idtesttable).HasColumnName("idtesttable");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nametest)
                    .HasColumnName("nametest")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vorname)
                    .HasColumnName("vorname")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rol)
                    .HasColumnName("rol")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vorname)
                    .HasColumnName("vorname")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Userlevelpermissions>(entity =>
            {
                entity.HasKey(e => new { e.Userlevelid, e.Tablename })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("userlevelpermissions");

                entity.Property(e => e.Userlevelid).HasColumnName("userlevelid");

                entity.Property(e => e.Tablename)
                    .HasColumnName("tablename")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Permission).HasColumnName("permission");
            });

            modelBuilder.Entity<Userlevels>(entity =>
            {
                entity.HasKey(e => e.Userlevelid)
                    .HasName("PRIMARY");

                entity.ToTable("userlevels");

                entity.Property(e => e.Userlevelid)
                    .HasColumnName("userlevelid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Userlevelname)
                    .IsRequired()
                    .HasColumnName("userlevelname")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
