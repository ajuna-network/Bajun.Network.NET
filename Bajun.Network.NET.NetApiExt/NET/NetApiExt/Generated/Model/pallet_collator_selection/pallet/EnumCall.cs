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
    
    
    public enum Call
    {
        
        set_invulnerables = 0,
        
        set_desired_candidates = 1,
        
        set_candidacy_bond = 2,
        
        register_as_candidate = 3,
        
        leave_intent = 4,
    }
    
    /// <summary>
    /// >> 250 - Variant[pallet_collator_selection.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, BaseVoid, BaseVoid>
    {
    }
}
