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
    /// VestingController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class VestingController : ControllerBase
    {
        
        private IVestingStorage _vestingStorage;
        
        /// <summary>
        /// VestingController constructor.
        /// </summary>
        public VestingController(IVestingStorage vestingStorage)
        {
            _vestingStorage = vestingStorage;
        }
        
        /// <summary>
        /// >> VestingSchedules
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        [HttpGet("VestingSchedules")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT15), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.VestingStorage), "VestingSchedulesParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetVestingSchedules(string key)
        {
            return this.Ok(_vestingStorage.GetVestingSchedules(key));
        }
    }
}