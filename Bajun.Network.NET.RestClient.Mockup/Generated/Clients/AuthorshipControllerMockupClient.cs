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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuthorshipControllerMockupClient : MockupBaseClient, IAuthorshipControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuthorshipControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetUncles(BoundedVecT20 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Authorship/Uncles", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AuthorshipStorage.UnclesParams());
      }
      public async Task<bool> SetAuthor(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Authorship/Author", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AuthorshipStorage.AuthorParams());
      }
      public async Task<bool> SetDidSetUncles(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "Authorship/DidSetUncles", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AuthorshipStorage.DidSetUnclesParams());
      }
   }
}
