//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Bajun.Network.NET.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Bajun.Network.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// TreasuryController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TreasuryController : ControllerBase
    {
        
        private ITreasuryStorage _treasuryStorage;
        
        /// <summary>
        /// TreasuryController constructor.
        /// </summary>
        public TreasuryController(ITreasuryStorage treasuryStorage)
        {
            _treasuryStorage = treasuryStorage;
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        [HttpGet("ProposalCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ProposalCountParams")]
        public IActionResult GetProposalCount()
        {
            return this.Ok(_treasuryStorage.GetProposalCount());
        }
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        [HttpGet("Proposals")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ProposalsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetProposals(string key)
        {
            return this.Ok(_treasuryStorage.GetProposals(key));
        }
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        [HttpGet("Deactivated")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage), "DeactivatedParams")]
        public IActionResult GetDeactivated()
        {
            return this.Ok(_treasuryStorage.GetDeactivated());
        }
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        [HttpGet("Approvals")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT27), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ApprovalsParams")]
        public IActionResult GetApprovals()
        {
            return this.Ok(_treasuryStorage.GetApprovals());
        }
    }
}
