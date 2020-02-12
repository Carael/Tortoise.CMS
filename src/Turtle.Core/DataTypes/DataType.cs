using System;

public class DataType : IDataType
{
    public DataType(string id, string name, Type valueType, string editorId)
    {
        Id = id;
        Name = name;
        ValueType = valueType;
        EditorId = editorId;
    }

    public string Id { get; }

    public string Name { get; }

    public Type ValueType { get; }

    public string EditorId { get; }
}