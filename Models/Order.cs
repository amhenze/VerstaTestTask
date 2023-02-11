using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace verstaTest.Models
{
	public class Order
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[MaxLength(40)]
		public string SenderCity { get; set; }
		[Required]
		[MaxLength(100)]
		public string SendersAddress { get; set; }
		[Required]
		[MaxLength(40)]
		public string ShippingCity { get; set; }
		[Required]
		[MaxLength(100)]
		public string RecipientsAddress { get; set; }
		[Required]
		public decimal Weight { get; set; }
		[Required]
		public DateTime PickupDate { get; set; }
	}
}
