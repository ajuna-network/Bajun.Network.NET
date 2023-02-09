//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bajun.Network.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Bajun.Network.NET.NetApiExt.Generated.Model.pallet_uniques.types;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IUniquesControllerMockupClient
   {
      Task<bool> SetClass(CollectionDetails value, U32 key);
      Task<bool> SetOwnershipAcceptance(U32 value, Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetAccount(BaseTuple value, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32, U32> key);
      Task<bool> SetClassAccount(BaseTuple value, BaseTuple<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32> key);
      Task<bool> SetAsset(ItemDetails value, BaseTuple<U32, U32> key);
      Task<bool> SetClassMetadataOf(CollectionMetadata value, U32 key);
      Task<bool> SetInstanceMetadataOf(ItemMetadata value, BaseTuple<U32, U32> key);
      Task<bool> SetAttribute(BaseTuple<BoundedVecT3, U128> value, BaseTuple<U32, BaseOpt<U32>, BoundedVecT2> key);
      Task<bool> SetItemPriceOf(BaseTuple<U128, BaseOpt<Bajun.Network.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> value, BaseTuple<U32, U32> key);
      Task<bool> SetCollectionMaxSupply(U32 value, U32 key);
   }
}
