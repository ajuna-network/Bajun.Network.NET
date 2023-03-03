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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_staking.contracts
{
    
    
    /// <summary>
    /// >> 134 - Composite[pallet_ajuna_nft_staking.contracts.NftAddress]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class NftAddress : BaseType
    {
        
        /// <summary>
        /// >> CollectionId
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _collectionId;
        
        /// <summary>
        /// >> ItemId
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _itemId;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 CollectionId
        {
            get
            {
                return this._collectionId;
            }
            set
            {
                this._collectionId = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 ItemId
        {
            get
            {
                return this._itemId;
            }
            set
            {
                this._itemId = value;
            }
        }
        
        public override string TypeName()
        {
            return "NftAddress";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(CollectionId.Encode());
            result.AddRange(ItemId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            CollectionId = new Ajuna.NetApi.Model.Types.Primitive.U32();
            CollectionId.Decode(byteArray, ref p);
            ItemId = new Ajuna.NetApi.Model.Types.Primitive.U128();
            ItemId.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
