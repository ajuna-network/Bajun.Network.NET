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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AwesomeAvatarsControllerMockupClient : MockupBaseClient, IAwesomeAvatarsControllerMockupClient
   {
      private HttpClient _httpClient;
      public AwesomeAvatarsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetOrganizer(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/Organizer", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.OrganizerParams());
      }
      public async Task<bool> SetCurrentSeasonId(U16 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/CurrentSeasonId", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.CurrentSeasonIdParams());
      }
      public async Task<bool> SetIsSeasonActive(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/IsSeasonActive", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.IsSeasonActiveParams());
      }
      public async Task<bool> SetSeasons(Season value, U16 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/Seasons", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.SeasonsParams(key));
      }
      public async Task<bool> SetGlobalConfigs(GlobalConfig value)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/GlobalConfigs", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.GlobalConfigsParams());
      }
      public async Task<bool> SetAvatars(BaseTuple<AccountId32, Avatar> value, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/Avatars", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.AvatarsParams(key));
      }
      public async Task<bool> SetOwners(BoundedVecT6 value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/Owners", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.OwnersParams(key));
      }
      public async Task<bool> SetLastMintedBlockNumbers(U32 value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/LastMintedBlockNumbers", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.LastMintedBlockNumbersParams(key));
      }
      public async Task<bool> SetFreeMints(U16 value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/FreeMints", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.FreeMintsParams(key));
      }
      public async Task<bool> SetTrade(U128 value, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AwesomeAvatars/Trade", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TradeParams(key));
      }
   }
}