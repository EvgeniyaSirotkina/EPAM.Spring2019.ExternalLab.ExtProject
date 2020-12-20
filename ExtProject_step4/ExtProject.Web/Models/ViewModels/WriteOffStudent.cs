using System.Collections.Generic;

namespace ExtProject.Web.Models.ViewModels
{
    public class WriteOffStudent
    {
        public IEnumerable<Student> List { get; set; }

        public int CurentPage { get; set; }

        public int Pages { get; set; }
    }
}