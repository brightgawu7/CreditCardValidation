using System.Text.RegularExpressions;

namespace CreditCardValidation.Web.Pages
{
	public partial class Index
	{


		public bool RotateCard { get; set; } = false;


		public string GetCardTypeFromNumber(string cardNumber)
		{
			if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length < 4)
			{
				return "Unknown";
			}

			// Extract the first four digits of the card number
			string firstFourDigits = cardNumber.Substring(0, 4);

			if (Regex.IsMatch(firstFourDigits, @"^4"))
				return "Visa";
			else if (Regex.IsMatch(firstFourDigits, @"^5[1-5]"))
				return "MasterCard";
			else if (Regex.IsMatch(firstFourDigits, @"^6(?:011|5[0-9]{2})"))
				return "Discover";
			else
				return "";
		}

		private void HandleRotateCard(bool rotate)
		{
			RotateCard = rotate;
		}

		private static List<string> Months
		{
			get
			{
				var months = new List<string>
				{
					"01",
					"02",
					"03",
					"04",
					"05",
					"06",
					"07",
					"08",
					"09",
					"10",
					"11",
					"12"
				};
				return months;
			}
		}


		private static List<string> GetYears()
		{
			const int numberOfYears = 12;

			int currentYear = DateTime.Now.Year;
			var yearsList = new List<string>();

			for (int index = 0; index < numberOfYears; index++)
			{
				yearsList.Add((currentYear + index).ToString());
			}

			return yearsList;
		}
	}
}
