namespace ExtProject.Web.Models.ViewModels
{
    public class StudentsViewModel
    {
        public GraduateStudent GraduateStudents { get; set; } = new GraduateStudent();

        public ExpelledStudent ExpelledStudents { get; set; } = new ExpelledStudent();

        public WriteOffStudent WriteOffStudents { get; set; } = new WriteOffStudent();
    }
}