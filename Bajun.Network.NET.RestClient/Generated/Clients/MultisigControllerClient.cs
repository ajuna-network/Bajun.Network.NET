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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_multisig;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.frame_support.traits.misc;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class MultisigControllerClient : BaseClient, IMultisigControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public MultisigControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Multisig> GetMultisigs(BaseTuple<AccountId32, Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8> key)
      {
         return await SendRequestAsync<Multisig>(_httpClient, "multisig/multisigs", Bajun.Network.NET.NetApiExt.Generated.Storage.MultisigStorage.MultisigsParams(key));
      }
      public async Task<bool> SubscribeMultisigs(BaseTuple<AccountId32, Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8> key)
      {
         return await _subscriptionClient.SubscribeAsync("Multisig.Multisigs", Bajun.Network.NET.NetApiExt.Generated.Storage.MultisigStorage.MultisigsParams(key));
      }
      public async Task<BaseTuple<WrapperKeepOpaque, AccountId32, U128>> GetCalls(Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
      {
         return await SendRequestAsync<BaseTuple<WrapperKeepOpaque, AccountId32, U128>>(_httpClient, "multisig/calls", Bajun.Network.NET.NetApiExt.Generated.Storage.MultisigStorage.CallsParams(key));
      }
      public async Task<bool> SubscribeCalls(Bajun.Network.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
      {
         return await _subscriptionClient.SubscribeAsync("Multisig.Calls", Bajun.Network.NET.NetApiExt.Generated.Storage.MultisigStorage.CallsParams(key));
      }
   }
}
