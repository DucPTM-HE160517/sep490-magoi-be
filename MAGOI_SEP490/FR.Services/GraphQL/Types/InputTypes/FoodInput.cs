namespace FR.Services.GraphQL.Types.InputTypes
{
    public record AddFoodInput(string name, string description, string imgUrl, float unitPrice, 
        int quantity, DateTime createdAt, int foodCategoryId);
    public record UpdateFoodInput(int id, string? name, string? description, string? imgUrl, float? unitPrice,
        int? quantity, DateTime? createdAt, int? foodCategoryId);
}
