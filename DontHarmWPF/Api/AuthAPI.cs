using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DontHarmWPF.Models;

namespace DontHarmWPF.Api;

public class AuthAPI : ApiBase
{
    public async Task<Employee> Auth(string login, string password)
    {
        var url = BaseUrl + $"Auth/{login},{password}";
        var client = HttpClient;
        var res = await client.GetAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        if (res.StatusCode == HttpStatusCode.OK)
        {
            return JsonSerializer.Deserialize<Employee>(json, _options)!;
        }
        return null;
    }
}