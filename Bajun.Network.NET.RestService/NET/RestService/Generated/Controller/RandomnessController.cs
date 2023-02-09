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
    /// RandomnessController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class RandomnessController : ControllerBase
    {
        
        private IRandomnessStorage _randomnessStorage;
        
        /// <summary>
        /// RandomnessController constructor.
        /// </summary>
        public RandomnessController(IRandomnessStorage randomnessStorage)
        {
            _randomnessStorage = randomnessStorage;
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        [HttpGet("RandomMaterial")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT27), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.RandomnessStorage), "RandomMaterialParams")]
        public IActionResult GetRandomMaterial()
        {
            return this.Ok(_randomnessStorage.GetRandomMaterial());
        }
    }
}
