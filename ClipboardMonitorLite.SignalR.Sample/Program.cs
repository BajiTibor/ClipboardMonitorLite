using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SignalR.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:7071/api")
                .Build();

            var g1 = "af1631dd-52da-4990-a3a2-6de0e936995c";

            connection.On<string>(g1, (msg) =>
            {
                Console.WriteLine($"{g1} : {msg}");
            });

            await connection.StartAsync();

            var message = new Message
            {
                GroupId = "af1631dd-52da-4990-a3a2-6de0e936995c",
                ApplicationId = "976c92c1-c8f0-474b-a14f-f8a1074e4647",
                Password = "kekeke",
                Content = "RandomStuff"
            };

            var json = JsonConvert.SerializeObject(message);

            var client = new HttpClient();

            await client.PostAsync("http://localhost:7071/api/SendMessage", new StringContent(json));

            await Task.Delay(-1);
        }
    }
}
