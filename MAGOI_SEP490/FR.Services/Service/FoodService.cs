using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public class FoodService : IFoodService
    {
        private readonly IFoodDAO _foodDAO;
        private readonly IUnitOfWork _uow;
        public FoodService(IUnitOfWork uow)
        {
            _uow = uow;
            _foodDAO = ((UnitOfWork)uow).Food;
        }

        public async Task<Food> AddFoodAsync(AddFoodInput food)
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
            _foodDAO.AddAsync(f);
            return f;
        }
        public async Task<Food> UpdateFoodAsync(UpdateFoodInput food)
        {
            Food f = await _foodDAO.GetFoodByFoodId(food.id);

            f.Name = food.name ?? f.Name;
            f.Description = food.description ?? f.Description;
            f.ImageUrl = food.imgUrl ?? f.ImageUrl;
            f.UnitPrice = food.unitPrice ?? f.UnitPrice;
            f.Quantity = food.quantity ?? f.Quantity;
            f.CreatedAt = food.createdAt ?? f.CreatedAt;
            f.FoodCategoryId = food.foodCategoryId ?? f.FoodCategoryId;

            _foodDAO.Update(f);
            return f;
        }

        public async Task<bool> CheckFoodOrdersQuantityAsync(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = await _foodDAO.GetFoodByFoodId(foodListInput[i].foodId);
                if(food.Quantity < foodListInput[i].quantity)
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<Food> GetFoodByIdAsync(int id)

        {
            return await _foodDAO.GetFoodByFoodId(id);
        }

        public async Task<List<Food>> GetFoodsAsync()
        {
            return (List<Food>)await _foodDAO.GetAllAsync();
        }

        public async Task<List<Food>> GetFoodsByCategoryAsync(int categoryId)

        {
            return await _foodDAO.GetFoodsByCategory(categoryId).ToListAsync();
        }

        public async Task UpdateFoodQuantityWhenCreateOrderAsync(List<FoodOrderInput> foodListInput)
        {
            for (int i = 0; i < foodListInput.Count; i++)
            {
                Food food = await _foodDAO.GetFoodByFoodId(foodListInput[i].foodId);
                food.Quantity = food.Quantity - foodListInput[i].quantity;
                _foodDAO.Update(food);
            }
        }
    }
}
