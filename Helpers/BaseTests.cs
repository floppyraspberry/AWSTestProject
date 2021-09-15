using Helpers.Configuration;
using Helpers.Models;
using Helpers.Settings;

using Microsoft.Extensions.Configuration;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Helpers
{
    public class BaseTests
    {
        public readonly IConfiguration Configuration;
        protected Serilog.ILogger Log { get; set; }
        protected HttpClient HttpClientInstance { get; set; }
        protected Urls Urls { get; }
        protected ClientSettings ClientSettings { get; }


        public readonly Token token;


        public BaseTests()
        {
            token = new Token();
            Configuration = ConfigurationRead.Create();
            HttpClientInstance = new HttpClient();
            Urls = Configuration.GetSection("Urls").Get<Urls>();
        }

        protected IAsyncPolicy<HttpResponseMessage> GetRetryPolicy(IEnumerable<HttpStatusCode> allowedStatusCodes) => HttpPolicyExtensions
            .HandleTransientHttpError()
            .OrResult(r => !allowedStatusCodes.Contains(r.StatusCode))
            .WaitAndRetryAsync(4, attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt)));

        public void Dispose() { }
    }
}
