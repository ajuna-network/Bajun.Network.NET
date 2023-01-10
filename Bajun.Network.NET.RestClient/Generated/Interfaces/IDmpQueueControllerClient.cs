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
   using Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IDmpQueueControllerClient
   {
      Task<ConfigData> GetConfiguration();
      Task<bool> SubscribeConfiguration();
      Task<PageIndexData> GetPageIndex();
      Task<bool> SubscribePageIndex();
      Task<BaseVec<BaseTuple<U32, BaseVec<U8>>>> GetPages(U32 key);
      Task<bool> SubscribePages(U32 key);
      Task<BaseTuple<U32, BaseVec<U8>>> GetOverweight(U64 key);
      Task<bool> SubscribeOverweight(U64 key);
   }
}
