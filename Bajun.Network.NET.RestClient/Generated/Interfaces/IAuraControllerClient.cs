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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public interface IAuraControllerClient
   {
      Task<BoundedVecT26> GetAuthorities();
      Task<bool> SubscribeAuthorities();
      Task<Slot> GetCurrentSlot();
      Task<bool> SubscribeCurrentSlot();
   }
}
