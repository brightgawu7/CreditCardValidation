using System.ComponentModel.DataAnnotations;

namespace CreditCardValidation.Web.Entities
{
	public class CreditCard
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Card Number Required."), MinLength(16, ErrorMessage = "The required length is 16.")]
		public string CardNumber { get; set; } = null!;

		[Required(ErrorMessage = "Card Holder Name is Required."), MinLength(2, ErrorMessage = "The minimum length of a name is 2.")]
		public string CardName { get; set; } = null!;

		[Required(ErrorMessage = "CVV is Required."), MinLength(3, ErrorMessage = "The minimum length of a name is 2.")]
		public string CardCVV { get; set; } = null!;

		[Required(ErrorMessage = "Expiry Month  is Required.")]
		public string ExpiryMonth { get; set; } = null!;

		[Required(ErrorMessage = "Expiry Year is Required.")]
		public string ExpiryYear { get; set; } = null!;

		[Required(ErrorMessage = "Enter A Valid Credit Card Number.")]
		public string CardType { get; set; } = null!;
	}
}
