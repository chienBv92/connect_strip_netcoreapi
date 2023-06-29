using Microsoft.AspNetCore.Mvc;
using StripDemo.Application;
using Stripe;

namespace StripDemo.Contracts
{
	public static class StripeInfrastructure
	{
		public static IServiceCollection AddStripeInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			StripeConfiguration.ApiKey = configuration.GetValue<string>("StripeSettings:SecretKey");

			return services
				.AddScoped<CustomerService>()
				.AddScoped<ChargeService>()
				.AddScoped<TokenService>()
				.AddScoped<IStripeAppService, StripeAppService>();
		}
	}
}
