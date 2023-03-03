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
    
    
    public enum Error
    {
        
        TooManyCandidates = 0,
        
        TooFewCandidates = 1,
        
        Unknown = 2,
        
        Permission = 3,
        
        AlreadyCandidate = 4,
        
        NotCandidate = 5,
        
        TooManyInvulnerables = 6,
        
        AlreadyInvulnerable = 7,
        
        NoAssociatedValidatorId = 8,
        
        ValidatorNotRegistered = 9,
    }
    
    /// <summary>
    /// >> 373 - Variant[pallet_collator_selection.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
