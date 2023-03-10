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
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class VestingControllerMockupClient : MockupBaseClient, IVestingControllerMockupClient
   {
      private HttpClient _httpClient;
      public VestingControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetVestingSchedules(BoundedVecT22 value, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Vesting/VestingSchedules", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.VestingStorage.VestingSchedulesParams(key));
      }
   }
}
