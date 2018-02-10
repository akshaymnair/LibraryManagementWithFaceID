using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class StudentManager
    {
        public int NewStudent(Student student)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                ctx.Students.Add(student);
            }
            return rows;
        }

        public Student FindById(int id)
        {
            Student s = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                s = ctx.Students.Find(id);
            }
            return s;
        }

        public Student FindByName(String student)
        {
            Student s = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var st = ctx.Students.Where(stu => stu.Name == student);

                s = (Student)st;
            }
            return s;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var sts = from student in ctx.Students
                          select student;
                students = sts.ToList();
            }
            return students;
        }

        public List<String> GetAllStudentNames()
        {
            List<String> studentNames = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var sts = from student in ctx.Students
                          select student.Name;
                studentNames = sts.ToList();
            }
            return studentNames;
        }
    }
}
