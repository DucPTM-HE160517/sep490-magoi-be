namespace FR.Services.GraphQL.Types.InputTypes
{
    public sealed record AddFoodInput(string name, string description, string imgUrl, float unitPrice, 
        int quantity, DateTime createdAt, int foodCategoryId, bool isActive);
    public sealed record UpdateFoodInput(int id, string? name, string? description, string? imgUrl, float? unitPrice,
        int? quantity, DateTime? createdAt, int? foodCategoryId, bool? isActive);
}
