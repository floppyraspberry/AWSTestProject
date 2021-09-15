using Helpers;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AWSProject
{
    public class Common : BaseTests
    {
        protected async Task<HttpResponseMessage> Get(string path)
        {
            var url = $"{Urls.GeckoUrl}{path}";
            Log.Information(url);
            HttpClientInstance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return await HttpClientInstance.GetAsync(url);
        }
    }
}
