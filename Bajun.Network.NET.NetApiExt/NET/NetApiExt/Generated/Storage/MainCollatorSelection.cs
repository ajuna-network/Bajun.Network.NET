//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Bajun.Network.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class CollatorSelectionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public CollatorSelectionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Invulnerables"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Candidates"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "LastAuthoredBlock"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "DesiredCandidates"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "CandidacyBond"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
        }
        
        /// <summary>
        /// >> InvulnerablesParams
        ///  The invulnerable, fixed collators.
        /// </summary>
        public static string InvulnerablesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Invulnerables", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InvulnerablesDefault
        /// Default value as hex string
        /// </summary>
        public static string InvulnerablesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        public async Task<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21> Invulnerables(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.InvulnerablesParams();
            var result = await _client.GetStorageAsync<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CandidatesParams
        ///  The (community, limited) collation candidates.
        /// </summary>
        public static string CandidatesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Candidates", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CandidatesDefault
        /// Default value as hex string
        /// </summary>
        public static string CandidatesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        public async Task<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22> Candidates(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.CandidatesParams();
            var result = await _client.GetStorageAsync<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LastAuthoredBlockParams
        ///  Last block authored by collator.
        /// </summary>
        public static string LastAuthoredBlockParams(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("CollatorSelection", "LastAuthoredBlock", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LastAuthoredBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string LastAuthoredBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> LastAuthoredBlock(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.LastAuthoredBlockParams(key);
            var result = await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> DesiredCandidatesParams
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public static string DesiredCandidatesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "DesiredCandidates", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DesiredCandidatesDefault
        /// Default value as hex string
        /// </summary>
        public static string DesiredCandidatesDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> DesiredCandidates(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.DesiredCandidatesParams();
            var result = await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CandidacyBondParams
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public static string CandidacyBondParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "CandidacyBond", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CandidacyBondDefault
        /// Default value as hex string
        /// </summary>
        public static string CandidacyBondDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> CandidacyBond(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.CandidacyBondParams();
            var result = await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
    }
    
    public sealed class CollatorSelectionCalls
    {
        
        /// <summary>
        /// >> set_invulnerables
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetInvulnerables(Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(21, "CollatorSelection", 0, "set_invulnerables", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_desired_candidates
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetDesiredCandidates(Ajuna.NetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(max.Encode());
            return new Method(21, "CollatorSelection", 1, "set_desired_candidates", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_candidacy_bond
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCandidacyBond(Ajuna.NetApi.Model.Types.Primitive.U128 bond)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(bond.Encode());
            return new Method(21, "CollatorSelection", 2, "set_candidacy_bond", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> register_as_candidate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterAsCandidate()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(21, "CollatorSelection", 3, "register_as_candidate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> leave_intent
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method LeaveIntent()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(21, "CollatorSelection", 4, "leave_intent", byteArray.ToArray());
        }
    }
    
    public sealed class CollatorSelectionConstants
    {
    }
    
    public enum CollatorSelectionErrors
    {
        
        /// <summary>
        /// >> TooManyCandidates
        /// Too many candidates
        /// </summary>
        TooManyCandidates,
        
        /// <summary>
        /// >> TooFewCandidates
        /// Too few candidates
        /// </summary>
        TooFewCandidates,
        
        /// <summary>
        /// >> Unknown
        /// Unknown error
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> Permission
        /// Permission issue
        /// </summary>
        Permission,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate
        /// </summary>
        AlreadyCandidate,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate
        /// </summary>
        NotCandidate,
        
        /// <summary>
        /// >> TooManyInvulnerables
        /// Too many invulnerables
        /// </summary>
        TooManyInvulnerables,
        
        /// <summary>
        /// >> AlreadyInvulnerable
        /// User is already an Invulnerable
        /// </summary>
        AlreadyInvulnerable,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// Account has no associated validator ID
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> ValidatorNotRegistered
        /// Validator ID is not yet registered
        /// </summary>
        ValidatorNotRegistered,
    }
}
