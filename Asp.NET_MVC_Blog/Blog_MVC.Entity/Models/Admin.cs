using System.ComponentModel.DataAnnotations;

namespace Blog_MVC.Entity.Models
{
    public class Admin : Base
    {
        public int AdminID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string NameSurname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

    }
}
