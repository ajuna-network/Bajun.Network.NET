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
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public interface IAuraControllerMockupClient
   {
      Task<bool> SetAuthorities(BoundedVecT19 value);
      Task<bool> SetCurrentSlot(Slot value);
   }
}