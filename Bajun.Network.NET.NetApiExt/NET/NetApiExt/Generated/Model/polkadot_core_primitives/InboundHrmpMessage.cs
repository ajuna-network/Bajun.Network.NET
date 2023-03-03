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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_core_primitives
{
    
    
    /// <summary>
    /// >> 178 - Composite[polkadot_core_primitives.InboundHrmpMessage]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class InboundHrmpMessage : BaseType
    {
        
        /// <summary>
        /// >> sent_at
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _sentAt;
        
        /// <summary>
        /// >> data
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> _data;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 SentAt
        {
            get
            {
                return this._sentAt;
            }
            set
            {
                this._sentAt = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> Data
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
            return "InboundHrmpMessage";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SentAt.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SentAt = new Ajuna.NetApi.Model.Types.Primitive.U32();
            SentAt.Decode(byteArray, ref p);
            Data = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
            Data.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
