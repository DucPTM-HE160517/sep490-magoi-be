using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Payload
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
