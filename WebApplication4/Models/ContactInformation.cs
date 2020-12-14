using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class ContactInformation
    {
		[Key]
		[ForeignKey("Person")]
		public int ContactInformationId { get; set; }
		public virtual Person Person { get; set; }
		[Required(ErrorMessage = "Это поле обязательно для заполнения")]
		public string Phone { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public string Skype { get; set; }
	}
}