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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class CollatorSelectionControllerMockupClient : MockupBaseClient, ICollatorSelectionControllerMockupClient
   {
      private HttpClient _httpClient;
      public CollatorSelectionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetInvulnerables(BoundedVecT21 value)
      {
         return await SendMockupRequestAsync(_httpClient, "CollatorSelection/Invulnerables", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.InvulnerablesParams());
      }
      public async Task<bool> SetCandidates(BoundedVecT22 value)
      {
         return await SendMockupRequestAsync(_httpClient, "CollatorSelection/Candidates", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.CandidatesParams());
      }
      public async Task<bool> SetLastAuthoredBlock(U32 value, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "CollatorSelection/LastAuthoredBlock", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.LastAuthoredBlockParams(key));
      }
      public async Task<bool> SetDesiredCandidates(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "CollatorSelection/DesiredCandidates", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.DesiredCandidatesParams());
      }
      public async Task<bool> SetCandidacyBond(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "CollatorSelection/CandidacyBond", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.CandidacyBondParams());
      }
   }
}
