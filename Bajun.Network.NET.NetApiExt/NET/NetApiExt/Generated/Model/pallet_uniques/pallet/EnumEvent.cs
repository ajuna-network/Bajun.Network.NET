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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_uniques.pallet
{
    
    
    public enum Event
    {
        
        Created = 0,
        
        ForceCreated = 1,
        
        Destroyed = 2,
        
        Issued = 3,
        
        Transferred = 4,
        
        Burned = 5,
        
        Frozen = 6,
        
        Thawed = 7,
        
        CollectionFrozen = 8,
        
        CollectionThawed = 9,
        
        OwnerChanged = 10,
        
        TeamChanged = 11,
        
        ApprovedTransfer = 12,
        
        ApprovalCancelled = 13,
        
        ItemStatusChanged = 14,
        
        CollectionMetadataSet = 15,
        
        CollectionMetadataCleared = 16,
        
        MetadataSet = 17,
        
        MetadataCleared = 18,
        
        Redeposited = 19,
        
        AttributeSet = 20,
        
        AttributeCleared = 21,
        
        OwnershipAcceptanceChanged = 22,
        
        CollectionMaxSupplySet = 23,
        
        ItemPriceSet = 24,
        
        ItemPriceRemoved = 25,
        
        ItemBought = 26,
    }
    
    /// <summary>
    /// >> 43 - Variant[pallet_uniques.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1, Ajuna.NetApi.Model.Types.Primitive.Bool>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT3>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>
    {
    }
}