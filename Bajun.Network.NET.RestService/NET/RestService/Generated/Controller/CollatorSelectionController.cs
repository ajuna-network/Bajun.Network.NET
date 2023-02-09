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
    /// CollatorSelectionController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CollatorSelectionController : ControllerBase
    {
        
        private ICollatorSelectionStorage _collatorSelectionStorage;
        
        /// <summary>
        /// CollatorSelectionController constructor.
        /// </summary>
        public CollatorSelectionController(ICollatorSelectionStorage collatorSelectionStorage)
        {
            _collatorSelectionStorage = collatorSelectionStorage;
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        [HttpGet("Invulnerables")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage), "InvulnerablesParams")]
        public IActionResult GetInvulnerables()
        {
            return this.Ok(_collatorSelectionStorage.GetInvulnerables());
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        [HttpGet("Candidates")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage), "CandidatesParams")]
        public IActionResult GetCandidates()
        {
            return this.Ok(_collatorSelectionStorage.GetCandidates());
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        [HttpGet("LastAuthoredBlock")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage), "LastAuthoredBlockParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetLastAuthoredBlock(string key)
        {
            return this.Ok(_collatorSelectionStorage.GetLastAuthoredBlock(key));
        }
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        [HttpGet("DesiredCandidates")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage), "DesiredCandidatesParams")]
        public IActionResult GetDesiredCandidates()
        {
            return this.Ok(_collatorSelectionStorage.GetDesiredCandidates());
        }
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        [HttpGet("CandidacyBond")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage), "CandidacyBondParams")]
        public IActionResult GetCandidacyBond()
        {
            return this.Ok(_collatorSelectionStorage.GetCandidacyBond());
        }
    }
}
