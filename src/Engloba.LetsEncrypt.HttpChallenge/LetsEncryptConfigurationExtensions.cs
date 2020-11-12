using Engloba.LetsEncrypt.HttpChallenge;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class LetsEncryptConfigurationExtensions
    {
        public static IServiceCollection AddLetsEncryptHttpChallenge(this IServiceCollection services) 
        {
            return services.AddTransient<LetsEncryptHttpChallenge>();
        }
    }
}
