using Newtonsoft.Json;

namespace Helpers.Models
{
    public class GeckoCoinHistoryResponse
    {
        public class Image
        {
            [JsonProperty("thumb")]
            public string Thumb { get; set; }

            [JsonProperty("small")]
            public string Small { get; set; }
        }
        public class CurrentPrice
        {
            [JsonProperty("aed")]
            public double Aed { get; set; }

            [JsonProperty("ars")]
            public double Ars { get; set; }

            [JsonProperty("aud")]
            public double Aud { get; set; }

            [JsonProperty("bch")]
            public double Bch { get; set; }

            [JsonProperty("bdt")]
            public double Bdt { get; set; }

            [JsonProperty("bhd")]
            public double Bhd { get; set; }

            [JsonProperty("bmd")]
            public double Bmd { get; set; }

            [JsonProperty("bnb")]
            public double Bnb { get; set; }

            [JsonProperty("brl")]
            public double Brl { get; set; }

            [JsonProperty("btc")]
            public double Btc { get; set; }

            [JsonProperty("cad")]
            public double Cad { get; set; }

            [JsonProperty("chf")]
            public double Chf { get; set; }

            [JsonProperty("clp")]
            public double Clp { get; set; }

            [JsonProperty("cny")]
            public double Cny { get; set; }

            [JsonProperty("czk")]
            public double Czk { get; set; }

            [JsonProperty("dkk")]
            public double Dkk { get; set; }

            [JsonProperty("eos")]
            public double Eos { get; set; }

            [JsonProperty("eth")]
            public double Eth { get; set; }

            [JsonProperty("eur")]
            public double Eur { get; set; }

            [JsonProperty("gbp")]
            public double Gbp { get; set; }

            [JsonProperty("hkd")]
            public double Hkd { get; set; }

            [JsonProperty("huf")]
            public double Huf { get; set; }

            [JsonProperty("idr")]
            public double Idr { get; set; }

            [JsonProperty("ils")]
            public double Ils { get; set; }

            [JsonProperty("inr")]
            public double Inr { get; set; }

            [JsonProperty("jpy")]
            public double Jpy { get; set; }

            [JsonProperty("krw")]
            public double Krw { get; set; }

            [JsonProperty("kwd")]
            public double Kwd { get; set; }

            [JsonProperty("lkr")]
            public double Lkr { get; set; }

            [JsonProperty("ltc")]
            public double Ltc { get; set; }

            [JsonProperty("mmk")]
            public double Mmk { get; set; }

            [JsonProperty("mxn")]
            public double Mxn { get; set; }

            [JsonProperty("myr")]
            public double Myr { get; set; }

            [JsonProperty("ngn")]
            public double Ngn { get; set; }

            [JsonProperty("nok")]
            public double Nok { get; set; }

            [JsonProperty("nzd")]
            public double Nzd { get; set; }

            [JsonProperty("php")]
            public double Php { get; set; }

            [JsonProperty("pkr")]
            public double Pkr { get; set; }

            [JsonProperty("pln")]
            public double Pln { get; set; }

            [JsonProperty("rub")]
            public double Rub { get; set; }

            [JsonProperty("sar")]
            public double Sar { get; set; }

            [JsonProperty("sek")]
            public double Sek { get; set; }

            [JsonProperty("sgd")]
            public double Sgd { get; set; }

            [JsonProperty("thb")]
            public double Thb { get; set; }

            [JsonProperty("try")]
            public double Try { get; set; }

            [JsonProperty("twd")]
            public double Twd { get; set; }

            [JsonProperty("uah")]
            public double Uah { get; set; }

            [JsonProperty("usd")]
            public double Usd { get; set; }

            [JsonProperty("vef")]
            public double Vef { get; set; }

            [JsonProperty("vnd")]
            public double Vnd { get; set; }

            [JsonProperty("xag")]
            public double Xag { get; set; }

            [JsonProperty("xau")]
            public double Xau { get; set; }

            [JsonProperty("xdr")]
            public double Xdr { get; set; }

            [JsonProperty("xlm")]
            public double Xlm { get; set; }

            [JsonProperty("xrp")]
            public double Xrp { get; set; }

            [JsonProperty("zar")]
            public double Zar { get; set; }

            [JsonProperty("bits")]
            public double Bits { get; set; }

            [JsonProperty("link")]
            public double Link { get; set; }

            [JsonProperty("sats")]
            public double Sats { get; set; }
        }

        public class MarketCap
        {
            [JsonProperty("aed")]
            public double Aed { get; set; }

            [JsonProperty("ars")]
            public double Ars { get; set; }

            [JsonProperty("aud")]
            public double Aud { get; set; }

            [JsonProperty("bch")]
            public double Bch { get; set; }

            [JsonProperty("bdt")]
            public double Bdt { get; set; }

            [JsonProperty("bhd")]
            public double Bhd { get; set; }

            [JsonProperty("bmd")]
            public double Bmd { get; set; }

            [JsonProperty("bnb")]
            public double Bnb { get; set; }

            [JsonProperty("brl")]
            public double Brl { get; set; }

            [JsonProperty("btc")]
            public double Btc { get; set; }

