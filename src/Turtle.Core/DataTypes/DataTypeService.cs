using System.Threading;

public class DataTypeService : IDataTypeService
{
    public IDataType AddAsync(
        IDataType dataType, 
        CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }

    public IDataType? TryGetByIdAsync(
        string id,
        CancellationToken cancellationToken)
    {
        return PredefinedDataTypes.TryGetById(id);
    }

    public IDataType TryGetByNameAsync(
        string id,
        CancellationToken cancellationToke)
    {
        throw new System.NotImplementedException();
    }
}