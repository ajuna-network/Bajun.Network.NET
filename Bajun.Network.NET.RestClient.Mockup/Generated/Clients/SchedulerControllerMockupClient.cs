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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SchedulerControllerMockupClient : MockupBaseClient, ISchedulerControllerMockupClient
   {
      private HttpClient _httpClient;
      public SchedulerControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAgenda(BaseVec<BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_scheduler.ScheduledV3>> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Scheduler/Agenda", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<bool> SetLookup(BaseTuple<U32, U32> value, BaseVec<U8> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Scheduler/Lookup", value.Encode(), Bajun.Network.NET.NetApiExt.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
   }
}
