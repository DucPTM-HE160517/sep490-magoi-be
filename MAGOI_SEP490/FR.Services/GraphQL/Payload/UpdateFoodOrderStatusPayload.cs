using FR.BusinessObjects.Models;

namespace FR.Services.GraphQL.Payload
{
    public class UpdateFoodOrderStatusPayload : Payload
    {
        public FoodOrder? Food { get; }
        public UpdateFoodOrderStatusPayload(FoodOrder food)
        {
            Food = food;
        }

        public UpdateFoodOrderStatusPayload(UserError error) : base(error) { }
    }
}
