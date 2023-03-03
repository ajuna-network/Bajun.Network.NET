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
    /// >> 422 - Composite[pallet_ajuna_awesome_avatars.types.account.Stats]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Stats : BaseType
    {
        
        /// <summary>
        /// >> mint
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats _mint;
        
        /// <summary>
        /// >> forge
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats _forge;
        
        /// <summary>
        /// >> trade
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.TradeStats _trade;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats Mint
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
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats Forge
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
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.TradeStats Trade
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
        
        public override string TypeName()
        {
            return "Stats";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mint.Encode());
            result.AddRange(Forge.Encode());
            result.AddRange(Trade.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mint = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats();
            Mint.Decode(byteArray, ref p);
            Forge = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.PlayStats();
            Forge.Decode(byteArray, ref p);
            Trade = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.TradeStats();
            Trade.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
