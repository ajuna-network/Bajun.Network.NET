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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.orml_vesting.module
{
    
    
    public enum Call
    {
        
        claim = 0,
        
        vested_transfer = 1,
        
        update_vesting_schedules = 2,
        
        claim_for = 3,
    }
    
    /// <summary>
    /// >> 244 - Variant[orml_vesting.module.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseVoid, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bajun.Network.NET.NetApiExt.Generated.Model.orml_vesting.VestingSchedule>, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.orml_vesting.VestingSchedule>>, Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>
    {
    }
}
