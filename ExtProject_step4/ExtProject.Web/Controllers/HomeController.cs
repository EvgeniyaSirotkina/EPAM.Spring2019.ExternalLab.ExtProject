using ExtProject.Web.EF;
using ExtProject.Web.Models;
using ExtProject.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ExtProject.Web.Controllers
{
    public class HomeController : Controller
    {
        EFDbContext db = new EFDbContext("DefaultConnectionString");

        public ActionResult Index()
        {
            return View(LoadFirstTenStudents());
        }

        //для вывода окончивших учебу
        public ActionResult GraduateStudentsView(string page = "1")
        {
            int currentPage = Convert.ToInt32(page);  // запрашиваемая страница

            int pageSize = 10;  // кол-во записей в таблице
            int countStudents = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.Category.CategoryName == "Окончили").Count();

            int pages = countStudents % pageSize == 0 ? countStudents / pageSize : countStudents / pageSize + 1;

            // проверяем страницу
            if (currentPage > pages)
                currentPage = pages;

            if (currentPage < 1)
                currentPage = 1;

            var students = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.Category.CategoryName == "Окончили")
                .OrderBy(s => s.Surname)
                .Skip((currentPage - 1) * pageSize)
                .Take(10);

            return PartialView(students);
        }

        // для вывода отчисленных
        public ActionResult ExpelledStudentsView(string page = "1")
        {
            var currentPage = Convert.ToInt32(page);  // запрашиваемая страница

            var pageSize = 10;  // кол-во записей в таблице
            var countStudents = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.Category.CategoryName == "Отчислены").Count();

            var pages = countStudents % pageSize == 0 ? countStudents / pageSize : countStudents / pageSize + 1;

            // проверяем страницу
            if (currentPage > pages)
                currentPage = pages;

            if (currentPage < 1)
                currentPage = 1;

            var students = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.Category.CategoryName == "Отчислены")
                .OrderBy(s => s.Surname)
                .Skip((currentPage - 1) * pageSize)
                .Take(10);

            return PartialView(students);
        }

        // для вывода дел на списание
        public ActionResult WriteOffStudentsView(string page = "1")
        {
            var currentPage = Convert.ToInt32(page);  // запрашиваемая страница

            var pageSize = 10;  // кол-во записей в таблице
            var countStudents = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.CategoryId != 3)
                .Where(s => (s.GraduationOrDeductionRate == 4 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 75) ||
                            ((s.GraduationOrDeductionRate == 3 || s.GraduationOrDeductionRate == 2) && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 15 && s.AvailabilityOfEducationCertificate == false) ||
                            (s.GraduationOrDeductionRate == 1 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 5 && s.AvailabilityOfEducationCertificate == false))
                .Count();

            int pages = countStudents % pageSize == 0 ? countStudents / pageSize : countStudents / pageSize + 1;

            // проверяем страницу
            if (currentPage > pages)
                currentPage = pages;

            if (currentPage < 1)
                currentPage = 1;

            var students = db.Students
                .Include("Category").Include("Group")
                .Where(s => s.CategoryId != 3)
                .Where(s => (s.GraduationOrDeductionRate == 4 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 75) ||
                            ((s.GraduationOrDeductionRate == 3 || s.GraduationOrDeductionRate == 2) && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 15 && s.AvailabilityOfEducationCertificate == false) ||
                            (s.GraduationOrDeductionRate == 1 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 5 && s.AvailabilityOfEducationCertificate == false))
                .OrderBy(s => s.Surname)
                .Skip((currentPage - 1) * pageSize)
                .Take(10);

            return PartialView(students);
        }

        private StudentsViewModel LoadFirstTenStudents()
        {
            var firstTenStudentViewModel = new StudentsViewModel();

            int count;
            var pageSize = 10;

            var students = db.Students
                .Include("Category").Include("Group");

            firstTenStudentViewModel.GraduateStudents.List = students
                .Where(s => s.Category.CategoryName == "Окончили").Take(10);

            count = students.Where(s => s.Category.CategoryName == "Окончили").Count();

            firstTenStudentViewModel.GraduateStudents.Pages = count % 10 == 0 ? count / 10 : count / 10 + 1;
            firstTenStudentViewModel.GraduateStudents.CurentPage = 1;

            firstTenStudentViewModel.ExpelledStudents.List = students
                .Where(s => s.Category.CategoryName == "Отчислены").Take(10);

            count = students.Where(s => s.Category.CategoryName == "Отчислены").Count();

            firstTenStudentViewModel.ExpelledStudents.Pages = count % 10 == 0 ? count / 10 : count / 10 + 1;
            firstTenStudentViewModel.ExpelledStudents.CurentPage = 1;

            firstTenStudentViewModel.WriteOffStudents.List = students
                .Where(s => s.CategoryId != 3)
                .Where(s => (s.GraduationOrDeductionRate == 4 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 75) ||
                            ((s.GraduationOrDeductionRate == 3 || s.GraduationOrDeductionRate == 2) && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 15 && s.AvailabilityOfEducationCertificate == false) ||
                            (s.GraduationOrDeductionRate == 1 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 5 && s.AvailabilityOfEducationCertificate == false))
                .Take(10);

            count = students
                .Where(s => s.CategoryId != 3)
                .Where(s => (s.GraduationOrDeductionRate == 4 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 75) ||
                            ((s.GraduationOrDeductionRate == 3 || s.GraduationOrDeductionRate == 2) && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 15 && s.AvailabilityOfEducationCertificate == false) ||
                            (s.GraduationOrDeductionRate == 1 && (DateTime.Now.Year - s.YearOfEndingOrDeduction) > 5 && s.AvailabilityOfEducationCertificate == false))
                .Count();

            firstTenStudentViewModel.WriteOffStudents.Pages = count % 10 == 0 ? count / 10 : count / 10 + 1;
            firstTenStudentViewModel.WriteOffStudents.CurentPage = 1;

            return firstTenStudentViewModel;
        }

        public ActionResult WriteOff(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return HttpNotFound();
            }

            student.CategoryId = 3;
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();

            return View("Index", LoadFirstTenStudents());
        }
    }
 }