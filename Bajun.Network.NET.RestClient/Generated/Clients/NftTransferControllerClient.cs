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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_transfer.pallet;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class NftTransferControllerClient : BaseClient, INftTransferControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public NftTransferControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountId32> GetOrganizer()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "nfttransfer/organizer");
      }
      public async Task<bool> SubscribeOrganizer()
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.Organizer");
      }
      public async Task<EnumPalletLockedState> GetLockedState()
      {
         return await SendRequestAsync<EnumPalletLockedState>(_httpClient, "nfttransfer/lockedstate");
      }
      public async Task<bool> SubscribeLockedState()
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.LockedState");
      }
      public async Task<U128> GetNextItemId(U32 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "nfttransfer/nextitemid", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.NextItemIdParams(key));
      }
      public async Task<bool> SubscribeNextItemId(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.NextItemId", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.NextItemIdParams(key));
      }
      public async Task<EnumNftStatus> GetLockItemStatus(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U128> key)
      {
         return await SendRequestAsync<EnumNftStatus>(_httpClient, "nfttransfer/lockitemstatus", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.LockItemStatusParams(key));
      }
      public async Task<bool> SubscribeLockItemStatus(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.LockItemStatus", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.LockItemStatusParams(key));
      }
      public async Task<AccountId32> GetHoldingAccount()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "nfttransfer/holdingaccount");
      }
      public async Task<bool> SubscribeHoldingAccount()
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.HoldingAccount");
      }
      public async Task<AccountId32> GetNftClaimants(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U128> key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "nfttransfer/nftclaimants", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.NftClaimantsParams(key));
      }
      public async Task<bool> SubscribeNftClaimants(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.NftClaimants", Bajun.Network.NET.NetApiExt.Generated.Storage.NftTransferStorage.NftClaimantsParams(key));
      }
   }
}
