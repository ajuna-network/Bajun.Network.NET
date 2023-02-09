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
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Bajun.Network.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAwesomeAvatarsStorage interface definition.
    /// </summary>
    public interface IAwesomeAvatarsStorage : IStorage
    {
        
        /// <summary>
        /// >> Organizer
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetOrganizer();
        
        /// <summary>
        /// >> Treasurer
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTreasurer();
        
        /// <summary>
        /// >> CurrentSeasonId
        ///  Contains the identifier of the current season.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U16 GetCurrentSeasonId();
        
        /// <summary>
        /// >> CurrentSeasonStatus
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus GetCurrentSeasonStatus();
        
        /// <summary>
        /// >> Seasons
        ///  Storage for the seasons.
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season GetSeasons(string key);
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetTreasury(string key);
        
        /// <summary>
        /// >> GlobalConfigs
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig GetGlobalConfigs();
        
        /// <summary>
        /// >> Avatars
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar> GetAvatars(string key);
        
        /// <summary>
        /// >> Owners
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28 GetOwners(string key);
        
        /// <summary>
        /// >> Accounts
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo GetAccounts(string key);
        
        /// <summary>
        /// >> SeasonStats
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo GetSeasonStats(string key);
        
        /// <summary>
        /// >> Trade
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetTrade(string key);
    }
    
    /// <summary>
    /// AwesomeAvatarsStorage class definition.
    /// </summary>
    public sealed class AwesomeAvatarsStorage : IAwesomeAvatarsStorage
    {
        
        /// <summary>
        /// _organizerTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _organizerTypedStorage;
        
        /// <summary>
        /// _treasurerTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _treasurerTypedStorage;
        
        /// <summary>
        /// _currentSeasonIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U16> _currentSeasonIdTypedStorage;
        
        /// <summary>
        /// _currentSeasonStatusTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus> _currentSeasonStatusTypedStorage;
        
        /// <summary>
        /// _seasonsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season> _seasonsTypedStorage;
        
        /// <summary>
        /// _treasuryTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _treasuryTypedStorage;
        
        /// <summary>
        /// _globalConfigsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig> _globalConfigsTypedStorage;
        
        /// <summary>
        /// _avatarsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar>> _avatarsTypedStorage;
        
        /// <summary>
        /// _ownersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28> _ownersTypedStorage;
        
        /// <summary>
        /// _accountsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo> _accountsTypedStorage;
        
        /// <summary>
        /// _seasonStatsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo> _seasonStatsTypedStorage;
        
        /// <summary>
        /// _tradeTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _tradeTypedStorage;
        
        /// <summary>
        /// AwesomeAvatarsStorage constructor.
        /// </summary>
        public AwesomeAvatarsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.OrganizerTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("AwesomeAvatars.Organizer", storageDataProvider, storageChangeDelegates);
            this.TreasurerTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("AwesomeAvatars.Treasurer", storageDataProvider, storageChangeDelegates);
            this.CurrentSeasonIdTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U16>("AwesomeAvatars.CurrentSeasonId", storageDataProvider, storageChangeDelegates);
            this.CurrentSeasonStatusTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus>("AwesomeAvatars.CurrentSeasonStatus", storageDataProvider, storageChangeDelegates);
            this.SeasonsTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season>("AwesomeAvatars.Seasons", storageDataProvider, storageChangeDelegates);
            this.TreasuryTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("AwesomeAvatars.Treasury", storageDataProvider, storageChangeDelegates);
            this.GlobalConfigsTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig>("AwesomeAvatars.GlobalConfigs", storageDataProvider, storageChangeDelegates);
            this.AvatarsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar>>("AwesomeAvatars.Avatars", storageDataProvider, storageChangeDelegates);
            this.OwnersTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28>("AwesomeAvatars.Owners", storageDataProvider, storageChangeDelegates);
            this.AccountsTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo>("AwesomeAvatars.Accounts", storageDataProvider, storageChangeDelegates);
            this.SeasonStatsTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo>("AwesomeAvatars.SeasonStats", storageDataProvider, storageChangeDelegates);
            this.TradeTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("AwesomeAvatars.Trade", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _organizerTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> OrganizerTypedStorage
        {
            get
            {
                return _organizerTypedStorage;
            }
            set
            {
                _organizerTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _treasurerTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> TreasurerTypedStorage
        {
            get
            {
                return _treasurerTypedStorage;
            }
            set
            {
                _treasurerTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentSeasonIdTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U16> CurrentSeasonIdTypedStorage
        {
            get
            {
                return _currentSeasonIdTypedStorage;
            }
            set
            {
                _currentSeasonIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentSeasonStatusTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus> CurrentSeasonStatusTypedStorage
        {
            get
            {
                return _currentSeasonStatusTypedStorage;
            }
            set
            {
                _currentSeasonStatusTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _seasonsTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season> SeasonsTypedStorage
        {
            get
            {
                return _seasonsTypedStorage;
            }
            set
            {
                _seasonsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _treasuryTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> TreasuryTypedStorage
        {
            get
            {
                return _treasuryTypedStorage;
            }
            set
            {
                _treasuryTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _globalConfigsTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig> GlobalConfigsTypedStorage
        {
            get
            {
                return _globalConfigsTypedStorage;
            }
            set
            {
                _globalConfigsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _avatarsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar>> AvatarsTypedStorage
        {
            get
            {
                return _avatarsTypedStorage;
            }
            set
            {
                _avatarsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownersTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28> OwnersTypedStorage
        {
            get
            {
                return _ownersTypedStorage;
            }
            set
            {
                _ownersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountsTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo> AccountsTypedStorage
        {
            get
            {
                return _accountsTypedStorage;
            }
            set
            {
                _accountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _seasonStatsTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo> SeasonStatsTypedStorage
        {
            get
            {
                return _seasonStatsTypedStorage;
            }
            set
            {
                _seasonStatsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tradeTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> TradeTypedStorage
        {
            get
            {
                return _tradeTypedStorage;
            }
            set
            {
                _tradeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await OrganizerTypedStorage.InitializeAsync("AwesomeAvatars", "Organizer");
            await TreasurerTypedStorage.InitializeAsync("AwesomeAvatars", "Treasurer");
            await CurrentSeasonIdTypedStorage.InitializeAsync("AwesomeAvatars", "CurrentSeasonId");
            await CurrentSeasonStatusTypedStorage.InitializeAsync("AwesomeAvatars", "CurrentSeasonStatus");
            await SeasonsTypedStorage.InitializeAsync("AwesomeAvatars", "Seasons");
            await TreasuryTypedStorage.InitializeAsync("AwesomeAvatars", "Treasury");
            await GlobalConfigsTypedStorage.InitializeAsync("AwesomeAvatars", "GlobalConfigs");
            await AvatarsTypedStorage.InitializeAsync("AwesomeAvatars", "Avatars");
            await OwnersTypedStorage.InitializeAsync("AwesomeAvatars", "Owners");
            await AccountsTypedStorage.InitializeAsync("AwesomeAvatars", "Accounts");
            await SeasonStatsTypedStorage.InitializeAsync("AwesomeAvatars", "SeasonStats");
            await TradeTypedStorage.InitializeAsync("AwesomeAvatars", "Trade");
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Organizer
        /// </summary>
        [StorageChange("AwesomeAvatars", "Organizer")]
        public void OnUpdateOrganizer(string data)
        {
            OrganizerTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Organizer
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetOrganizer()
        {
            return OrganizerTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Treasurer
        /// </summary>
        [StorageChange("AwesomeAvatars", "Treasurer")]
        public void OnUpdateTreasurer(string data)
        {
            TreasurerTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Treasurer
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTreasurer()
        {
            return TreasurerTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.CurrentSeasonId
        /// </summary>
        [StorageChange("AwesomeAvatars", "CurrentSeasonId")]
        public void OnUpdateCurrentSeasonId(string data)
        {
            CurrentSeasonIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSeasonId
        ///  Contains the identifier of the current season.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U16 GetCurrentSeasonId()
        {
            return CurrentSeasonIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.CurrentSeasonStatus
        /// </summary>
        [StorageChange("AwesomeAvatars", "CurrentSeasonStatus")]
        public void OnUpdateCurrentSeasonStatus(string data)
        {
            CurrentSeasonStatusTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSeasonStatus
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonStatus GetCurrentSeasonStatus()
        {
            return CurrentSeasonStatusTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Seasons
        /// </summary>
        [StorageChange("AwesomeAvatars", "Seasons")]
        public void OnUpdateSeasons(string key, string data)
        {
            SeasonsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Seasons
        ///  Storage for the seasons.
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season GetSeasons(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SeasonsTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Treasury
        /// </summary>
        [StorageChange("AwesomeAvatars", "Treasury")]
        public void OnUpdateTreasury(string key, string data)
        {
            TreasuryTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetTreasury(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TreasuryTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.GlobalConfigs
        /// </summary>
        [StorageChange("AwesomeAvatars", "GlobalConfigs")]
        public void OnUpdateGlobalConfigs(string data)
        {
            GlobalConfigsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> GlobalConfigs
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig GetGlobalConfigs()
        {
            return GlobalConfigsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Avatars
        /// </summary>
        [StorageChange("AwesomeAvatars", "Avatars")]
        public void OnUpdateAvatars(string key, string data)
        {
            AvatarsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Avatars
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar> GetAvatars(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AvatarsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.Avatar> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Owners
        /// </summary>
        [StorageChange("AwesomeAvatars", "Owners")]
        public void OnUpdateOwners(string key, string data)
        {
            OwnersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Owners
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28 GetOwners(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnersTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT28 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Accounts
        /// </summary>
        [StorageChange("AwesomeAvatars", "Accounts")]
        public void OnUpdateAccounts(string key, string data)
        {
            AccountsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Accounts
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo GetAccounts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountsTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.AccountInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.SeasonStats
        /// </summary>
        [StorageChange("AwesomeAvatars", "SeasonStats")]
        public void OnUpdateSeasonStats(string key, string data)
        {
            SeasonStatsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SeasonStats
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo GetSeasonStats(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SeasonStatsTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.SeasonInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.Trade
        /// </summary>
        [StorageChange("AwesomeAvatars", "Trade")]
        public void OnUpdateTrade(string key, string data)
        {
            TradeTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Trade
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetTrade(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TradeTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
