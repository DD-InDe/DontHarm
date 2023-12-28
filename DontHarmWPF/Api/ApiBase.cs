using System;
using System.Net.Http;
using System.Text.Json;

namespace DontHarmWPF.Api;

public class ApiBase
{
    protected string BaseUrl = "http://localhost:5227/";
    protected HttpClient HttpClient => new HttpClient();
    protected JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
}