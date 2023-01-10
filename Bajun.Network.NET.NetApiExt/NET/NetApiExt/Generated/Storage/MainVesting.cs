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
    
    
    public sealed class VestingStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public VestingStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Vesting", "VestingSchedules"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT15)));
        }
        
        /// <summary>
        /// >> VestingSchedulesParams
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        public static string VestingSchedulesParams(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Vesting", "VestingSchedules", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> VestingSchedules
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        public async Task<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT15> VestingSchedules(Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = VestingStorage.VestingSchedulesParams(key);
            return await _client.GetStorageAsync<Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT15>(parameters, token);
        }
    }
    
    public sealed class VestingCalls
    {
        
        /// <summary>
        /// >> claim
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Claim()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(17, "Vesting", 0, "claim", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vested_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method VestedTransfer(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Bajun.Network.NET.NetApiExt.Generated.Model.orml_vesting.VestingSchedule schedule)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(schedule.Encode());
            return new Method(17, "Vesting", 1, "vested_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_vesting_schedules
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UpdateVestingSchedules(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.orml_vesting.VestingSchedule> vesting_schedules)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(vesting_schedules.Encode());
            return new Method(17, "Vesting", 2, "update_vesting_schedules", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_for
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClaimFor(Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            return new Method(17, "Vesting", 3, "claim_for", byteArray.ToArray());
        }
    }
    
    public enum VestingErrors
    {
        
        /// <summary>
        /// >> ZeroVestingPeriod
        /// Vesting period is zero
        /// </summary>
        ZeroVestingPeriod,
        
        /// <summary>
        /// >> ZeroVestingPeriodCount
        /// Number of vests is zero
        /// </summary>
        ZeroVestingPeriodCount,
        
        /// <summary>
        /// >> InsufficientBalanceToLock
        /// Insufficient amount of balance to lock
        /// </summary>
        InsufficientBalanceToLock,
        
        /// <summary>
        /// >> TooManyVestingSchedules
        /// This account have too many vesting schedules
        /// </summary>
        TooManyVestingSchedules,
        
        /// <summary>
        /// >> AmountLow
        /// The vested transfer amount is too low
        /// </summary>
        AmountLow,
        
        /// <summary>
        /// >> MaxVestingSchedulesExceeded
        /// Failed because the maximum vesting schedules was exceeded
        /// </summary>
        MaxVestingSchedulesExceeded,
    }
}
