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
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_trie.storage_proof;
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.relay_state_snapshot;
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_primitives_parachain_inherent;
   using Bajun.Network.NET.NetApiExt.Generated.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_weights.weight_v2;
   using Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types;
   using Bajun.Network.NET.RestClient.Generated.Interfaces;
   
   public sealed class ParachainSystemControllerClient : BaseClient, IParachainSystemControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ParachainSystemControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<U8>> GetPendingValidationCode()
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "parachainsystem/pendingvalidationcode");
      }
      public async Task<bool> SubscribePendingValidationCode()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.PendingValidationCode");
      }
      public async Task<BaseVec<U8>> GetNewValidationCode()
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "parachainsystem/newvalidationcode");
      }
      public async Task<bool> SubscribeNewValidationCode()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.NewValidationCode");
      }
      public async Task<PersistedValidationData> GetValidationData()
      {
         return await SendRequestAsync<PersistedValidationData>(_httpClient, "parachainsystem/validationdata");
      }
      public async Task<bool> SubscribeValidationData()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.ValidationData");
      }
      public async Task<Bool> GetDidSetValidationCode()
      {
         return await SendRequestAsync<Bool>(_httpClient, "parachainsystem/didsetvalidationcode");
      }
      public async Task<bool> SubscribeDidSetValidationCode()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.DidSetValidationCode");
      }
      public async Task<U32> GetLastRelayChainBlockNumber()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainsystem/lastrelaychainblocknumber");
      }
      public async Task<bool> SubscribeLastRelayChainBlockNumber()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.LastRelayChainBlockNumber");
      }
      public async Task<BaseOpt<EnumUpgradeRestriction>> GetUpgradeRestrictionSignal()
      {
         return await SendRequestAsync<BaseOpt<EnumUpgradeRestriction>>(_httpClient, "parachainsystem/upgraderestrictionsignal");
      }
      public async Task<bool> SubscribeUpgradeRestrictionSignal()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.UpgradeRestrictionSignal");
      }
      public async Task<StorageProof> GetRelayStateProof()
      {
         return await SendRequestAsync<StorageProof>(_httpClient, "parachainsystem/relaystateproof");
      }
      public async Task<bool> SubscribeRelayStateProof()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.RelayStateProof");
      }
      public async Task<MessagingStateSnapshot> GetRelevantMessagingState()
      {
         return await SendRequestAsync<MessagingStateSnapshot>(_httpClient, "parachainsystem/relevantmessagingstate");
      }
      public async Task<bool> SubscribeRelevantMessagingState()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.RelevantMessagingState");
      }
      public async Task<AbridgedHostConfiguration> GetHostConfiguration()
      {
         return await SendRequestAsync<AbridgedHostConfiguration>(_httpClient, "parachainsystem/hostconfiguration");
      }
      public async Task<bool> SubscribeHostConfiguration()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.HostConfiguration");
      }
      public async Task<MessageQueueChain> GetLastDmqMqcHead()
      {
         return await SendRequestAsync<MessageQueueChain>(_httpClient, "parachainsystem/lastdmqmqchead");
      }
      public async Task<bool> SubscribeLastDmqMqcHead()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.LastDmqMqcHead");
      }
      public async Task<BTreeMapT1> GetLastHrmpMqcHeads()
      {
         return await SendRequestAsync<BTreeMapT1>(_httpClient, "parachainsystem/lasthrmpmqcheads");
      }
      public async Task<bool> SubscribeLastHrmpMqcHeads()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.LastHrmpMqcHeads");
      }
      public async Task<U32> GetProcessedDownwardMessages()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainsystem/processeddownwardmessages");
      }
      public async Task<bool> SubscribeProcessedDownwardMessages()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.ProcessedDownwardMessages");
      }
      public async Task<U32> GetHrmpWatermark()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainsystem/hrmpwatermark");
      }
      public async Task<bool> SubscribeHrmpWatermark()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.HrmpWatermark");
      }
      public async Task<BaseVec<OutboundHrmpMessage>> GetHrmpOutboundMessages()
      {
         return await SendRequestAsync<BaseVec<OutboundHrmpMessage>>(_httpClient, "parachainsystem/hrmpoutboundmessages");
      }
      public async Task<bool> SubscribeHrmpOutboundMessages()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.HrmpOutboundMessages");
      }
      public async Task<BaseVec<BaseVec<U8>>> GetUpwardMessages()
      {
         return await SendRequestAsync<BaseVec<BaseVec<U8>>>(_httpClient, "parachainsystem/upwardmessages");
      }
      public async Task<bool> SubscribeUpwardMessages()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.UpwardMessages");
      }
      public async Task<BaseVec<BaseVec<U8>>> GetPendingUpwardMessages()
      {
         return await SendRequestAsync<BaseVec<BaseVec<U8>>>(_httpClient, "parachainsystem/pendingupwardmessages");
      }
      public async Task<bool> SubscribePendingUpwardMessages()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.PendingUpwardMessages");
      }
      public async Task<U32> GetAnnouncedHrmpMessagesPerCandidate()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainsystem/announcedhrmpmessagespercandidate");
      }
      public async Task<bool> SubscribeAnnouncedHrmpMessagesPerCandidate()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.AnnouncedHrmpMessagesPerCandidate");
      }
      public async Task<Weight> GetReservedXcmpWeightOverride()
      {
         return await SendRequestAsync<Weight>(_httpClient, "parachainsystem/reservedxcmpweightoverride");
      }
      public async Task<bool> SubscribeReservedXcmpWeightOverride()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.ReservedXcmpWeightOverride");
      }
      public async Task<Weight> GetReservedDmpWeightOverride()
      {
         return await SendRequestAsync<Weight>(_httpClient, "parachainsystem/reserveddmpweightoverride");
      }
      public async Task<bool> SubscribeReservedDmpWeightOverride()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.ReservedDmpWeightOverride");
      }
      public async Task<H256> GetAuthorizedUpgrade()
      {
         return await SendRequestAsync<H256>(_httpClient, "parachainsystem/authorizedupgrade");
      }
      public async Task<bool> SubscribeAuthorizedUpgrade()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.AuthorizedUpgrade");
      }
      public async Task<BaseVec<U8>> GetCustomValidationHeadData()
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "parachainsystem/customvalidationheaddata");
      }
      public async Task<bool> SubscribeCustomValidationHeadData()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainSystem.CustomValidationHeadData");
      }
   }
}
