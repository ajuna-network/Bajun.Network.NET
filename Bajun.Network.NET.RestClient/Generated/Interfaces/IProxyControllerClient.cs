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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerClient
   {
      Task<BaseTuple<BoundedVecT11, U128>> GetProxies(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeProxies(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BaseTuple<BoundedVecT12, U128>> GetAnnouncements(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAnnouncements(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}