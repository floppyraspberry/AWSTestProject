using Helpers.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using Xunit;

namespace AWSProject
{
    public class Test : Common
    {
        [Fact]
        public async void CoinGeckoApiHealthCheck()
        {
            try
            {
                var path = $"ping";

                var response = await Get(path);
                var content = response.Content.ReadAsStringAsync();
                var actual = JsonConvert.DeserializeObject<GeckoApiHealthResponse>(await content);
                
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Contains("(V3) To the Moon!", actual.ResponseContent);
            }
            catch (Exception ex)
            {
                Log.Information(ex.ToString());
            }
        }

        [Theory]
        [InlineData("stellar", "dogecoin")]
        [InlineData("dodo", "dogecoin")]
        [InlineData("talleo", "stellar")]
        [InlineData("dodo", "talleo")]
        public async void CoinGeckoGetPriceTests(string crypto, string anotherCrypto)
        {
            try
            {
                var path = $"simple/price?ids={crypto}&vs_currencies={anotherCrypto}";

                var response = Get(path);
                var actual = await response.Result.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<GeckoApiHealthResponse>(actual);
                
                Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
            }
            catch (Exception ex)
            {
                Log.Information(ex.ToString());
            }
        }

        [Fact]
        public async void CoinGeckoGetCoinHistory()
        {
            try
            {
                var date = DateTime.Now.AddYears(-1).ToString("dd-MM-yyyy");
                var path = $"coins/stellar/history?date={date}&localization=false";

                var response = Get(path);
                var actual = await response.Result.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<GeckoCoinHistoryResponse>(actual);

                Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
            }
            catch (Exception ex)
            {
                Log.Information(ex.ToString());
            }
        }
    }
}
