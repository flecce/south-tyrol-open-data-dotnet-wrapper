using OpenDataWrapper.Extensions;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataWrapper
{
    public abstract class ServiceBase
    {
        public abstract string BaseUrl { get; }

        public virtual async Task<ResponseBase<T>> Get<T>(RequestBase request)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(
                    $"{BaseUrl}/{request.RepresentationType}/{string.Join(",", request.StationTypes)}?offset={request.Offset}&limit={request.Limit}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ResponseBase<T>>();
                }

                return null;
            }
        }
    }
}
