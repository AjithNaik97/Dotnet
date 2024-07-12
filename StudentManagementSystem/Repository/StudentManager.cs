using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repository
{
    public class StudentManager : IStudentManager
    {
        public void Insert(Students student)
        {
            using (var context = new CollectionContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public List<Students> GetAll()
        {
            using(var context = new CollectionContext())
            {
                var students = from s
                               in context.Students
                               select s;
                return students.ToList<Students>();
            }
        }

        public Students GetById(int id)
        {
            using(var context= new CollectionContext())
            {
                return context.Students.Find(id);
            }
        }

        public void Update(Students student)
        {
            using (var context = new CollectionContext())
            {
                var stud = context.Students.Find(student.Id);
                if (stud != null)
                {
                    stud.Name = student.Name;
                    stud.Email = student.Email;
                    stud.Phone = student.Phone;
                    stud.Address = student.Address;
                    stud.Admission_Date = student.Admission_Date;
                    stud.Status = student.Status;
                    stud.Fees = student.Fees;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new CollectionContext())
            {
                var stud = context.Students.Find(id);
                if (stud != null)
                {
                    context.Students.Remove(stud);
                    context.SaveChanges();
                }
            }

        }

        public List<Students> SearchByStatus(bool stat)
        {
            using(var context=new CollectionContext())
            {
                List<Students> students = new List<Students>();
                foreach (Students stud in context.Students)
                {
                    if (stud.Status == stat)
                    {
                        students.Add(stud);
                    }
                }
                return students;
            }
        }

        public List<Students> SortStudents()
        {
            using (var context = new CollectionContext())
            {
                List<Students> stud = new List<Students>();
                stud = context.Students.OrderBy(s => s.Name).ToList();
                return stud;
            }
        }
    }
}
