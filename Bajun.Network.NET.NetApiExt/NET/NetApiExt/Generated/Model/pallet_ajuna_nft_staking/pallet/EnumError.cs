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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_staking.pallet
{
    
    
    public enum Error
    {
        
        OrganizerNotSet = 0,
        
        PalletLocked = 1,
        
        TreasuryLacksFunds = 2,
        
        AccountLacksFunds = 3,
        
        ContractConditionsNotFulfilled = 4,
        
        InvalidContractReward = 5,
        
        StakedAssetNotOwned = 6,
        
        ContractRewardNotOwned = 7,
        
        ContractNotOwned = 8,
        
        ContractTakenByOther = 9,
        
        ContractAlreadyTaken = 10,
        
        ContractStillActive = 11,
        
        ContractNotFound = 12,
    }
    
    /// <summary>
    /// >> 458 - Variant[pallet_ajuna_nft_staking.pallet.Error]
    /// Error for the treasury pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
