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
    /// CouncilMembershipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CouncilMembershipController : ControllerBase
    {
        
        private ICouncilMembershipStorage _councilMembershipStorage;
        
        /// <summary>
        /// CouncilMembershipController constructor.
        /// </summary>
        public CouncilMembershipController(ICouncilMembershipStorage councilMembershipStorage)
        {
            _councilMembershipStorage = councilMembershipStorage;
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT22), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilMembershipStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_councilMembershipStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.CouncilMembershipStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_councilMembershipStorage.GetPrime());
        }
    }
}
