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
    /// >> 103 - Composite[pallet_ajuna_awesome_avatars.types.season.Season]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Season : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1 _name;
        
        /// <summary>
        /// >> description
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2 _description;
        
        /// <summary>
        /// >> early_start
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _earlyStart;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _start;
        
        /// <summary>
        /// >> end
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _end;
        
        /// <summary>
        /// >> max_tier_forges
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxTierForges;
        
        /// <summary>
        /// >> max_variations
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxVariations;
        
        /// <summary>
        /// >> max_components
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxComponents;
        
        /// <summary>
        /// >> min_sacrifices
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _minSacrifices;
        
        /// <summary>
        /// >> max_sacrifices
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxSacrifices;
        
        /// <summary>
        /// >> tiers
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT3 _tiers;
        
        /// <summary>
        /// >> single_mint_probs
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 _singleMintProbs;
        
        /// <summary>
        /// >> batch_mint_probs
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 _batchMintProbs;
        
        /// <summary>
        /// >> base_prob
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _baseProb;
        
        /// <summary>
        /// >> per_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _perPeriod;
        
        /// <summary>
        /// >> periods
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U16 _periods;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1 Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2 Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 EarlyStart
        {
            get
            {
                return this._earlyStart;
            }
            set
            {
                this._earlyStart = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxTierForges
        {
            get
            {
                return this._maxTierForges;
            }
            set
            {
                this._maxTierForges = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MaxVariations
        {
            get
            {
                return this._maxVariations;
            }
            set
            {
                this._maxVariations = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MaxComponents
        {
            get
            {
                return this._maxComponents;
            }
            set
            {
                this._maxComponents = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MinSacrifices
        {
            get
            {
                return this._minSacrifices;
            }
            set
            {
                this._minSacrifices = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 MaxSacrifices
        {
            get
            {
                return this._maxSacrifices;
            }
            set
            {
                this._maxSacrifices = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT3 Tiers
        {
            get
            {
                return this._tiers;
            }
            set
            {
                this._tiers = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 SingleMintProbs
        {
            get
            {
                return this._singleMintProbs;
            }
            set
            {
                this._singleMintProbs = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 BatchMintProbs
        {
            get
            {
                return this._batchMintProbs;
            }
            set
            {
                this._batchMintProbs = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 BaseProb
        {
            get
            {
                return this._baseProb;
            }
            set
            {
                this._baseProb = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 PerPeriod
        {
            get
            {
                return this._perPeriod;
            }
            set
            {
                this._perPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U16 Periods
        {
            get
            {
                return this._periods;
            }
            set
            {
                this._periods = value;
            }
        }
        
        public override string TypeName()
        {
            return "Season";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(EarlyStart.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(End.Encode());
            result.AddRange(MaxTierForges.Encode());
            result.AddRange(MaxVariations.Encode());
            result.AddRange(MaxComponents.Encode());
            result.AddRange(MinSacrifices.Encode());
            result.AddRange(MaxSacrifices.Encode());
            result.AddRange(Tiers.Encode());
            result.AddRange(SingleMintProbs.Encode());
            result.AddRange(BatchMintProbs.Encode());
            result.AddRange(BaseProb.Encode());
            result.AddRange(PerPeriod.Encode());
            result.AddRange(Periods.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1();
            Name.Decode(byteArray, ref p);
            Description = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2();
            Description.Decode(byteArray, ref p);
            EarlyStart = new Ajuna.NetApi.Model.Types.Primitive.U32();
            EarlyStart.Decode(byteArray, ref p);
            Start = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            End = new Ajuna.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            MaxTierForges = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxTierForges.Decode(byteArray, ref p);
            MaxVariations = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxVariations.Decode(byteArray, ref p);
            MaxComponents = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxComponents.Decode(byteArray, ref p);
            MinSacrifices = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MinSacrifices.Decode(byteArray, ref p);
            MaxSacrifices = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxSacrifices.Decode(byteArray, ref p);
            Tiers = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT3();
            Tiers.Decode(byteArray, ref p);
            SingleMintProbs = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4();
            SingleMintProbs.Decode(byteArray, ref p);
            BatchMintProbs = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4();
            BatchMintProbs.Decode(byteArray, ref p);
            BaseProb = new Ajuna.NetApi.Model.Types.Primitive.U8();
            BaseProb.Decode(byteArray, ref p);
            PerPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            PerPeriod.Decode(byteArray, ref p);
            Periods = new Ajuna.NetApi.Model.Types.Primitive.U16();
            Periods.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
