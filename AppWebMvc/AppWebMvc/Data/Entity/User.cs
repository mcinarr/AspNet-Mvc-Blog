using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Web.Mvc.Data.Entity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ad")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Soyad")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserSurname { get; set; }

		[Required(ErrorMessage = "{0} Boş Geçilemez.")]
		[DisplayName("Kullanıcı Adı")]
        [StringLength(15,ErrorMessage = "{0} En Fazla {1} Karakter Olabilir.")]
        [MinLength(5,ErrorMessage = "{0} En Az {1} Karakter Olabilir.")]
        public string UserNickName { get; set; }


        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Telefon Numarası")]
        [StringLength(11, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserPhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("E-Mail")]
        [EmailAddress(ErrorMessage = "Yanlış bir mail girdiniz.")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı E-Mail")]
        [PasswordPropertyText]
        public string UserPassword { get; set; }
    }
}
