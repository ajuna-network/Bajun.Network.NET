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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account
{
    
    
    /// <summary>
    /// >> 429 - Composite[pallet_ajuna_awesome_avatars.types.account.SeasonInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class SeasonInfo : BaseType
    {
        
        /// <summary>
        /// >> minted
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _minted;
        
        /// <summary>
        /// >> forged
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _forged;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Minted
        {
            get
            {
                return this._minted;
            }
            set
            {
                this._minted = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Forged
        {
            get
            {
                return this._forged;
            }
            set
            {
                this._forged = value;
            }
        }
        
        public override string TypeName()
        {
            return "SeasonInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Minted.Encode());
            result.AddRange(Forged.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Minted = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Minted.Decode(byteArray, ref p);
            Forged = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Forged.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
