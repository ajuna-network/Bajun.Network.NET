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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public class PreimageControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus GetTestValue2()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus();
         result.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.RequestStatus>(), this.GetTestValue3());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue3()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue4(), this.GetTestValueU32());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Create(this.GetTestValue5(), this.GetTestValueU128());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue5()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
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
      public Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue6()
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
      public async System.Threading.Tasks.Task TestStatusFor()
      {
         // Construct new Mockup client to test with.
         PreimageControllerMockupClient mockupClient = new PreimageControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         PreimageControllerClient rpcClient = new PreimageControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus mockupValue = this.GetTestValue2();
         Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeStatusFor(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetStatusFor(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus rpcResult = await rpcClient.GetStatusFor(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20 GetTestValue8()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue9()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue10(), this.GetTestValueU32());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue10()
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
      public async System.Threading.Tasks.Task TestPreimageFor()
      {
         // Construct new Mockup client to test with.
         PreimageControllerMockupClient mockupClient = new PreimageControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         PreimageControllerClient rpcClient = new PreimageControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20 mockupValue = this.GetTestValue8();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32> mockupKey = this.GetTestValue9();

         Assert.IsTrue(await rpcClient.SubscribePreimageFor(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPreimageFor(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20 rpcResult = await rpcClient.GetPreimageFor(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
