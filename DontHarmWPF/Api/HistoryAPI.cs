using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DontHarmWPF.Models;

namespace DontHarmWPF.Api;

public class HistoryAPI : ApiBase
{
    public async Task<List<LoginHistory>> GetHistory()
    {
        var url = BaseUrl + $"LoginHistory";
        var client = HttpClient;
        var res = await client.GetAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        if (res.StatusCode == HttpStatusCode.OK)
        {
            return JsonSerializer.Deserialize<List<LoginHistory>>(json, _options)!;
        }
        return null;
    }
}