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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_transaction_payment;
   
   public interface ITransactionPaymentControllerClient
   {
      Task<FixedU128> GetNextFeeMultiplier();
      Task<bool> SubscribeNextFeeMultiplier();
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
   }
}
