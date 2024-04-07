using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.Service
{
    public class FoodService : IFoodService
    {
        private readonly FoodDAO _foodDAO;
        public FoodService(FoodDAO foodDAO)
        {
            _foodDAO = foodDAO;
        }

        public async Task<Food> AddFood(AddFoodInput food)
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

            return await _foodDAO.AddFood(f);
        }
        public async Task<Food> UpdateFood(UpdateFoodInput food)
        {
            Food f = await GetFoodById(food.id);

            f.Name = food.name ?? f.Name;
            f.Description = food.description ?? f.Description;
            f.ImageUrl = food.imgUrl ?? f.ImageUrl;
            f.UnitPrice = food.unitPrice ?? f.UnitPrice;
            f.Quantity = food.quantity ?? f.Quantity;
            f.CreatedAt = food.createdAt ?? f.CreatedAt;
            f.FoodCategoryId = food.foodCategoryId ?? f.FoodCategoryId;

            _foodDAO.UpdateFood(f);
            return f;
        }

        public async Task<bool> CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food =  await GetFoodById(foodListInput[i].foodId);
                if(food.Quantity < foodListInput[i].quantity)
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<Food> GetFoodById(int id)
        {
            return await _foodDAO.GetFoodByFoodId(id);
        }

        public IQueryable<Food> GetFoods()
        {
            return _foodDAO.GetFoods();
        }

        public IQueryable<Food> GetFoodsByCategory(int categoryId)
        {
            return _foodDAO.GetFoodsByCategory(categoryId);
        }

        public async Task UpdateFoodQuantityWhenCreateOrder(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = await GetFoodById(foodListInput[i].foodId);
                await _foodDAO.UpdateFoodQuantity(foodListInput[i].foodId, food.Quantity - foodListInput[i].quantity);
            }
        }
    }
}
