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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.pallet
{
    
    
    public enum Call
    {
        
        mint = 0,
        
        forge = 1,
        
        transfer_free_mints = 2,
        
        set_price = 3,
        
        remove_price = 4,
        
        buy = 5,
        
        set_organizer = 6,
        
        upsert_season = 7,
        
        update_global_config = 8,
        
        issue_free_mints = 9,
    }
    
    /// <summary>
    /// >> 273 - Variant[pallet_ajuna_awesome_avatars.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.MintOption, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>>, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season>, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16>>
    {
    }
}
