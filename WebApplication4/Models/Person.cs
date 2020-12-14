
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
	public class Person
	{
		public int PersonId { get; set; }
		[Required(ErrorMessage = "Это поле обязательно для заполнения")]
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		[Required(ErrorMessage = "Это поле обязательно для заполнения")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime Birthday { get; set; }
		public string Corporation { get; set; }
		public string EmployeePosition { get; set; }
		public virtual ContactInformation ContactInformation { get; set; }
	}
}