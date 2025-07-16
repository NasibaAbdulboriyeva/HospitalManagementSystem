using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }

        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<OperationSchedule> OperationSchedules { get; set; }
        public DbSet<OperationTheatre> OperationTheatres { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
        public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }


    }
}
