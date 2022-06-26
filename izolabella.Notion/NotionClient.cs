global using izolabella.Notion.Objects.Databases.Content;
global using izolabella.Notion.Objects.NotionBases;
global using Newtonsoft.Json;
using izolabella.Notion.Objects.Databases;
using izolabella.Notion.Objects.Enums;
using izolabella.Notion.Objects.Util;

namespace izolabella.Notion
{
    /// <summary>
    /// A client containing information for interacting with the Notion API.
    /// </summary>
    public class NotionClient
    {
        /// <summary>
        /// Initializes an instance of the <see cref="NotionClient"/> class for interacting with the Notion API.
        /// </summary>
        /// <param name="IntegrationType">The integration's type.</param>
        /// <param name="Secret">The integration's secret.</param>
        /// <param name="Client">The <see cref="HttpClient"/> this instance will use.</param>
        public NotionClient(IntegrationType IntegrationType, string Secret, HttpClient? Client)
        {
            this.IntegrationType = IntegrationType;
            this.Secret = Secret;
            this.Client = Client ?? new HttpClient();
            this.Client.DefaultRequestHeaders.Add("Authorization", this.Secret);
            this.Client.DefaultRequestHeaders.Add("Notion-Version", "2022-02-22");
        }

        /// <summary>
        /// Gets the type of integration this instance represents.
        /// </summary>
        public IntegrationType IntegrationType { get; }

        /// <summary>
        /// Gets the integration's secret.
        /// </summary>
        public string Secret { get; }

        /// <summary>
        /// The underlying <see cref="HttpClient"/> this instance uses for making requests.
        /// </summary>
        public HttpClient Client { get; }

        internal static async Task<string> MakeRequestAsync(NotionClient Client, HttpMethod Method, Uri Url, object? Args)
        {
            string Json = JsonConvert.SerializeObject(Args);
            HttpRequestMessage ReqMessage = new(Method, Url)
            {
                Content = Method != HttpMethod.Get ? new StringContent(Json, System.Text.Encoding.UTF8, "application/json") : null,
            };
            HttpResponseMessage? HttpRequest = await Client.Client.SendAsync(ReqMessage);
            string Content = await (HttpRequest?.Content.ReadAsStringAsync() ?? Task.FromResult(""));
            return HttpRequest != null && HttpRequest.IsSuccessStatusCode
                ? Content
                : throw new HttpRequestException(inner: null, message: Content, statusCode: HttpRequest?.StatusCode);
        }

        internal static Task<T?> GetResourceAsync<T>(NotionClient Client, string Content) where T : NotionObject
        {
            T? S = JsonConvert.DeserializeObject<T>(Content);
            if (S != null)
            {
                S.MadeWith = Client;
            }
            return Task.FromResult(S);
        }

        internal static Task<T?> GetResourcesAsync<T>(NotionClient Client, string Content) where T : IEnumerable<NotionObject>
        {
            T? S = JsonConvert.DeserializeObject<T>(Content);
            if (S != null)
            {
                foreach (NotionObject O in S)
                {
                    O.MadeWith = Client;
                }
            }
            return Task.FromResult(S);
        }

        public async Task<DatabaseObject<TProperties>?> GetDatabase<TProperties>(string DatabaseId)
        {
            return await GetResourceAsync<DatabaseObject<TProperties>>(this, await MakeRequestAsync(this, HttpMethod.Get, Urls.GetDatabaseUrl(DatabaseId), null));
        }
    }
}