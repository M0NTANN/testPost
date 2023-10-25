using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;

class Program
{
    static void Main(string[] args) {

        var res = gettt().Result;
        Console.WriteLine(res);
    }

    static async Task<string> gettt()
    {
        var handler = new HttpClientHandler();
        handler.UseCookies = true;

        var httpclient = new HttpClient(handler);


        var req = new HttpRequestMessage(new HttpMethod("POST"), "https://api.unisender.com/ru/api/importContacts?format=json&api_key=66kgsfb3ubbzt59sek93pntf3dntoonmzucwfayy&field_names[0]=email&field_names[1]=Name&data[0][0]=3@example.com&data[0][1]=Anna3");


        var resp = await httpclient.SendAsync(req);

        return resp.StatusCode.ToString();

    }
		
}
