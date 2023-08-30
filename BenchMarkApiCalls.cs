using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Console_Grpc_Rest_Testing
{
    public class BenchMarkApiCalls
    {
        private readonly GrpcCall grpcCall = new GrpcCall();
        private readonly RestCall restCall = new RestCall();


        [Benchmark]
        public async Task BenchmarkRestCall100()
        {
            await restCall.GetRestLoop(100);
        }

        [Benchmark]
        public async Task BenchmarkGrpcCall100()
        {
            await grpcCall.GetGrpc(100);
        }

        [Benchmark]
        public async Task BenchmarkRestComplexCall()
        {
            await restCall.GetRestComplexLoop(1);
        }

        [Benchmark]
        public async Task BenchmarkGrpcComplexCall()
        {
            await grpcCall.GetGrpcComplex(1);
        }

    }
}
