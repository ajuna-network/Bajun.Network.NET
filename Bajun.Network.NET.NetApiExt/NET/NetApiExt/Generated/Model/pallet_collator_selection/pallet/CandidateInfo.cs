//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> 371 - Composite[pallet_collator_selection.pallet.CandidateInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateInfo : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "CandidateInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
