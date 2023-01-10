//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_trie.storage_proof;
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.relay_state_snapshot;
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_primitives_parachain_inherent;
   using Bajun.Network.NET.NetApiExt.Generated.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   using Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types;
   
   public interface IParachainSystemControllerClient
   {
      Task<BaseVec<U8>> GetPendingValidationCode();
      Task<bool> SubscribePendingValidationCode();
      Task<BaseVec<U8>> GetNewValidationCode();
      Task<bool> SubscribeNewValidationCode();
      Task<PersistedValidationData> GetValidationData();
      Task<bool> SubscribeValidationData();
      Task<Bool> GetDidSetValidationCode();
      Task<bool> SubscribeDidSetValidationCode();
      Task<U32> GetLastRelayChainBlockNumber();
      Task<bool> SubscribeLastRelayChainBlockNumber();
      Task<BaseOpt<EnumUpgradeRestriction>> GetUpgradeRestrictionSignal();
      Task<bool> SubscribeUpgradeRestrictionSignal();
      Task<StorageProof> GetRelayStateProof();
      Task<bool> SubscribeRelayStateProof();
      Task<MessagingStateSnapshot> GetRelevantMessagingState();
      Task<bool> SubscribeRelevantMessagingState();
      Task<AbridgedHostConfiguration> GetHostConfiguration();
      Task<bool> SubscribeHostConfiguration();
      Task<MessageQueueChain> GetLastDmqMqcHead();
      Task<bool> SubscribeLastDmqMqcHead();
      Task<BTreeMapT1> GetLastHrmpMqcHeads();
      Task<bool> SubscribeLastHrmpMqcHeads();
      Task<U32> GetProcessedDownwardMessages();
      Task<bool> SubscribeProcessedDownwardMessages();
      Task<U32> GetHrmpWatermark();
      Task<bool> SubscribeHrmpWatermark();
      Task<BaseVec<OutboundHrmpMessage>> GetHrmpOutboundMessages();
      Task<bool> SubscribeHrmpOutboundMessages();
      Task<BaseVec<BaseVec<U8>>> GetUpwardMessages();
      Task<bool> SubscribeUpwardMessages();
      Task<BaseVec<BaseVec<U8>>> GetPendingUpwardMessages();
      Task<bool> SubscribePendingUpwardMessages();
      Task<U32> GetAnnouncedHrmpMessagesPerCandidate();
      Task<bool> SubscribeAnnouncedHrmpMessagesPerCandidate();
      Task<U64> GetReservedXcmpWeightOverride();
      Task<bool> SubscribeReservedXcmpWeightOverride();
      Task<U64> GetReservedDmpWeightOverride();
      Task<bool> SubscribeReservedDmpWeightOverride();
      Task<H256> GetAuthorizedUpgrade();
      Task<bool> SubscribeAuthorizedUpgrade();
      Task<BaseVec<U8>> GetCustomValidationHeadData();
      Task<bool> SubscribeCustomValidationHeadData();
   }
}