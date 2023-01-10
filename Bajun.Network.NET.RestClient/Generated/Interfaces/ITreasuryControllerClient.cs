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
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_treasury;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface ITreasuryControllerClient
   {
      Task<U32> GetProposalCount();
      Task<bool> SubscribeProposalCount();
      Task<Proposal> GetProposals(U32 key);
      Task<bool> SubscribeProposals(U32 key);
      Task<BoundedVecT20> GetApprovals();
      Task<bool> SubscribeApprovals();
   }
}
