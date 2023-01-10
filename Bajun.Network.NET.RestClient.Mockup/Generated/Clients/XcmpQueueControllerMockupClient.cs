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
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class XcmpQueueControllerMockupClient : MockupBaseClient, IXcmpQueueControllerMockupClient
   {
      private HttpClient _httpClient;
      public XcmpQueueControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetInboundXcmpStatus(BaseVec<InboundChannelDetails> value)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/InboundXcmpStatus", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.InboundXcmpStatusParams());
      }
      public async Task<bool> SetInboundXcmpMessages(BaseVec<U8> value, BaseTuple<Id, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/InboundXcmpMessages", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.InboundXcmpMessagesParams(key));
      }
      public async Task<bool> SetOutboundXcmpStatus(BaseVec<OutboundChannelDetails> value)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/OutboundXcmpStatus", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.OutboundXcmpStatusParams());
      }
      public async Task<bool> SetOutboundXcmpMessages(BaseVec<U8> value, BaseTuple<Id, U16> key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/OutboundXcmpMessages", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.OutboundXcmpMessagesParams(key));
      }
      public async Task<bool> SetSignalMessages(BaseVec<U8> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/SignalMessages", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.SignalMessagesParams(key));
      }
      public async Task<bool> SetQueueConfig(QueueConfigData value)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/QueueConfig", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.QueueConfigParams());
      }
      public async Task<bool> SetOverweight(BaseTuple<Id, U32, BaseVec<U8>> value, U64 key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/Overweight", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.OverweightParams(key));
      }
      public async Task<bool> SetOverweightCount(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/OverweightCount", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.OverweightCountParams());
      }
      public async Task<bool> SetQueueSuspended(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "XcmpQueue/QueueSuspended", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.XcmpQueueStorage.QueueSuspendedParams());
      }
   }
}