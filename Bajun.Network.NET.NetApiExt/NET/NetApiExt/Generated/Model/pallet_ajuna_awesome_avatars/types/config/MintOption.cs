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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> 289 - Composite[pallet_ajuna_awesome_avatars.types.config.MintOption]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class MintOption : BaseType
    {
        
        /// <summary>
        /// >> mint_type
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType _mintType;
        
        /// <summary>
        /// >> count
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize _count;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType MintType
        {
            get
            {
                return this._mintType;
            }
            set
            {
                this._mintType = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintOption";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MintType.Encode());
            result.AddRange(Count.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MintType = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType();
            MintType.Decode(byteArray, ref p);
            Count = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize();
            Count.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
