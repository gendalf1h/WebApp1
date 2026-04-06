using System.ComponentModel.DataAnnotations; // для прописания атрибутов [Display(Name = "Имя")], что-бы Name отображалось как "Имя"

namespace WebApp1.Models

{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")] // Required - обязательно для заполнения иначе ошибка 
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Введите фамилию")]
        public string SurName { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [StringLength(30, ErrorMessage = "Текст должен быть менее 30 символов")]
        public string Message {  get; set; }



    }
}
