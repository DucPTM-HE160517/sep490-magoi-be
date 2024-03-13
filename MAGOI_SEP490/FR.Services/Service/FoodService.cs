using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.InputTypes;

namespace FR.Services.Service
{
    public class FoodService : IFoodService
    {
        private readonly FoodDAO _foodDAO;
        public FoodService(FoodDAO foodDAO)
        {
            _foodDAO = foodDAO;
        }

        public Food AddFood(FoodInput food)
        {
            Food f = new Food()
            {
                Name = food.name,
                Description = food.description,
                ImageUrl = food.imgUrl,
                UnitPrice = food.unitPrice,
                Quantity = food.quantity,
                CreatedAt = food.createdAt,
                FoodCategoryId = food.foodCategoryId
            };
            _foodDAO.AddFood(f);
            return f;
        }

        public bool CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = GetFoodById(foodListInput[i].foodId);
                if(food.Quantity < foodListInput[i].quantity)
                {
                    return false;
                }
            }
            return true;
        }

        public Food GetFoodById(int id)
        {
            return _foodDAO.GetFoodByFoodId(id);
        }

        public List<Food> GetFoods()
        {
            return _foodDAO.GetFoods();
        }

        public List<Food> GetFoodsByCategory(int categoryId)
        {
            return _foodDAO.GetFoodsByCategory(categoryId);
        }

        public void UpdateFoodQuantityWhenCreateOrder(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = GetFoodById(foodListInput[i].foodId);
                _foodDAO.UpdateFoodQuantity(foodListInput[i].foodId, food.Quantity - foodListInput[i].quantity);
            }
        }
    }
}
