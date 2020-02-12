using System;
using System.Globalization;

internal class PredefinedDataTypes{
    public static IDataType? TryGetById(string id){
        if (id.Equals("Number", StringComparison.InvariantCultureIgnoreCase))
        {
            return new DataType("Number", "Number", typeof(decimal), "Number");
        }
        else if (id.Equals("TrueFalse", StringComparison.InvariantCultureIgnoreCase))
        {
            return new DataType("TrueFalse", "True false", typeof(bool), "TrueFalse");
        }
        else if (id.Equals("SingleText", StringComparison.InvariantCultureIgnoreCase))
        {
            return new DataType("SingleText", "Single line Text ", typeof(decimal), "SingleText");
        }
        else if (id.Equals("ContentPicker", StringComparison.InvariantCultureIgnoreCase))
        {
            return new DataType("ContentPicker", "ContentPicker", typeof(string), "ContentPicker");
        }

        return null;
    }
}