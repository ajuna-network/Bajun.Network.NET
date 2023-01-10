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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface IAwesomeAvatarsControllerMockupClient
   {
      Task<bool> SetOrganizer(AccountId32 value);
      Task<bool> SetCurrentSeasonId(U16 value);
      Task<bool> SetIsSeasonActive(Bool value);
      Task<bool> SetSeasons(Season value, U16 key);
      Task<bool> SetGlobalConfigs(GlobalConfig value);
      Task<bool> SetAvatars(BaseTuple<AccountId32, Avatar> value, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetOwners(BoundedVecT6 value, AccountId32 key);
      Task<bool> SetLastMintedBlockNumbers(U32 value, AccountId32 key);
      Task<bool> SetFreeMints(U16 value, AccountId32 key);
      Task<bool> SetTrade(U128 value, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
   }
}