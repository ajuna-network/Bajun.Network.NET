//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_treasury;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TreasuryControllerMockupClient : MockupBaseClient, ITreasuryControllerMockupClient
   {
      private HttpClient _httpClient;
      public TreasuryControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/ProposalCount", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage.ProposalCountParams());
      }
      public async Task<bool> SetProposals(Proposal value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Proposals", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage.ProposalsParams(key));
      }
      public async Task<bool> SetApprovals(BoundedVecT20 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Approvals", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage.ApprovalsParams());
      }
   }
}
