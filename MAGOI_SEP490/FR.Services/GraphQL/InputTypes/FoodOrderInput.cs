namespace FR.Services.GraphQL.InputTypes
{
    public record FoodOrderInput(int foodId, int quantity, string foodNote, DateTime orderedAt);
}
