using System.Threading;

public interface IDataTypeService{
    IDataType? TryGetByIdAsync(string id, CancellationToken cancellationToken);
    
    IDataType? TryGetByNameAsync(string id, CancellationToken cancellationToke);

    IDataType AddAsync(IDataType dataType, CancellationToken cancellationToken);
}