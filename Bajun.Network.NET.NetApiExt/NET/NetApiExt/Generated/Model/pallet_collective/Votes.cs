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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_collective
{
    
    
    /// <summary>
    /// >> 387 - Composite[pallet_collective.Votes]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Votes : BaseType
    {
        
        /// <summary>
        /// >> index
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _index;
        
        /// <summary>
        /// >> threshold
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _threshold;
        
        /// <summary>
        /// >> ayes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _ayes;
        
        /// <summary>
        /// >> nays
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _nays;
        
        /// <summary>
        /// >> end
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _end;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Threshold
        {
            get
            {
                return this._threshold;
            }
            set
            {
                this._threshold = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Ayes
        {
            get
            {
                return this._ayes;
            }
            set
            {
                this._ayes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Nays
        {
            get
            {
                return this._nays;
            }
            set
            {
                this._nays = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        public override string TypeName()
        {
            return "Votes";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Index.Encode());
            result.AddRange(Threshold.Encode());
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            result.AddRange(End.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Index = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Index.Decode(byteArray, ref p);
            Threshold = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Threshold.Decode(byteArray, ref p);
            Ayes = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Ayes.Decode(byteArray, ref p);
            Nays = new Ajuna.NetApi.Model.Types.Base.BaseVec<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Nays.Decode(byteArray, ref p);
            End = new Ajuna.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
