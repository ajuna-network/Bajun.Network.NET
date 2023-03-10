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
    /// ICollatorSelectionStorage interface definition.
    /// </summary>
    public interface ICollatorSelectionStorage : IStorage
    {
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 GetInvulnerables();
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25 GetCandidates();
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetLastAuthoredBlock(string key);
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetDesiredCandidates();
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetCandidacyBond();
    }
    
    /// <summary>
    /// CollatorSelectionStorage class definition.
    /// </summary>
    public sealed class CollatorSelectionStorage : ICollatorSelectionStorage
    {
        
        /// <summary>
        /// _invulnerablesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24> _invulnerablesTypedStorage;
        
        /// <summary>
        /// _candidatesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25> _candidatesTypedStorage;
        
        /// <summary>
        /// _lastAuthoredBlockTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _lastAuthoredBlockTypedStorage;
        
        /// <summary>
        /// _desiredCandidatesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _desiredCandidatesTypedStorage;
        
        /// <summary>
        /// _candidacyBondTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _candidacyBondTypedStorage;
        
        /// <summary>
        /// CollatorSelectionStorage constructor.
        /// </summary>
        public CollatorSelectionStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.InvulnerablesTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24>("CollatorSelection.Invulnerables", storageDataProvider, storageChangeDelegates);
            this.CandidatesTypedStorage = new TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25>("CollatorSelection.Candidates", storageDataProvider, storageChangeDelegates);
            this.LastAuthoredBlockTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("CollatorSelection.LastAuthoredBlock", storageDataProvider, storageChangeDelegates);
            this.DesiredCandidatesTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("CollatorSelection.DesiredCandidates", storageDataProvider, storageChangeDelegates);
            this.CandidacyBondTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("CollatorSelection.CandidacyBond", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _invulnerablesTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24> InvulnerablesTypedStorage
        {
            get
            {
                return _invulnerablesTypedStorage;
            }
            set
            {
                _invulnerablesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _candidatesTypedStorage property
        /// </summary>
        public TypedStorage<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25> CandidatesTypedStorage
        {
            get
            {
                return _candidatesTypedStorage;
            }
            set
            {
                _candidatesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastAuthoredBlockTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> LastAuthoredBlockTypedStorage
        {
            get
            {
                return _lastAuthoredBlockTypedStorage;
            }
            set
            {
                _lastAuthoredBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _desiredCandidatesTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> DesiredCandidatesTypedStorage
        {
            get
            {
                return _desiredCandidatesTypedStorage;
            }
            set
            {
                _desiredCandidatesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _candidacyBondTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> CandidacyBondTypedStorage
        {
            get
            {
                return _candidacyBondTypedStorage;
            }
            set
            {
                _candidacyBondTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await InvulnerablesTypedStorage.InitializeAsync("CollatorSelection", "Invulnerables");
            await CandidatesTypedStorage.InitializeAsync("CollatorSelection", "Candidates");
            await LastAuthoredBlockTypedStorage.InitializeAsync("CollatorSelection", "LastAuthoredBlock");
            await DesiredCandidatesTypedStorage.InitializeAsync("CollatorSelection", "DesiredCandidates");
            await CandidacyBondTypedStorage.InitializeAsync("CollatorSelection", "CandidacyBond");
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.Invulnerables
        /// </summary>
        [StorageChange("CollatorSelection", "Invulnerables")]
        public void OnUpdateInvulnerables(string data)
        {
            InvulnerablesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 GetInvulnerables()
        {
            return InvulnerablesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.Candidates
        /// </summary>
        [StorageChange("CollatorSelection", "Candidates")]
        public void OnUpdateCandidates(string data)
        {
            CandidatesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25 GetCandidates()
        {
            return CandidatesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.LastAuthoredBlock
        /// </summary>
        [StorageChange("CollatorSelection", "LastAuthoredBlock")]
        public void OnUpdateLastAuthoredBlock(string key, string data)
        {
            LastAuthoredBlockTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetLastAuthoredBlock(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LastAuthoredBlockTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.DesiredCandidates
        /// </summary>
        [StorageChange("CollatorSelection", "DesiredCandidates")]
        public void OnUpdateDesiredCandidates(string data)
        {
            DesiredCandidatesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetDesiredCandidates()
        {
            return DesiredCandidatesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.CandidacyBond
        /// </summary>
        [StorageChange("CollatorSelection", "CandidacyBond")]
        public void OnUpdateCandidacyBond(string data)
        {
            CandidacyBondTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetCandidacyBond()
        {
            return CandidacyBondTypedStorage.Get();
        }
    }
}
