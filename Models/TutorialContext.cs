using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tutorial_Manager.Models
{
    public partial class TutorialContext : DbContext
    {
        public TutorialContext()
        {
        }

        public TutorialContext(DbContextOptions<TutorialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Confirmation> Confirmations { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Performance> Performances { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentRegistration> StudentRegistrations { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeacherRegistration> TeacherRegistrations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-U93620R\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True; Pooling=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId)
                    .ValueGeneratedNever()
                    .HasColumnName("Address_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HouseNumber).HasColumnName("House_number");

                entity.Property(e => e.KefleK)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Kefle_K");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__address__Student__5629CD9C");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__address__Teacher__571DF1D5");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("attendance");

                entity.Property(e => e.AttendanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Attendance_ID");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__attendanc__Sched__4F7CD00D");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__attendanc__Stude__4CA06362");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__attendanc__Subje__4D94879B");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__attendanc__Teach__4E88ABD4");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Comment_ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__comment__Parent___52593CB8");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__comment__Teacher__534D60F1");
            });

            modelBuilder.Entity<Confirmation>(entity =>
            {
                entity.ToTable("confirmation");

                entity.Property(e => e.ConfirmationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Confirmation_ID");

                entity.Property(e => e.ConfirmationContent)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Confirmation_content");

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnType("date")
                    .HasColumnName("Confirmation_Date");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Confirmations)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__confirmat__Paren__59FA5E80");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Confirmations)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK__confirmat__Payme__5AEE82B9");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parent");

                entity.Property(e => e.ParentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Parent_ID");

                entity.Property(e => e.ParentFname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Parent_FName");

                entity.Property(e => e.ParentLname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Parent_LName");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Payment_ID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("Payment_Date");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__payment__Parent___3E52440B");
            });

            modelBuilder.Entity<Performance>(entity =>
            {
                entity.ToTable("performance");

                entity.Property(e => e.PerformanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Performance_ID");

                entity.Property(e => e.PerformanceDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Performance_Details");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__performan__Sched__47DBAE45");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__performan__Stude__46E78A0C");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__performan__Subje__49C3F6B7");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__performan__Teach__48CFD27E");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.Property(e => e.ScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Schedule_ID");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnType("date")
                    .HasColumnName("Schedule_Date");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__schedule__Subjec__440B1D61");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Student_ID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.StudentFname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Student_FName");

                entity.Property(e => e.StudentLname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Student_LName");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__student__Parent___3A81B327");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__student__Teacher__3B75D760");
            });

            modelBuilder.Entity<StudentRegistration>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.SubjectId })
                    .HasName("PK__student___DF6C1CE1E73D81D0");

                entity.ToTable("student_Registration");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("Registration_Date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentRegistrations)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_R__Stude__5DCAEF64");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudentRegistrations)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_R__Subje__5EBF139D");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("subject");

                entity.Property(e => e.SubjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("Subject_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Subject_Name");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK__subject__Payment__412EB0B6");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teacher");

                entity.Property(e => e.TeacherId)
                    .ValueGeneratedNever()
                    .HasColumnName("teacher_ID");

                entity.Property(e => e.Cv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CV");

                entity.Property(e => e.TeacherFname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("teacher_FName");

                entity.Property(e => e.TeacherLname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("teacher_LName");
            });

            modelBuilder.Entity<TeacherRegistration>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.SubjectId })
                    .HasName("PK__teacher___EF67B9C65BF51B18");

                entity.ToTable("teacher_Registration");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("Registration_Date");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherRegistrations)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__teacher_R__Subje__628FA481");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherRegistrations)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__teacher_R__Teach__619B8048");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
