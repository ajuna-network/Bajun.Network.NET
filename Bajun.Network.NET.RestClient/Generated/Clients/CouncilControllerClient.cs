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
   using Bajun.Network.NET.NetApiExt.Generated.Model.bajun_runtime;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class CouncilControllerClient : BaseClient, ICouncilControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CouncilControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT21> GetProposals()
      {
         return await SendRequestAsync<BoundedVecT21>(_httpClient, "council/proposals");
      }
      public async Task<bool> SubscribeProposals()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Proposals");
      }
      public async Task<EnumCall> GetProposalOf(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumCall>(_httpClient, "council/proposalof", Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<bool> SubscribeProposalOf(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalOf", Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<Votes> GetVoting(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<Votes>(_httpClient, "council/voting", Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.Voting", Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilStorage.VotingParams(key));
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "council/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalCount");
      }
      public async Task<BaseVec<AccountId32>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "council/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "council/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Prime");
      }
   }
}