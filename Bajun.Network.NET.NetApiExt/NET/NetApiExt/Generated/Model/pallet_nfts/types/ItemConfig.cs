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
    /// >> 303 - Composite[pallet_nfts.types.ItemConfig]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ItemConfig : BaseType
    {
        
        /// <summary>
        /// >> settings
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2 _settings;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2 Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                this._settings = value;
            }
        }
        
        public override string TypeName()
        {
            return "ItemConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Settings.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Settings = new Bajun.Network.NET.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2();
            Settings.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
