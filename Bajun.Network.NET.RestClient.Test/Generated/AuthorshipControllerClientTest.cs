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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class AuthorshipControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 GetTestValue2()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.EnumUncleEntryItem>();
         result.Value.Create(new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.EnumUncleEntryItem[] {
                  this.GetTestValue3()});
         return result;
      }
      public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.EnumUncleEntryItem GetTestValue3()
      {
         Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.EnumUncleEntryItem result;
         result = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.EnumUncleEntryItem();
         result.Create(this.GetTestValueEnum<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_authorship.UncleEntryItem>(), this.GetTestValueU32());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestUncles()
      {
         // Construct new Mockup client to test with.
         AuthorshipControllerMockupClient mockupClient = new AuthorshipControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuthorshipControllerClient rpcClient = new AuthorshipControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeUncles());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetUncles(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 rpcResult = await rpcClient.GetUncles();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
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
      public async System.Threading.Tasks.Task TestAuthor()
      {
         // Construct new Mockup client to test with.
         AuthorshipControllerMockupClient mockupClient = new AuthorshipControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuthorshipControllerClient rpcClient = new AuthorshipControllerClient(_httpClient, subscriptionClient);
         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupValue = this.GetTestValue5();


         Assert.IsTrue(await rpcClient.SubscribeAuthor());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAuthor(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 rpcResult = await rpcClient.GetAuthor();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDidSetUncles()
      {
         // Construct new Mockup client to test with.
         AuthorshipControllerMockupClient mockupClient = new AuthorshipControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuthorshipControllerClient rpcClient = new AuthorshipControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.Bool mockupValue = this.GetTestValueBool();


         Assert.IsTrue(await rpcClient.SubscribeDidSetUncles());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDidSetUncles(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.Bool rpcResult = await rpcClient.GetDidSetUncles();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
