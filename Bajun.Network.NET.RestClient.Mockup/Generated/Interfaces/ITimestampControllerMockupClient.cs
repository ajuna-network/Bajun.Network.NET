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
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ITimestampControllerMockupClient
   {
      Task<bool> SetNow(U64 value);
      Task<bool> SetDidUpdate(Bool value);
   }
}
