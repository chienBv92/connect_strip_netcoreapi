using StripDemo.Models.Strip;

namespace StripDemo.Contracts
{
	public interface IStripeAppService
	{
		Task<StripeCustomer> AddStripeCustomerAsync(AddStripeCustomer customer, CancellationToken ct);
		Task<StripePayment> AddStripePaymentAsync(AddStripePayment payment, CancellationToken ct);
	}
}
