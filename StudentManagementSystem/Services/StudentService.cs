using StudentManagementSystem.Models;
using StudentManagementSystem.Repository;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        IStudentManager studentManager = new StudentManager();
        public void Insert(Students student)
        {
            studentManager.Insert(student);
        }

        public List<Students> GetAll()
        {
            return studentManager.GetAll();
        }

        public Students GetById(int id)
        {
            return studentManager.GetById(id);
        }

        public void Update(Students student)
        {
            studentManager.Update(student);
        }

        public void Delete(int id)
        {
            studentManager.Delete(id);
        }

        public List<Students> SearchByStatus(bool stat)
        {
            return studentManager.SearchByStatus(stat);
        }

        public List<Students> SortStudents()
        {
            return studentManager.SortStudents();
        }
    }
}