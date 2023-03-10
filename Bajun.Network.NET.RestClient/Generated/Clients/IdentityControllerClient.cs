//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class IdentityControllerClient : BaseClient, IIdentityControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IdentityControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Registration> GetIdentityOf(AccountId32 key)
      {
         return await SendRequestAsync<Registration>(_httpClient, "identity/identityof", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SubscribeIdentityOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.IdentityOf", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, EnumData>>(_httpClient, "identity/superof", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SubscribeSuperOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SuperOf", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<BaseTuple<U128, BoundedVecT14>> GetSubsOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<U128, BoundedVecT14>>(_httpClient, "identity/subsof", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SubscribeSubsOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SubsOf", Bajun.Network.NET.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<BoundedVecT15> GetRegistrars()
      {
         return await SendRequestAsync<BoundedVecT15>(_httpClient, "identity/registrars");
      }
      public async Task<bool> SubscribeRegistrars()
      {
         return await _subscriptionClient.SubscribeAsync("Identity.Registrars");
      }
   }
}
