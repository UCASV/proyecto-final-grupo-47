using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class project_dbContext : DbContext
    {
        public project_dbContext()
        {
        }

        public project_dbContext(DbContextOptions<project_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentPlace> AppointmentPlaces { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;port=3306;database=project_db;uid=root;password=firstpassword");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.HasIndex(e => e.IdEmployee, "FK_APPOINTMENTE_EMPLOYEE");

                entity.HasIndex(e => e.IdCabin, "FK_APPOINTMENT_CABIN");

                entity.HasIndex(e => e.Dui, "FK_APPOINTMENT_CITIZEN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompletedAppointment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("completed_appointment");

                entity.Property(e => e.DateHourAppointment).HasColumnName("date_hour_appointment");

                entity.Property(e => e.DateHourPreCheck).HasColumnName("date_hour_pre_check");

                entity.Property(e => e.DateHourVaccine).HasColumnName("date_hour_vaccine");

                entity.Property(e => e.Dui).HasColumnName("DUI");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IsSecondAppointment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("is_second_appointment");

                entity.Property(e => e.SecondaryEffect)
                    .HasMaxLength(200)
                    .HasColumnName("secondary_effect");

                entity.Property(e => e.SecondaryEffectDuration).HasColumnName("secondary_effect_duration");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Dui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENT_CITIZEN");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENT_CABIN");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENTE_EMPLOYEE");
            });

            modelBuilder.Entity<AppointmentPlace>(entity =>
            {
                entity.ToTable("appointment_place");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentPlace1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("appointment_place");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("cabin");

                entity.HasIndex(e => e.IdManager, "FK_CABIN_EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressCabin)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address_cabin");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("telephone")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CABIN_EMPLOYEE");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PRIMARY");

                entity.ToTable("citizen");

                entity.HasIndex(e => e.IdCabin, "FK_CITIZEN_CABIN");

                entity.HasIndex(e => e.BelongingInstitution, "FK_CITIZEN_INSTITUTION");

                entity.Property(e => e.Dui).HasColumnName("DUI");

                entity.Property(e => e.AddressCitizen)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address_citizen");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BelongingInstitution).HasColumnName("belonging_institution");

                entity.Property(e => e.DiseaseSuffer)
                    .HasMaxLength(200)
                    .HasColumnName("disease_suffer");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.NamePerson)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name_person");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("telephone")
                    .IsFixedLength(true);

                entity.HasOne(d => d.BelongingInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.BelongingInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZEN_INSTITUTION");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZEN_CABIN");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.HasIndex(e => e.IdEmployeeType, "FK_EMPLOYEE_EMPLOYEE_TYPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressEmployee)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address_employee");

                entity.Property(e => e.IdEmployeeType).HasColumnName("id_employee_type");

                entity.Property(e => e.InstitutionalMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("institutional_mail");

                entity.Property(e => e.NameEmployee)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name_employee");

                entity.Property(e => e.PasswordEmployee)
                    .HasMaxLength(30)
                    .HasColumnName("password_employee");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("telephone")
                    .IsFixedLength(true);

                entity.Property(e => e.UserEmployee)
                    .HasMaxLength(30)
                    .HasColumnName("user_employee");

                entity.HasOne(d => d.IdEmployeeTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdEmployeeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYEE_EMPLOYEE_TYPE");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("employee_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("institution");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsPriority)
                    .HasColumnType("bit(1)")
                    .HasColumnName("is_priority");

                entity.Property(e => e.NameInstitution)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_institution");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.HasIndex(e => e.IdCabin, "FK_LOGIN_CABIN");

                entity.HasIndex(e => e.IdEmployee, "FK_LOGIN_EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.SessionStartDate).HasColumnName("session_start_date");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOGIN_CABIN");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOGIN_EMPLOYEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
