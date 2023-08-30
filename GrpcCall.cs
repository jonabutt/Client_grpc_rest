using Grpc.Net.Client;
using static Client_Console_Grpc_Rest_Testing.GetData;

namespace Client_Console_Grpc_Rest_Testing
{
    public class GrpcCall
    {

        public async Task GetGrpc(int counter)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7154");
            GetDataClient client = new GetData.GetDataClient(channel);
            for (int i = 0; i < counter; i++)
            {
                await client.GetAsync(new GetRequest());
            }
        }

        public async Task GetGrpcComplex(int counter)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7154");
            GetDataClient client = new GetData.GetDataClient(channel);
            for (int i = 0; i < counter; i++)
            {
                await client.GetAsync(new GetRequest());
            }
        }



        public async Task GetGrpc2(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                await Get();
            }
        }
        public async Task Get()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7154");
            GetDataClient client = new GetData.GetDataClient(channel);

            await client.GetAsync(new GetRequest());

        }
    }
}

