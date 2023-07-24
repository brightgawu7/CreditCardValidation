using System;
using CreditCardValidation.Web.Data;
using CreditCardValidation.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace CreditCardValidation.Web.Repository
{
	public class CreditCardRepository
	{
		private readonly CreditCardDbContext _context;

		public CreditCardRepository(CreditCardDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CreditCard>> GetCreditCards()
		{
			var creditCards = await _context.CreditCards.ToListAsync();

			return creditCards;
		}
		public async void AddCard(CreditCard creditCard)
		{
			_context.CreditCards.Add(creditCard);
			await _context.SaveChangesAsync();
		}
	}
}
