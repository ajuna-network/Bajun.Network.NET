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


namespace Bajun.Network.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types
{
    
    
    /// <summary>
    /// >> 103 - Composite[pallet_ajuna_awesome_avatars.types.Season]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Season : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT1 _name;
        
        /// <summary>
        /// >> description
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT2 _description;
        
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
        /// >> max_variations
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxVariations;
        
        /// <summary>
        /// >> max_components
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _maxComponents;
        
        /// <summary>
        /// >> tiers
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT3 _tiers;
        
        /// <summary>
        /// >> p_single_mint
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 _pSingleMint;
        
        /// <summary>
        /// >> p_batch_mint
        /// </summary>
        private Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 _pBatchMint;
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT1 Name
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
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT2 Description
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
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT3 Tiers
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
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 PSingleMint
        {
            get
            {
                return this._pSingleMint;
            }
            set
            {
                this._pSingleMint = value;
            }
        }
        
        public Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 PBatchMint
        {
            get
            {
                return this._pBatchMint;
            }
            set
            {
                this._pBatchMint = value;
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
            result.AddRange(MaxVariations.Encode());
            result.AddRange(MaxComponents.Encode());
            result.AddRange(Tiers.Encode());
            result.AddRange(PSingleMint.Encode());
            result.AddRange(PBatchMint.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT1();
            Name.Decode(byteArray, ref p);
            Description = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT2();
            Description.Decode(byteArray, ref p);
            EarlyStart = new Ajuna.NetApi.Model.Types.Primitive.U32();
            EarlyStart.Decode(byteArray, ref p);
            Start = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            End = new Ajuna.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            MaxVariations = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxVariations.Decode(byteArray, ref p);
            MaxComponents = new Ajuna.NetApi.Model.Types.Primitive.U8();
            MaxComponents.Decode(byteArray, ref p);
            Tiers = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT3();
            Tiers.Decode(byteArray, ref p);
            PSingleMint = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4();
            PSingleMint.Decode(byteArray, ref p);
            PBatchMint = new Bajun.Network.NET.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4();
            PBatchMint.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}