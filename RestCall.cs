using Client_Console_Grpc_Rest_Testing.RestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Client_Console_Grpc_Rest_Testing
{
    internal class RestCall
    {

        public async Task GetRestLoop(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                await GetRest();
            }
        }

        public async Task<string> GetRest()
        {

            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            return await ProcessRepositoriesAsync(client);
        }

        private async Task<string> ProcessRepositoriesAsync(HttpClient client)
        {
            return (await client.GetFromJsonAsync<GetResponseRest>(
                "https://localhost:7197/api/Values/Get")).Message;

        }

        public async Task GetRestComplexLoop(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                await GetRestComplex();
            }
        }

        public async Task<List<ComplexResponse>> GetRestComplex()
        {

            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            return await ProcessComplexAsync(client);
        }

        private async Task<List<ComplexResponse>> ProcessComplexAsync(HttpClient client)
        {
            return (await client.GetFromJsonAsync<List<ComplexResponse>>(
                "https://localhost:7197/api/Values/GetComplex"));

        }
    }
}
