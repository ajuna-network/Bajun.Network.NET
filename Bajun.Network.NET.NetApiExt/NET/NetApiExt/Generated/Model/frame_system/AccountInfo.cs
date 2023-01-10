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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.frame_system
{
    
    
    /// <summary>
    /// >> 3 - Composite[frame_system.AccountInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class AccountInfo : BaseType
    {
        
        /// <summary>
        /// >> nonce
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _nonce;
        
        /// <summary>
        /// >> consumers
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _consumers;
        
        /// <summary>
        /// >> providers
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _providers;
        
        /// <summary>
        /// >> sufficients
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _sufficients;
        
        /// <summary>
        /// >> data
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData _data;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Nonce
        {
            get
            {
                return this._nonce;
            }
            set
            {
                this._nonce = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Consumers
        {
            get
            {
                return this._consumers;
            }
            set
            {
                this._consumers = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Providers
        {
            get
            {
                return this._providers;
            }
            set
            {
                this._providers = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Sufficients
        {
            get
            {
                return this._sufficients;
            }
            set
            {
                this._sufficients = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public override string TypeName()
        {
            return "AccountInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Nonce.Encode());
            result.AddRange(Consumers.Encode());
            result.AddRange(Providers.Encode());
            result.AddRange(Sufficients.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Nonce = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Nonce.Decode(byteArray, ref p);
            Consumers = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Consumers.Decode(byteArray, ref p);
            Providers = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Providers.Decode(byteArray, ref p);
            Sufficients = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Sufficients.Decode(byteArray, ref p);
            Data = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_balances.AccountData();
            Data.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
