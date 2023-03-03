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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public class BalancesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestTotalIssuance()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();


         Assert.IsTrue(await rpcClient.SubscribeTotalIssuance());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetTotalIssuance(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetTotalIssuance();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestInactiveIssuance()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();


         Assert.IsTrue(await rpcClient.SubscribeInactiveIssuance());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetInactiveIssuance(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetInactiveIssuance();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData GetTestValue4()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData();
         result.Free = this.GetTestValueU128();
         result.Reserved = this.GetTestValueU128();
         result.MiscFrozen = this.GetTestValueU128();
         result.FeeFrozen = this.GetTestValueU128();
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
      [Test()]
      public async System.Threading.Tasks.Task TestAccount()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData mockupValue = this.GetTestValue4();
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue5();

         Assert.IsTrue(await rpcClient.SubscribeAccount(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAccount(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData rpcResult = await rpcClient.GetAccount(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 GetTestValue7()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.BalanceLock>();
         result.Value.Create(new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.BalanceLock[] {
                  this.GetTestValue8()});
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.BalanceLock GetTestValue8()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.BalanceLock result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.BalanceLock();
         result.Id = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr8U8();
         result.Id.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         result.Amount = this.GetTestValueU128();
         result.Reasons = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.EnumReasons();
         result.Reasons.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.Reasons>());
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue9()
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
      [Test()]
      public async System.Threading.Tasks.Task TestLocks()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 mockupValue = this.GetTestValue7();
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue9();

         Assert.IsTrue(await rpcClient.SubscribeLocks(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLocks(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 rpcResult = await rpcClient.GetLocks(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 GetTestValue11()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.ReserveData>();
         result.Value.Create(new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.ReserveData[] {
                  this.GetTestValue12()});
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.ReserveData GetTestValue12()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.ReserveData result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.ReserveData();
         result.Id = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr8U8();
         result.Id.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         result.Amount = this.GetTestValueU128();
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue13()
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
      [Test()]
      public async System.Threading.Tasks.Task TestReserves()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 mockupValue = this.GetTestValue11();
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue13();

         Assert.IsTrue(await rpcClient.SubscribeReserves(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReserves(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 rpcResult = await rpcClient.GetReserves(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
