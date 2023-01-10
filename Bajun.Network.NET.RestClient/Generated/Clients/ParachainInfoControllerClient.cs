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
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class ParachainInfoControllerClient : BaseClient, IParachainInfoControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ParachainInfoControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Id> GetParachainId()
      {
         return await SendRequestAsync<Id>(_httpClient, "parachaininfo/parachainid");
      }
      public async Task<bool> SubscribeParachainId()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainInfo.ParachainId");
      }
   }
}
