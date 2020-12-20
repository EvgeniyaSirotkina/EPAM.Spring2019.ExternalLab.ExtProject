using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExtProject.Web.Models.ViewModels
{
    public class StudentViewModel
    {
        [DisplayName("Номер дела")]
        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(20)]
        public string CaseNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public int YearOfBirth { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public int YearOfEntry { get; set; }

        public int YearOfEndingOrDeduction { get; set; }

        [Required]
        public int GraduationOrDeductionRate { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public int GroupId { get; set; }

        public IEnumerable<Group> Groups { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}