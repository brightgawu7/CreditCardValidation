using CreditCardValidation.Web.Entities;
using Microsoft.AspNetCore.Components;

namespace CreditCardValidation.Web.Components
{
	public partial class CardInfoComponent
	{
		protected override void OnInitialized()
		{
			base.OnInitialized();

		



		}

		[Parameter]
		[EditorRequired]
		public char[] CardBumber { get; set; } = null!;

		[Parameter]
		[EditorRequired]
		public CreditCard CreditCardInfo { get; set; } = null!;

		[Parameter]
		[EditorRequired]
		public bool RotateCard { get; set; }

		[Parameter]
		[EditorRequired]
		public int BorderIndex { get; set; }
		
	}
}
