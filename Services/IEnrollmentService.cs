using ElevateProjectFinal.Models;

namespace ElevateProjectFinal.Services
{
    public interface IEnrollmentService
    {
        void Create(Enrollment enrollment);
        void Update(Enrollment enrollment);
        void Delete(int id);
        Enrollment Read(int id);
        List<Enrollment> ReadAll();
    }
}
