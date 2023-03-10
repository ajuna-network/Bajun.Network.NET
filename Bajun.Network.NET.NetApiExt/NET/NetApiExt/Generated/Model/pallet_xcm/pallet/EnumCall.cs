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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_xcm.pallet
{
    
    
    public enum Call
    {
        
        send = 0,
        
        teleport_assets = 1,
        
        reserve_transfer_assets = 2,
        
        execute = 3,
        
        force_xcm_version = 4,
        
        force_default_xcm_version = 5,
        
        force_subscribe_version_notify = 6,
        
        force_unsubscribe_version_notify = 7,
        
        limited_reserve_transfer_assets = 8,
        
        limited_teleport_assets = 9,
    }
    
    /// <summary>
    /// >> 256 - Variant[pallet_xcm.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm, Ajuna.NetApi.Model.Types.Primitive.U64>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.EnumWeightLimit>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.EnumWeightLimit>>
    {
    }
}
