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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_btree_set
{
    
    
    /// <summary>
    /// >> 450 - Composite[sp_core.bounded.bounded_btree_set.BoundedBTreeSetT2]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedBTreeSetT2 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Types.Base.BTreeSetT3 _value;
        
        public Bajun.Network.NET.NetApiExt.Generated.Types.Base.BTreeSetT3 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedBTreeSetT2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Bajun.Network.NET.NetApiExt.Generated.Types.Base.BTreeSetT3();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}