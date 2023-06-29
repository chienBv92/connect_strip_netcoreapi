using Microsoft.AspNetCore.Mvc;

namespace StripDemo.Models.Strip
{
    public record AddStripeCard(
        string Name,
        string CardNumber,
        string ExpirationYear,
        string ExpirationMonth,
        string Cvc);
}
