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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface ICouncilMembershipControllerClient
   {
      Task<BoundedVecT29> GetMembers();
      Task<bool> SubscribeMembers();
      Task<AccountId32> GetPrime();
      Task<bool> SubscribePrime();
   }
}
