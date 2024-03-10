using Abdul20.Models;
namespace Abdul20.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);  //ye dono abstarct method 
        //hai kyonki interface ke ander jo bhi method hota hai wo 
        //abstract method hota hai jis ka sirf declaration hota hai
        //implementation nahi hota hai 

    }
}
