using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
        void Insert(Students student);
        List<Students> GetAll();

        Students GetById(int id);

        void Update(Students student);

        void Delete(int id);

        List<Students> SearchByStatus(bool stat);
        List<Students> SortStudents();
    }

    
}
