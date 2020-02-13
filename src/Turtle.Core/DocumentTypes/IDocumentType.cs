using System.Collections.Generic;

public interface IDocumentType
{
    string Id { get; }

    string Name { get; }

    string? ParentDocumentTypeId { get; }

    string? DefaultTemplateId{ get; }

    IReadOnlyList<string> AllowedTemplateIds { get; }
}