using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using FR.DataAccess.UOW;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public partial class Service : IFoodService
    {
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
            await _uow.FoodDAO.AddAsync(f);
            await _uow.SaveAsync();
            _uow.Dispose();
            return f;
        }
        public async Task<Food> UpdateFood(UpdateFoodInput food)
        {
            Food f = await _uow.FoodDAO.GetFoodByFoodId(food.id);

            f.Name = food.name ?? f.Name;
            f.Description = food.description ?? f.Description;
            f.ImageUrl = food.imgUrl ?? f.ImageUrl;
            f.UnitPrice = food.unitPrice ?? f.UnitPrice;
            f.Quantity = food.quantity ?? f.Quantity;
            f.CreatedAt = food.createdAt ?? f.CreatedAt;
            f.FoodCategoryId = food.foodCategoryId ?? f.FoodCategoryId;

            _uow.FoodDAO.Update(f);
            await _uow.SaveAsync();
            _uow.Dispose();
            return f;
        }

        public async Task<bool> CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = await GetFoodById(foodListInput[i].foodId);
                if(food.Quantity < foodListInput[i].quantity)
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<Food> GetFoodById(int id)

        {
            return await _uow.FoodDAO.GetFoodByFoodId(id);
        }

        public async Task<IEnumerable<Food>> GetFoods()
        {
            return await _uow.FoodDAO.GetAllAsync();
        }

        public IQueryable<Food> GetFoodsByCategory(int categoryId)

        {
            return _uow.FoodDAO.GetFoodsByCategory(categoryId);
        }
    }
}
