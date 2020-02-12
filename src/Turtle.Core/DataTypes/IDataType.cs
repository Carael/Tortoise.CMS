using System;

public interface IDataType{
    string Id { get; }
    
    string Name { get; }

    Type ValueType { get; }

    string EditorId { get; }
}