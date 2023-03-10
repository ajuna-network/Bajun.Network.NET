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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue
{
    
    
    /// <summary>
    /// >> 399 - Composite[cumulus_pallet_dmp_queue.ConfigData]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ConfigData : BaseType
    {
        
        /// <summary>
        /// >> max_individual
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _maxIndividual;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight MaxIndividual
        {
            get
            {
                return this._maxIndividual;
            }
            set
            {
                this._maxIndividual = value;
            }
        }
        
        public override string TypeName()
        {
            return "ConfigData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxIndividual.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxIndividual = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            MaxIndividual.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
