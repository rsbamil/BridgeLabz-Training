using DBConnect.Models;

namespace DBConnect.Interfaces
{
    public interface IPatientService
    {
        void RegisterPatient(Patient patient);
        void UpdatePatient(int id, string address);
        void SearchPatient(string name);
    }
}
