//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerMockupClient
   {
      Task<bool> SetProxies(BaseTuple<BoundedVecT13, U128> value, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetAnnouncements(BaseTuple<BoundedVecT14, U128> value, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
