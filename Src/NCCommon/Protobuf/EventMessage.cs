//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EventMessage.proto
// Note: requires additional types generated from: EventId.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventMessage")]
  public partial class EventMessage : global::ProtoBuf.IExtensible
  {
    public EventMessage() {}
    

    private Alachisoft.NCache.Common.Protobuf.EventId _event = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.EventId @event
    {
      get { return _event; }
      set { _event = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.EventMessage.EventType _eventType = Alachisoft.NCache.Common.Protobuf.EventMessage.EventType.ITEM_REMOVED_CALLBACK;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Alachisoft.NCache.Common.Protobuf.EventMessage.EventType.ITEM_REMOVED_CALLBACK)]
    public Alachisoft.NCache.Common.Protobuf.EventMessage.EventType eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }

    private string _key = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _callbackIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"callbackIds", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> callbackIds
    {
      get { return _callbackIds; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _dataFilters = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"dataFilters", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> dataFilters
    {
      get { return _dataFilters; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _queryIds = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(6, Name=@"queryIds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> queryIds
    {
      get { return _queryIds; }
    }
  

    private int _changeType = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"changeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int changeType
    {
      get { return _changeType; }
      set { _changeType = value; }
    }

    private int _flagMap = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"flagMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flagMap
    {
      get { return _flagMap; }
      set { _flagMap = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EventType")]
    public enum EventType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_REMOVED_CALLBACK", Value=1)]
      ITEM_REMOVED_CALLBACK = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_UPDATED_CALLBACK", Value=2)]
      ITEM_UPDATED_CALLBACK = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_ADDED_EVENT", Value=3)]
      ITEM_ADDED_EVENT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_REMOVED_EVENT", Value=4)]
      ITEM_REMOVED_EVENT = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_UPDATED_EVENT", Value=5)]
      ITEM_UPDATED_EVENT = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CACHE_CLEARED_EVENT", Value=6)]
      CACHE_CLEARED_EVENT = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CQ_CALLBACK", Value=7)]
      CQ_CALLBACK = 7
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}