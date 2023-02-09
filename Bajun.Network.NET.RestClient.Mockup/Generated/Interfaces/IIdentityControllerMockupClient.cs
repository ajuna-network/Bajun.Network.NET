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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IIdentityControllerMockupClient
   {
      Task<bool> SetIdentityOf(Registration value, AccountId32 key);
      Task<bool> SetSuperOf(BaseTuple<AccountId32, EnumData> value, AccountId32 key);
      Task<bool> SetSubsOf(BaseTuple<U128, BoundedVecT11> value, AccountId32 key);
      Task<bool> SetRegistrars(BoundedVecT12 value);
   }
}
