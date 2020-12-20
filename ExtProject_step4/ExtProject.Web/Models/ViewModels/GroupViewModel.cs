using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExtProject.Web.Models.ViewModels
{
    public class GroupViewModel
    {
        [DisplayName("Группа (краткое название)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(10, ErrorMessage = "Значение слишком длинное")]
        public string GroupName { get; set; }

        [DisplayName("Группа (полное наименование)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(75, ErrorMessage = "Значение слишком длинное")]
        public string FullGroupName { get; set; }
    }
}