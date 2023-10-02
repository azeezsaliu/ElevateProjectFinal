using ElevateProjectFinal.Models;

namespace ElevateProjectFinal.Services
{
    public interface IAssignmentService
    {
        void Create(Assignment assignment);
        void Update(Assignment assignment);
        void Delete(int id);
        Assignment Read(int id);
        List<Assignment> ReadAll();

    }
}
