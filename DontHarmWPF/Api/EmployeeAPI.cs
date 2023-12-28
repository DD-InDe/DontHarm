using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DontHarmWPF.Models;

namespace DontHarmWPF.Api;

public class EmployeeAPI : ApiBase
{
    public async Task<List<Employee>> GetEmployee()
    {
        var url = BaseUrl + $"Employee";
        var client = HttpClient;
        var res = await client.GetAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Employee>>(json, _options)!;
    }
}