//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    public enum Event
    {
        
        NewInvulnerables = 0,
        
        NewDesiredCandidates = 1,
        
        NewCandidacyBond = 2,
        
        CandidateAdded = 3,
        
        CandidateRemoved = 4,
    }
    
    /// <summary>
    /// >> 57 - Variant[pallet_collator_selection.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
