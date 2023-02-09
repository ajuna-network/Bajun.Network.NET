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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IIdentityControllerClient
   {
      Task<Registration> GetIdentityOf(AccountId32 key);
      Task<bool> SubscribeIdentityOf(AccountId32 key);
      Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key);
      Task<bool> SubscribeSuperOf(AccountId32 key);
      Task<BaseTuple<U128, BoundedVecT11>> GetSubsOf(AccountId32 key);
      Task<bool> SubscribeSubsOf(AccountId32 key);
      Task<BoundedVecT12> GetRegistrars();
      Task<bool> SubscribeRegistrars();
   }
}
