using OpenDataWrapper.Extensions;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataWrapper.Domains.Mobility
{
    public class MobilityService : ServiceBase
    {
        public override string BaseUrl { get => "https://mobility.api.opendatahub.bz.it/v2/"; }

        public async Task<ResponseBase<T>> Get<T>(string representationType, string[] stationType, int offset = 0, int limit = 200)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(
                $"{BaseUrl}/{representationType}/{string.Join(",", stationType)}?offset={offset}&limit={limit}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ResponseBase<T>>();
            }

            return null;
        }
    }
}
