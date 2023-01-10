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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface IBalancesControllerClient
   {
      Task<U128> GetTotalIssuance();
      Task<bool> SubscribeTotalIssuance();
      Task<AccountData> GetAccount(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAccount(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<WeakBoundedVecT2> GetLocks(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeLocks(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT14> GetReserves(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeReserves(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
   }
}