            [JsonProperty("cad")]
            public double Cad { get; set; }

            [JsonProperty("chf")]
            public double Chf { get; set; }

            [JsonProperty("clp")]
            public double Clp { get; set; }

            [JsonProperty("cny")]
            public double Cny { get; set; }

            [JsonProperty("czk")]
            public double Czk { get; set; }

            [JsonProperty("dkk")]
            public double Dkk { get; set; }

            [JsonProperty("eos")]
            public double Eos { get; set; }

            [JsonProperty("eth")]
            public double Eth { get; set; }

            [JsonProperty("eur")]
            public double Eur { get; set; }

            [JsonProperty("gbp")]
            public double Gbp { get; set; }

            [JsonProperty("hkd")]
            public double Hkd { get; set; }

            [JsonProperty("huf")]
            public double Huf { get; set; }

            [JsonProperty("idr")]
            public double Idr { get; set; }

            [JsonProperty("ils")]
            public double Ils { get; set; }

            [JsonProperty("inr")]
            public double Inr { get; set; }

            [JsonProperty("jpy")]
            public double Jpy { get; set; }

            [JsonProperty("krw")]
            public double Krw { get; set; }

            [JsonProperty("kwd")]
            public double Kwd { get; set; }

            [JsonProperty("lkr")]
            public double Lkr { get; set; }

            [JsonProperty("ltc")]
            public double Ltc { get; set; }

            [JsonProperty("mmk")]
            public double Mmk { get; set; }

            [JsonProperty("mxn")]
            public double Mxn { get; set; }

            [JsonProperty("myr")]
            public double Myr { get; set; }

            [JsonProperty("ngn")]
            public double Ngn { get; set; }

            [JsonProperty("nok")]
            public double Nok { get; set; }

            [JsonProperty("nzd")]
            public double Nzd { get; set; }

            [JsonProperty("php")]
            public double Php { get; set; }

            [JsonProperty("pkr")]
            public double Pkr { get; set; }

            [JsonProperty("pln")]
            public double Pln { get; set; }

            [JsonProperty("rub")]
            public double Rub { get; set; }

            [JsonProperty("sar")]
            public double Sar { get; set; }

            [JsonProperty("sek")]
            public double Sek { get; set; }

            [JsonProperty("sgd")]
            public double Sgd { get; set; }

            [JsonProperty("thb")]
            public double Thb { get; set; }

            [JsonProperty("try")]
            public double Try { get; set; }

            [JsonProperty("twd")]
            public double Twd { get; set; }

            [JsonProperty("uah")]
            public double Uah { get; set; }

            [JsonProperty("usd")]
            public double Usd { get; set; }

            [JsonProperty("vef")]
            public double Vef { get; set; }

            [JsonProperty("vnd")]
            public double Vnd { get; set; }

            [JsonProperty("xag")]
            public double Xag { get; set; }

            [JsonProperty("xau")]
            public double Xau { get; set; }

            [JsonProperty("xdr")]
            public double Xdr { get; set; }

            [JsonProperty("xlm")]
            public double Xlm { get; set; }

            [JsonProperty("xrp")]
            public double Xrp { get; set; }

            [JsonProperty("zar")]
            public double Zar { get; set; }

            [JsonProperty("bits")]
            public double Bits { get; set; }

            [JsonProperty("link")]
            public double Link { get; set; }

            [JsonProperty("sats")]
            public double Sats { get; set; }
        }

        public class TotalVolume
        {
            [JsonProperty("aed")]
            public double Aed { get; set; }

            [JsonProperty("ars")]
            public double Ars { get; set; }

            [JsonProperty("aud")]
            public double Aud { get; set; }

            [JsonProperty("bch")]
            public double Bch { get; set; }

            [JsonProperty("bdt")]
            public double Bdt { get; set; }

            [JsonProperty("bhd")]
            public double Bhd { get; set; }

            [JsonProperty("bmd")]
            public double Bmd { get; set; }

            [JsonProperty("bnb")]
            public double Bnb { get; set; }

            [JsonProperty("brl")]
            public double Brl { get; set; }

            [JsonProperty("btc")]
            public double Btc { get; set; }

            [JsonProperty("cad")]
            public double Cad { get; set; }

            [JsonProperty("chf")]
            public double Chf { get; set; }

            [JsonProperty("clp")]
            public double Clp { get; set; }

            [JsonProperty("cny")]
            public double Cny { get; set; }

            [JsonProperty("czk")]
            public double Czk { get; set; }

            [JsonProperty("dkk")]
            public double Dkk { get; set; }

            [JsonProperty("eos")]
            public double Eos { get; set; }

            [JsonProperty("eth")]
            public double Eth { get; set; }

            [JsonProperty("eur")]
            public double Eur { get; set; }

            [JsonProperty("gbp")]
            public double Gbp { get; set; }

            [JsonProperty("hkd")]
            public double Hkd { get; set; }

            [JsonProperty("huf")]
            public double Huf { get; set; }

            [JsonProperty("idr")]
            public double Idr { get; set; }

            [JsonProperty("ils")]
            public double Ils { get; set; }

