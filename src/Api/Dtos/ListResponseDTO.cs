public record ListResponseDTO(
    string Id,
    string Name,
    string Description,
    List<ItemListResponseDTO>? Itens,
    string CreatedAt
);