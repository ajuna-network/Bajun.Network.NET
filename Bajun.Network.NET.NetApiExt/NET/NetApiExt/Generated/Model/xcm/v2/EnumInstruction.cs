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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2
{
    
    
    public enum Instruction
    {
        
        WithdrawAsset = 0,
        
        ReserveAssetDeposited = 1,
        
        ReceiveTeleportedAsset = 2,
        
        QueryResponse = 3,
        
        TransferAsset = 4,
        
        TransferReserveAsset = 5,
        
        Transact = 6,
        
        HrmpNewChannelOpenRequest = 7,
        
        HrmpChannelAccepted = 8,
        
        HrmpChannelClosing = 9,
        
        ClearOrigin = 10,
        
        DescendOrigin = 11,
        
        ReportError = 12,
        
        DepositAsset = 13,
        
        DepositReserveAsset = 14,
        
        ExchangeAsset = 15,
        
        InitiateReserveWithdraw = 16,
        
        InitiateTeleport = 17,
        
        QueryHolding = 18,
        
        BuyExecution = 19,
        
        RefundSurplus = 20,
        
        SetErrorHandler = 21,
        
        SetAppendix = 22,
        
        ClearError = 23,
        
        ClaimAsset = 24,
        
        Trap = 25,
        
        SubscribeVersion = 26,
        
        UnsubscribeVersion = 27,
    }
    
    /// <summary>
    /// >> 272 - Variant[xcm.v2.Instruction]
    /// </summary>
    public sealed class EnumInstruction : BaseEnumExt<Instruction, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.EnumResponse, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v0.EnumOriginKind, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.double_encoded.DoubleEncodedT2>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseVoid, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.EnumJunctions, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.EnumMultiAssetFilter, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAsset, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.EnumWeightLimit>, BaseVoid, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT2, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v2.XcmT2, BaseVoid, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Bajun.Network.NET.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>>, BaseVoid>
    {
    }
}
