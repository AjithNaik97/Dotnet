using StudentManagementSystem.Models;
using System.Net.Http.Headers;

namespace StudentManagementSystem.Repository
{
    public interface IStudentManager
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
