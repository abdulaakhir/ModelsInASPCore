using Abdul20.Models;

namespace Abdul20.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }
        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel {rollNo = 1,Name="Abudl",Gender="Male",Standerd=10},
                new StudentModel {rollNo = 2,Name = "Aakhir", Gender = "Male", Standerd = 11 },
                new StudentModel {rollNo = 3,Name = "Waqar", Gender = "Male", Standerd = 12 },
                new StudentModel {rollNo = 4,Name = "Priya", Gender = "Female", Standerd = 12 },
                new StudentModel {rollNo = 5,Name = "Sopna", Gender = "Female", Standerd = 11 },
            };
        }
    }
}
