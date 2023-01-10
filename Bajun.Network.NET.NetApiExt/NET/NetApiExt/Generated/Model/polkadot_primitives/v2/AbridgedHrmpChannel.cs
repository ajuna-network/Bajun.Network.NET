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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.polkadot_primitives.v2
{
    
    
    /// <summary>
    /// >> 147 - Composite[polkadot_primitives.v2.AbridgedHrmpChannel]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class AbridgedHrmpChannel : BaseType
    {
        
        /// <summary>
        /// >> max_capacity
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxCapacity;
        
        /// <summary>
        /// >> max_total_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxTotalSize;
        
        /// <summary>
        /// >> max_message_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxMessageSize;
        
        /// <summary>
        /// >> msg_count
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _msgCount;
        
        /// <summary>
        /// >> total_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _totalSize;
        
        /// <summary>
        /// >> mqc_head
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256> _mqcHead;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxCapacity
        {
            get
            {
                return this._maxCapacity;
            }
            set
            {
                this._maxCapacity = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxTotalSize
        {
            get
            {
                return this._maxTotalSize;
            }
            set
            {
                this._maxTotalSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxMessageSize
        {
            get
            {
                return this._maxMessageSize;
            }
            set
            {
                this._maxMessageSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MsgCount
        {
            get
            {
                return this._msgCount;
            }
            set
            {
                this._msgCount = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 TotalSize
        {
            get
            {
                return this._totalSize;
            }
            set
            {
                this._totalSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256> MqcHead
        {
            get
            {
                return this._mqcHead;
            }
            set
            {
                this._mqcHead = value;
            }
        }
        
        public override string TypeName()
        {
            return "AbridgedHrmpChannel";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCapacity.Encode());
            result.AddRange(MaxTotalSize.Encode());
            result.AddRange(MaxMessageSize.Encode());
            result.AddRange(MsgCount.Encode());
            result.AddRange(TotalSize.Encode());
            result.AddRange(MqcHead.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCapacity = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxCapacity.Decode(byteArray, ref p);
            MaxTotalSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxTotalSize.Decode(byteArray, ref p);
            MaxMessageSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxMessageSize.Decode(byteArray, ref p);
            MsgCount = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MsgCount.Decode(byteArray, ref p);
            TotalSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            TotalSize.Decode(byteArray, ref p);
            MqcHead = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.primitive_types.H256>();
            MqcHead.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
