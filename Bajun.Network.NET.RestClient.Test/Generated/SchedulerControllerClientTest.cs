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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Base;
   
   public class SchedulerControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestIncompleteSince()
      {
         // Construct new Mockup client to test with.
         SchedulerControllerMockupClient mockupClient = new SchedulerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SchedulerControllerClient rpcClient = new SchedulerControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeIncompleteSince());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetIncompleteSince(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetIncompleteSince();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15 GetTestValue3()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled>[] {
                  this.GetTestValue4()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled>();
         result.Create(this.GetTestValue5());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled GetTestValue5()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.Scheduled();
         result.MaybeId = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8>();
         result.MaybeId.Create(this.GetTestValue6());
         result.Priority = this.GetTestValueU8();
         result.Call = new Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded();
         result.Call.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.traits.preimages.Bounded>(), this.GetTestValue7());
         result.MaybePeriodic = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>();
         result.MaybePeriodic.Create(this.GetTestValue8());
         result.Origin = new Bajun.Network.NET.NetApiExt.Generated.Model.bajun_runtime.EnumOriginCaller();
         result.Origin.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.bajun_runtime.OriginCaller>(), this.GetTestValue9());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 GetTestValue6()
      {
         Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
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
      public Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue7()
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
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue8()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32(), this.GetTestValueU32());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumRawOrigin GetTestValue9()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumRawOrigin result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumRawOrigin();
         result.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.dispatch.RawOrigin>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAgenda()
      {
         // Construct new Mockup client to test with.
         SchedulerControllerMockupClient mockupClient = new SchedulerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SchedulerControllerClient rpcClient = new SchedulerControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15 mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeAgenda(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAgenda(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15 rpcResult = await rpcClient.GetAgenda(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue11()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32(), this.GetTestValueU32());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 GetTestValue12()
      {
         Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
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
      public async System.Threading.Tasks.Task TestLookup()
      {
         // Construct new Mockup client to test with.
         SchedulerControllerMockupClient mockupClient = new SchedulerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SchedulerControllerClient rpcClient = new SchedulerControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue11();
         Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 mockupKey = this.GetTestValue12();

         Assert.IsTrue(await rpcClient.SubscribeLookup(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLookup(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetLookup(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
