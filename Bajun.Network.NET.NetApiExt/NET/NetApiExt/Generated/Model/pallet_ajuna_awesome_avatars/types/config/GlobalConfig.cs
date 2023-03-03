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
    /// >> 110 - Composite[pallet_ajuna_awesome_avatars.types.config.GlobalConfig]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class GlobalConfig : BaseType
    {
        
        /// <summary>
        /// >> mint
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.MintConfig _mint;
        
        /// <summary>
        /// >> forge
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.ForgeConfig _forge;
        
        /// <summary>
        /// >> transfer
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TransferConfig _transfer;
        
        /// <summary>
        /// >> trade
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TradeConfig _trade;
        
        /// <summary>
        /// >> account
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.AccountConfig _account;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.MintConfig Mint
        {
            get
            {
                return this._mint;
            }
            set
            {
                this._mint = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.ForgeConfig Forge
        {
            get
            {
                return this._forge;
            }
            set
            {
                this._forge = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TransferConfig Transfer
        {
            get
            {
                return this._transfer;
            }
            set
            {
                this._transfer = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TradeConfig Trade
        {
            get
            {
                return this._trade;
            }
            set
            {
                this._trade = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.AccountConfig Account
        {
            get
            {
                return this._account;
            }
            set
            {
                this._account = value;
            }
        }
        
        public override string TypeName()
        {
            return "GlobalConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mint.Encode());
            result.AddRange(Forge.Encode());
            result.AddRange(Transfer.Encode());
            result.AddRange(Trade.Encode());
            result.AddRange(Account.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mint = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.MintConfig();
            Mint.Decode(byteArray, ref p);
            Forge = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.ForgeConfig();
            Forge.Decode(byteArray, ref p);
            Transfer = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TransferConfig();
            Transfer.Decode(byteArray, ref p);
            Trade = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.TradeConfig();
            Trade.Decode(byteArray, ref p);
            Account = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.AccountConfig();
            Account.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
