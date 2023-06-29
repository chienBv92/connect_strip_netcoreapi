using StripDemo.Models.Strip;
using System;
namespace StripDemo.Models.Strip
{
	public record AddStripeCustomer(
		string Email,
		string Name,
		AddStripeCard CreditCard);
}

