using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day17Assignment.Models
{
    public partial class HospitalDBContext : DbContext
    {
        public HospitalDBContext()
        {
        }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistant> Assistants { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugTime> DrugTimes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-3P2R1D3J\\SQLEXPRESS;Database=HospitalDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");



            modelBuilder.Entity<Assistant>(entity =>
            {
                entity.Property(e => e.AssistantId).HasColumnName("Assistant_Id");

                entity.Property(e => e.AssistantName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Assistant_Name");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Assistants)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_Assistant_department_id");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Department_Name");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Doctor_Name");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_Doctor_Department_id");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.DrugId).HasColumnName("Drug_Id");

                entity.Property(e => e.DrugName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Drug_Name");

                entity.Property(e => e.DrugPrice)
                    .HasColumnName("Drug_Price")
                    .HasDefaultValueSql("((50))");
            });

            modelBuilder.Entity<DrugTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Drug_time");

                entity.Property(e => e.Afternoon).HasDefaultValueSql("((1))");

                entity.Property(e => e.Evening).HasDefaultValueSql("((1))");

                entity.Property(e => e.Morning).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DrugNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Drug)
                    .HasConstraintName("FK_Drug_time_drug_id");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK_Drug_time_patient_id");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PatientAge).HasColumnName("Patient_Age");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Patient_Name");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Illness)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Treatment");

                entity.HasOne(d => d.Assistant1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Assistant1)
                    .HasConstraintName("FK_Treatment_assistant1_Id");

                entity.HasOne(d => d.Assistant2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Assistant2)
                    .HasConstraintName("FK_Treatment_assistant2_Id");

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Doctor)
                    .HasConstraintName("FK_Treatment_doctor_id");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK_Treatment_patient_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
