using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WarframeApp.Utilities
{
    public static class HttpClientHelper
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<string> GetSingleItemRequest(string apiUrl, CancellationToken cancellationToken)
        {
            var result = "";
            var response = await Client.GetAsync(apiUrl, cancellationToken).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsStringAsync().ContinueWith(x =>
                {
                    result = x.Result;
                }, cancellationToken);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                response.Content?.Dispose();
                throw new HttpRequestException($"{response.StatusCode}:{content}");
            }
            return result;
        }
    }
}
