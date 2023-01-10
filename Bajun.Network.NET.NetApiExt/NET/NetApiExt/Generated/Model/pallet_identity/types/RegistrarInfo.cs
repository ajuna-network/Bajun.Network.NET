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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types
{
    
    
    /// <summary>
    /// >> 289 - Composite[pallet_identity.types.RegistrarInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class RegistrarInfo : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _account;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _fee;
        
        /// <summary>
        /// >> fields
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags _fields;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Account
        {
            get
            {
                return this._account;
            }
            set
            {
                this._account = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
            }
        }
        
        public override string TypeName()
        {
            return "RegistrarInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(Fields.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Account.Decode(byteArray, ref p);
            Fee = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            Fields = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags();
            Fields.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
