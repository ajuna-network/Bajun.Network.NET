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
    /// AwesomeAvatarsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AwesomeAvatarsController : ControllerBase
    {
        
        private IAwesomeAvatarsStorage _awesomeAvatarsStorage;
        
        /// <summary>
        /// AwesomeAvatarsController constructor.
        /// </summary>
        public AwesomeAvatarsController(IAwesomeAvatarsStorage awesomeAvatarsStorage)
        {
            _awesomeAvatarsStorage = awesomeAvatarsStorage;
        }
        
        /// <summary>
        /// >> Organizer
        /// </summary>
        [HttpGet("Organizer")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "OrganizerParams")]
        public IActionResult GetOrganizer()
        {
            return this.Ok(_awesomeAvatarsStorage.GetOrganizer());
        }
        
        /// <summary>
        /// >> Treasurer
        /// </summary>
        [HttpGet("Treasurer")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "TreasurerParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetTreasurer(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTreasurer(key));
        }
        
        /// <summary>
        /// >> CurrentSeasonId
        ///  Contains the identifier of the current season.
        /// </summary>
        [HttpGet("CurrentSeasonId")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U16), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "CurrentSeasonIdParams")]
        public IActionResult GetCurrentSeasonId()
        {
            return this.Ok(_awesomeAvatarsStorage.GetCurrentSeasonId());
        }
        
        /// <summary>
        /// >> CurrentSeasonStatus
        /// </summary>
        [HttpGet("CurrentSeasonStatus")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "CurrentSeasonStatusParams")]
        public IActionResult GetCurrentSeasonStatus()
        {
            return this.Ok(_awesomeAvatarsStorage.GetCurrentSeasonStatus());
        }
        
        /// <summary>
        /// >> Seasons
        ///  Storage for the seasons.
        /// </summary>
        [HttpGet("Seasons")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "SeasonsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetSeasons(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasons(key));
        }
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        [HttpGet("Treasury")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "TreasuryParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetTreasury(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTreasury(key));
        }
        
        /// <summary>
        /// >> GlobalConfigs
        /// </summary>
        [HttpGet("GlobalConfigs")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "GlobalConfigsParams")]
        public IActionResult GetGlobalConfigs()
        {
            return this.Ok(_awesomeAvatarsStorage.GetGlobalConfigs());
        }
        
        /// <summary>
        /// >> Avatars
        /// </summary>
        [HttpGet("Avatars")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar>), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "AvatarsParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetAvatars(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetAvatars(key));
        }
        
        /// <summary>
        /// >> Owners
        /// </summary>
        [HttpGet("Owners")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT31), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "OwnersParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetOwners(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetOwners(key));
        }
        
        /// <summary>
        /// >> LockedAvatars
        /// </summary>
        [HttpGet("LockedAvatars")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "LockedAvatarsParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetLockedAvatars(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetLockedAvatars(key));
        }
        
        /// <summary>
        /// >> Accounts
        /// </summary>
        [HttpGet("Accounts")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "AccountsParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetAccounts(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetAccounts(key));
        }
        
        /// <summary>
        /// >> SeasonStats
        /// </summary>
        [HttpGet("SeasonStats")]
        [ProducesResponseType(typeof(Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "SeasonStatsParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetSeasonStats(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetSeasonStats(key));
        }
        
        /// <summary>
        /// >> Trade
        /// </summary>
        [HttpGet("Trade")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Bajun.Network.NET.NetApiExt.Generated.Storage.AwesomeAvatarsStorage), "TradeParams", typeof(Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetTrade(string key)
        {
            return this.Ok(_awesomeAvatarsStorage.GetTrade(key));
        }
    }
}
