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
   using Bajun.Network.NET.NetApiExt.Generated.Model.bajun_runtime;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface ICouncilControllerClient
   {
      Task<BoundedVecT28> GetProposals();
      Task<bool> SubscribeProposals();
      Task<EnumRuntimeCall> GetProposalOf(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeProposalOf(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<Votes> GetVoting(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeVoting(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<U32> GetProposalCount();
      Task<bool> SubscribeProposalCount();
      Task<BaseVec<AccountId32>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<AccountId32> GetPrime();
      Task<bool> SubscribePrime();
   }
}
