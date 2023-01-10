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
        /// >> CurrentSeasonId
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U16 GetCurrentSeasonId();
        
        /// <summary>
        /// >> IsSeasonActive
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetIsSeasonActive();
        
        /// <summary>
        /// >> Seasons
        ///  Storage for the seasons.
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season GetSeasons(string key);
        
        /// <summary>
        /// >> GlobalConfigs
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig GetGlobalConfigs();
        
        /// <summary>
        /// >> Avatars
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar> GetAvatars(string key);
        
        /// <summary>
        /// >> Owners
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6 GetOwners(string key);
        
        /// <summary>
        /// >> LastMintedBlockNumbers
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetLastMintedBlockNumbers(string key);
        
        /// <summary>
        /// >> FreeMints
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U16 GetFreeMints(string key);
        
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
        /// _currentSeasonIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U16> _currentSeasonIdTypedStorage;
        
        /// <summary>
        /// _isSeasonActiveTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _isSeasonActiveTypedStorage;
        
        /// <summary>
        /// _seasonsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season> _seasonsTypedStorage;
        
        /// <summary>
        /// _globalConfigsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig> _globalConfigsTypedStorage;
        
        /// <summary>
        /// _avatarsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar>> _avatarsTypedStorage;
        
        /// <summary>
        /// _ownersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6> _ownersTypedStorage;
        
        /// <summary>
        /// _lastMintedBlockNumbersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _lastMintedBlockNumbersTypedStorage;
        
        /// <summary>
        /// _freeMintsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U16> _freeMintsTypedStorage;
        
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
            this.CurrentSeasonIdTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U16>("AwesomeAvatars.CurrentSeasonId", storageDataProvider, storageChangeDelegates);
            this.IsSeasonActiveTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("AwesomeAvatars.IsSeasonActive", storageDataProvider, storageChangeDelegates);
            this.SeasonsTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season>("AwesomeAvatars.Seasons", storageDataProvider, storageChangeDelegates);
            this.GlobalConfigsTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig>("AwesomeAvatars.GlobalConfigs", storageDataProvider, storageChangeDelegates);
            this.AvatarsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar>>("AwesomeAvatars.Avatars", storageDataProvider, storageChangeDelegates);
            this.OwnersTypedStorage = new TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6>("AwesomeAvatars.Owners", storageDataProvider, storageChangeDelegates);
            this.LastMintedBlockNumbersTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("AwesomeAvatars.LastMintedBlockNumbers", storageDataProvider, storageChangeDelegates);
            this.FreeMintsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U16>("AwesomeAvatars.FreeMints", storageDataProvider, storageChangeDelegates);
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
        /// _isSeasonActiveTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> IsSeasonActiveTypedStorage
        {
            get
            {
                return _isSeasonActiveTypedStorage;
            }
            set
            {
                _isSeasonActiveTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _seasonsTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season> SeasonsTypedStorage
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
        /// _globalConfigsTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig> GlobalConfigsTypedStorage
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
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar>> AvatarsTypedStorage
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
        public TypedMapStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6> OwnersTypedStorage
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
        /// _lastMintedBlockNumbersTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> LastMintedBlockNumbersTypedStorage
        {
            get
            {
                return _lastMintedBlockNumbersTypedStorage;
            }
            set
            {
                _lastMintedBlockNumbersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _freeMintsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U16> FreeMintsTypedStorage
        {
            get
            {
                return _freeMintsTypedStorage;
            }
            set
            {
                _freeMintsTypedStorage = value;
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
            await CurrentSeasonIdTypedStorage.InitializeAsync("AwesomeAvatars", "CurrentSeasonId");
            await IsSeasonActiveTypedStorage.InitializeAsync("AwesomeAvatars", "IsSeasonActive");
            await SeasonsTypedStorage.InitializeAsync("AwesomeAvatars", "Seasons");
            await GlobalConfigsTypedStorage.InitializeAsync("AwesomeAvatars", "GlobalConfigs");
            await AvatarsTypedStorage.InitializeAsync("AwesomeAvatars", "Avatars");
            await OwnersTypedStorage.InitializeAsync("AwesomeAvatars", "Owners");
            await LastMintedBlockNumbersTypedStorage.InitializeAsync("AwesomeAvatars", "LastMintedBlockNumbers");
            await FreeMintsTypedStorage.InitializeAsync("AwesomeAvatars", "FreeMints");
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
        /// Implements any storage change for AwesomeAvatars.CurrentSeasonId
        /// </summary>
        [StorageChange("AwesomeAvatars", "CurrentSeasonId")]
        public void OnUpdateCurrentSeasonId(string data)
        {
            CurrentSeasonIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSeasonId
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U16 GetCurrentSeasonId()
        {
            return CurrentSeasonIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.IsSeasonActive
        /// </summary>
        [StorageChange("AwesomeAvatars", "IsSeasonActive")]
        public void OnUpdateIsSeasonActive(string data)
        {
            IsSeasonActiveTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> IsSeasonActive
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetIsSeasonActive()
        {
            return IsSeasonActiveTypedStorage.Get();
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
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season GetSeasons(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SeasonsTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Season result))
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
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.GlobalConfig GetGlobalConfigs()
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
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar> GetAvatars(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AvatarsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.Avatar> result))
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
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6 GetOwners(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnersTypedStorage.Dictionary.TryGetValue(key, out Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.LastMintedBlockNumbers
        /// </summary>
        [StorageChange("AwesomeAvatars", "LastMintedBlockNumbers")]
        public void OnUpdateLastMintedBlockNumbers(string key, string data)
        {
            LastMintedBlockNumbersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> LastMintedBlockNumbers
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetLastMintedBlockNumbers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LastMintedBlockNumbersTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AwesomeAvatars.FreeMints
        /// </summary>
        [StorageChange("AwesomeAvatars", "FreeMints")]
        public void OnUpdateFreeMints(string key, string data)
        {
            FreeMintsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FreeMints
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U16 GetFreeMints(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FreeMintsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U16 result))
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