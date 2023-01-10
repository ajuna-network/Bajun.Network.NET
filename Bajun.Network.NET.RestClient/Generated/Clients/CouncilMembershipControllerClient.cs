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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class CouncilMembershipControllerClient : BaseClient, ICouncilMembershipControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CouncilMembershipControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT22> GetMembers()
      {
         return await SendRequestAsync<BoundedVecT22>(_httpClient, "councilmembership/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("CouncilMembership.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "councilmembership/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("CouncilMembership.Prime");
      }
   }
}