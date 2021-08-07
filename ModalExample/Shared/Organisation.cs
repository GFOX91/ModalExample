using System.ComponentModel.DataAnnotations;

namespace ModalExample.Shared
{
	public class Organisation
	{
		[Required]
		[MaxLength(255)]
		public string Name { get; set; }
	}
}
