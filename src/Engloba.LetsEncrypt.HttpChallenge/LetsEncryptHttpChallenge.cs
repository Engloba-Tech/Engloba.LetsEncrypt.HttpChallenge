using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Engloba.LetsEncrypt.HttpChallenge
{
    public class LetsEncryptHttpChallenge : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var configuration = context.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            var settings = configuration.GetSection("LetsEncrypt").Get<LetsEncryptSettings>();

            if (context.Request.Path == $"/.well-known/acme-challenge/{settings.HttpChallengeEndpoint}")
                await context.Response.WriteAsync(settings.HttpChallengeKey);
        }
    }

    public static class LetsEncryptHttpChallengeExtensions
    {
        public static IApplicationBuilder UseLetsEncryptChallenge(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LetsEncryptHttpChallenge>();
        }
    }
}
