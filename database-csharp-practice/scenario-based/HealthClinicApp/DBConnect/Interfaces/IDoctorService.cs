using DBConnect.Models;

namespace DBConnect.Interfaces

{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        void DeactivateDoctor(int doctorId);
        void ViewDoctorsBySpecialty(string specialty);
    }
}
