namespace StripDemo.Models.Strip
{
	public record StripeCustomer(
		string Name,
		string Email,
		string CustomerId);
}
