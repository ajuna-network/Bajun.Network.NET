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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 302 - Composite[pallet_nfts.types.MintWitness]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class MintWitness : BaseType
    {
        
        /// <summary>
        /// >> owner_of_item
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _ownerOfItem;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 OwnerOfItem
        {
            get
            {
                return this._ownerOfItem;
            }
            set
            {
                this._ownerOfItem = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintWitness";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(OwnerOfItem.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            OwnerOfItem = new Ajuna.NetApi.Model.Types.Primitive.U128();
            OwnerOfItem.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
