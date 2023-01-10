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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types
{
    
    
    /// <summary>
    /// >> 114 - Composite[pallet_ajuna_awesome_avatars.types.ForgeConfig]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ForgeConfig : BaseType
    {
        
        /// <summary>
        /// >> open
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _open;
        
        /// <summary>
        /// >> min_sacrifices
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _minSacrifices;
        
        /// <summary>
        /// >> max_sacrifices
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxSacrifices;
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool Open
        {
            get
            {
                return this._open;
            }
            set
            {
                this._open = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MinSacrifices
        {
            get
            {
                return this._minSacrifices;
            }
            set
            {
                this._minSacrifices = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MaxSacrifices
        {
            get
            {
                return this._maxSacrifices;
            }
            set
            {
                this._maxSacrifices = value;
            }
        }
        
        public override string TypeName()
        {
            return "ForgeConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Open.Encode());
            result.AddRange(MinSacrifices.Encode());
            result.AddRange(MaxSacrifices.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Open = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Open.Decode(byteArray, ref p);
            MinSacrifices = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MinSacrifices.Decode(byteArray, ref p);
            MaxSacrifices = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxSacrifices.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
