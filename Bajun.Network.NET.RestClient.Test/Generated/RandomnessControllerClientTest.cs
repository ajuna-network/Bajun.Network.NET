//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Clients;
   using Bajun.Network.NET.RestClient.Generated.Clients;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public class RandomnessControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT7 GetTestValue2()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT7 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT7();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256>();
         result.Value.Create(new Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256[] {
                  this.GetTestValue3()});
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue3()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRandomMaterial()
      {
         // Construct new Mockup client to test with.
         RandomnessControllerMockupClient mockupClient = new RandomnessControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RandomnessControllerClient rpcClient = new RandomnessControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT7 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeRandomMaterial());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRandomMaterial(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT7 rpcResult = await rpcClient.GetRandomMaterial();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
