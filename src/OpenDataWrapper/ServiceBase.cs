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
                    $"{BaseUrl}/" +
                    $"{request.RepresentationType}/" +
                    $"{string.Join(",", request.StationTypes)}/" +
                    $"{string.Join(",", request.DataTypes ?? new string[] { "*" })}/" +
                    $"{ (request.From != null ? request.From?.ToString("yyyy-MM-ddTHH:mm:ss.SSSZ/") : "") }" +
                    $"{ (request.To != null ? request.To?.ToString("yyyy-MM-ddTHH:mm:ss.SSSZ/") : "") }" +
                    $"{ (request.From == null && request.To == null? "latest/" : "") }" +
                    $"?offset={request.Offset}" +
                    $"&limit={request.Limit}" +
                    $"{ (request.Select != null ? "&select=" + request.Select : "") }" +
                    $"{ (request.Where != null ? "&where=" + request.Where.ToString() : "") }");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ResponseBase<T>>();
                }

                return null;
            }
        }
    }
}
