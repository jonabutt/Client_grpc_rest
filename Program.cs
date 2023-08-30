// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Client_Console_Grpc_Rest_Testing;


//await new GrpcCall().GetGrpc(10);
//await new RestCall().GetRestComplexLoop(1);
var summary = BenchmarkRunner.Run<BenchMarkApiCalls>();

Console.WriteLine(summary);
Console.ReadLine();