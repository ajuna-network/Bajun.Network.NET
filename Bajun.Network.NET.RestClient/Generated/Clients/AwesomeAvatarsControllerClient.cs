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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class AwesomeAvatarsControllerClient : BaseClient, IAwesomeAvatarsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AwesomeAvatarsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountId32> GetOrganizer()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "awesomeavatars/organizer");
      }
      public async Task<bool> SubscribeOrganizer()
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Organizer");
      }
      public async Task<AccountId32> GetTreasurer(U16 key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "awesomeavatars/treasurer", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TreasurerParams(key));
      }
      public async Task<bool> SubscribeTreasurer(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Treasurer", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TreasurerParams(key));
      }
      public async Task<U16> GetCurrentSeasonId()
      {
         return await SendRequestAsync<U16>(_httpClient, "awesomeavatars/currentseasonid");
      }
      public async Task<bool> SubscribeCurrentSeasonId()
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.CurrentSeasonId");
      }
      public async Task<SeasonStatus> GetCurrentSeasonStatus()
      {
         return await SendRequestAsync<SeasonStatus>(_httpClient, "awesomeavatars/currentseasonstatus");
      }
      public async Task<bool> SubscribeCurrentSeasonStatus()
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.CurrentSeasonStatus");
      }
      public async Task<Season> GetSeasons(U16 key)
      {
         return await SendRequestAsync<Season>(_httpClient, "awesomeavatars/seasons", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.SeasonsParams(key));
      }
      public async Task<bool> SubscribeSeasons(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Seasons", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.SeasonsParams(key));
      }
      public async Task<U128> GetTreasury(U16 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "awesomeavatars/treasury", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TreasuryParams(key));
      }
      public async Task<bool> SubscribeTreasury(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Treasury", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TreasuryParams(key));
      }
      public async Task<GlobalConfig> GetGlobalConfigs()
      {
         return await SendRequestAsync<GlobalConfig>(_httpClient, "awesomeavatars/globalconfigs");
      }
      public async Task<bool> SubscribeGlobalConfigs()
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.GlobalConfigs");
      }
      public async Task<BaseTuple<AccountId32, Avatar>> GetAvatars(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, Avatar>>(_httpClient, "awesomeavatars/avatars", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.AvatarsParams(key));
      }
      public async Task<bool> SubscribeAvatars(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Avatars", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.AvatarsParams(key));
      }
      public async Task<BoundedVecT31> GetOwners(AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT31>(_httpClient, "awesomeavatars/owners", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.OwnersParams(key));
      }
      public async Task<bool> SubscribeOwners(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Owners", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.OwnersParams(key));
      }
      public async Task<U128> GetLockedAvatars(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "awesomeavatars/lockedavatars", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.LockedAvatarsParams(key));
      }
      public async Task<bool> SubscribeLockedAvatars(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.LockedAvatars", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.LockedAvatarsParams(key));
      }
      public async Task<AccountInfo> GetAccounts(AccountId32 key)
      {
         return await SendRequestAsync<AccountInfo>(_httpClient, "awesomeavatars/accounts", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.AccountsParams(key));
      }
      public async Task<bool> SubscribeAccounts(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Accounts", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.AccountsParams(key));
      }
      public async Task<SeasonInfo> GetSeasonStats(BaseTuple<U16, AccountId32> key)
      {
         return await SendRequestAsync<SeasonInfo>(_httpClient, "awesomeavatars/seasonstats", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.SeasonStatsParams(key));
      }
      public async Task<bool> SubscribeSeasonStats(BaseTuple<U16, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.SeasonStats", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.SeasonStatsParams(key));
      }
      public async Task<U128> GetTrade(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "awesomeavatars/trade", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TradeParams(key));
      }
      public async Task<bool> SubscribeTrade(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("AwesomeAvatars.Trade", Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage.TradeParams(key));
      }
   }
}