            [JsonProperty("inr")]
            public double Inr { get; set; }

            [JsonProperty("jpy")]
            public double Jpy { get; set; }

            [JsonProperty("krw")]
            public double Krw { get; set; }

            [JsonProperty("kwd")]
            public double Kwd { get; set; }

            [JsonProperty("lkr")]
            public double Lkr { get; set; }

            [JsonProperty("ltc")]
            public double Ltc { get; set; }

            [JsonProperty("mmk")]
            public double Mmk { get; set; }

            [JsonProperty("mxn")]
            public double Mxn { get; set; }

            [JsonProperty("myr")]
            public double Myr { get; set; }

            [JsonProperty("ngn")]
            public double Ngn { get; set; }

            [JsonProperty("nok")]
            public double Nok { get; set; }

            [JsonProperty("nzd")]
            public double Nzd { get; set; }

            [JsonProperty("php")]
            public double Php { get; set; }

            [JsonProperty("pkr")]
            public double Pkr { get; set; }

            [JsonProperty("pln")]
            public double Pln { get; set; }

            [JsonProperty("rub")]
            public double Rub { get; set; }

            [JsonProperty("sar")]
            public double Sar { get; set; }

            [JsonProperty("sek")]
            public double Sek { get; set; }

            [JsonProperty("sgd")]
            public double Sgd { get; set; }

            [JsonProperty("thb")]
            public double Thb { get; set; }

            [JsonProperty("try")]
            public double Try { get; set; }

            [JsonProperty("twd")]
            public double Twd { get; set; }

            [JsonProperty("uah")]
            public double Uah { get; set; }

            [JsonProperty("usd")]
            public double Usd { get; set; }

            [JsonProperty("vef")]
            public double Vef { get; set; }

            [JsonProperty("vnd")]
            public double Vnd { get; set; }

            [JsonProperty("xag")]
            public double Xag { get; set; }

            [JsonProperty("xau")]
            public double Xau { get; set; }

            [JsonProperty("xdr")]
            public double Xdr { get; set; }

            [JsonProperty("xlm")]
            public double Xlm { get; set; }

            [JsonProperty("xrp")]
            public double Xrp { get; set; }

            [JsonProperty("zar")]
            public double Zar { get; set; }

            [JsonProperty("bits")]
            public double Bits { get; set; }

            [JsonProperty("link")]
            public double Link { get; set; }

            [JsonProperty("sats")]
            public double Sats { get; set; }
        }

        public class MarketData
        {
            [JsonProperty("current_price")]
            public CurrentPrice CurrentPrice { get; set; }

            [JsonProperty("market_cap")]
            public MarketCap MarketCap { get; set; }

            [JsonProperty("total_volume")]
            public TotalVolume TotalVolume { get; set; }
        }

        public class CommunityData
        {
            [JsonProperty("facebook_likes")]
            public object FacebookLikes { get; set; }

            [JsonProperty("twitter_followers")]
            public int TwitterFollowers { get; set; }

            [JsonProperty("reddit_average_posts_48h")]
            public double RedditAveragePosts48h { get; set; }

            [JsonProperty("reddit_average_comments_48h")]
            public double RedditAverageComments48h { get; set; }

            [JsonProperty("reddit_subscribers")]
            public int RedditSubscribers { get; set; }

            [JsonProperty("reddit_accounts_active_48h")]
            public string RedditAccountsActive48h { get; set; }
        }

        public class CodeAdditionsDeletions4Weeks
        {
            [JsonProperty("additions")]
            public int Additions { get; set; }

            [JsonProperty("deletions")]
            public int Deletions { get; set; }
        }

        public class DeveloperData
        {
            [JsonProperty("forks")]
            public int Forks { get; set; }

            [JsonProperty("stars")]
            public int Stars { get; set; }

            [JsonProperty("subscribers")]
            public int Subscribers { get; set; }

            [JsonProperty("total_issues")]
            public int TotalIssues { get; set; }

            [JsonProperty("closed_issues")]
            public int ClosedIssues { get; set; }

            [JsonProperty("pull_requests_merged")]
            public int PullRequestsMerged { get; set; }

            [JsonProperty("pull_request_contributors")]
            public int PullRequestContributors { get; set; }

            [JsonProperty("code_additions_deletions_4_weeks")]
            public CodeAdditionsDeletions4Weeks CodeAdditionsDeletions4Weeks { get; set; }

            [JsonProperty("commit_count_4_weeks")]
            public int CommitCount4Weeks { get; set; }
        }

        public class PublicInterestStats
        {
            [JsonProperty("alexa_rank")]
            public int AlexaRank { get; set; }

            [JsonProperty("bing_matches")]
            public object BingMatches { get; set; }
        }

        public class Root
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("symbol")]
            public string Symbol { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("market_data")]
            public MarketData MarketData { get; set; }

            [JsonProperty("community_data")]
            public CommunityData CommunityData { get; set; }

            [JsonProperty("developer_data")]
            public DeveloperData DeveloperData { get; set; }

            [JsonProperty("public_interest_stats")]
            public PublicInterestStats PublicInterestStats { get; set; }
        }
    }
}
