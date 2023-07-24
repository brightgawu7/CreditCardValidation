using CreditCardValidation.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace CreditCardValidation.Web.Data
{
	public class CreditCardDbContext : DbContext
	{

		public CreditCardDbContext(DbContextOptions options) : base(options) { }

		public DbSet<CreditCard> CreditCards { get; set; }
	}
}
