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
    /// >> 114 - Composite[pallet_ajuna_awesome_avatars.types.config.TransferConfig]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class TransferConfig : BaseType
    {
        
        /// <summary>
        /// >> open
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _open;
        
        /// <summary>
        /// >> free_mint_transfer_fee
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U16 _freeMintTransferFee;
        
        /// <summary>
        /// >> min_free_mint_transfer
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U16 _minFreeMintTransfer;
        
        /// <summary>
        /// >> avatar_transfer_fee
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _avatarTransferFee;
        
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
        
        public Ajuna.NetApi.Model.Types.Primitive.U16 FreeMintTransferFee
        {
            get
            {
                return this._freeMintTransferFee;
            }
            set
            {
                this._freeMintTransferFee = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U16 MinFreeMintTransfer
        {
            get
            {
                return this._minFreeMintTransfer;
            }
            set
            {
                this._minFreeMintTransfer = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 AvatarTransferFee
        {
            get
            {
                return this._avatarTransferFee;
            }
            set
            {
                this._avatarTransferFee = value;
            }
        }
        
        public override string TypeName()
        {
            return "TransferConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Open.Encode());
            result.AddRange(FreeMintTransferFee.Encode());
            result.AddRange(MinFreeMintTransfer.Encode());
            result.AddRange(AvatarTransferFee.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Open = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Open.Decode(byteArray, ref p);
            FreeMintTransferFee = new Ajuna.NetApi.Model.Types.Primitive.U16();
            FreeMintTransferFee.Decode(byteArray, ref p);
            MinFreeMintTransfer = new Ajuna.NetApi.Model.Types.Primitive.U16();
            MinFreeMintTransfer.Decode(byteArray, ref p);
            AvatarTransferFee = new Ajuna.NetApi.Model.Types.Primitive.U128();
            AvatarTransferFee.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
