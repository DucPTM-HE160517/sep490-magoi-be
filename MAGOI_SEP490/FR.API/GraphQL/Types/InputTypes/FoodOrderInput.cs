namespace FR.API.GraphQL.Types.InputTypes
{
    public record FoodOrderInput(int foodId, int quantity, string foodNote, DateTime orderedAt);
}
