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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season
{
    
    
    /// <summary>
    /// >> 392 - Composite[pallet_ajuna_awesome_avatars.types.season.SeasonStatus]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class SeasonStatus : BaseType
    {
        
        /// <summary>
        /// >> early
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _early;
        
        /// <summary>
        /// >> active
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _active;
        
        /// <summary>
        /// >> early_ended
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _earlyEnded;
        
        /// <summary>
        /// >> max_tier_avatars
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxTierAvatars;
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool Early
        {
            get
            {
                return this._early;
            }
            set
            {
                this._early = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool Active
        {
            get
            {
                return this._active;
            }
            set
            {
                this._active = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool EarlyEnded
        {
            get
            {
                return this._earlyEnded;
            }
            set
            {
                this._earlyEnded = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxTierAvatars
        {
            get
            {
                return this._maxTierAvatars;
            }
            set
            {
                this._maxTierAvatars = value;
            }
        }
        
        public override string TypeName()
        {
            return "SeasonStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Early.Encode());
            result.AddRange(Active.Encode());
            result.AddRange(EarlyEnded.Encode());
            result.AddRange(MaxTierAvatars.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Early = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Early.Decode(byteArray, ref p);
            Active = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Active.Decode(byteArray, ref p);
            EarlyEnded = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            EarlyEnded.Decode(byteArray, ref p);
            MaxTierAvatars = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxTierAvatars.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}