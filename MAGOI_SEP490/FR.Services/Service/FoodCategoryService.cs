using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using System.Collections.Generic;

namespace FR.Services.Service
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly FoodCategoryDAO _dao;
        public FoodCategoryService(FoodCategoryDAO dao)
        {
            _dao = dao;
        }

        public List<FoodCategory> GetFoodCategories()
        {
            return _dao.GetFoodCategories();
        }

        public FoodCategory GetFoodCategoryById(int id)
        {
            return _dao.GetFoodCategoryById(id);
        }

        public List<FoodOrderCategory> GetFoodOrderCategories()
        {
            List<FoodOrderCategory> foodOrderCategories = new List<FoodOrderCategory>();

            //Get list of FoodOrder has cooking status
            List<FoodOrder> foodOrders = _dao.GetFoodOrder().Where(f => f.FoodOrderStatusId == 2).ToList();

            //Access to each item of foodOrders list to group in category
            foreach (FoodOrder foodOrder in foodOrders)
            {
                //Get FoodCategory by FoodId of this accessed FoodOrder
                FoodCategory foodCategory = GetFoodCategoryByFoodId(foodOrder.FoodId);

                //Add FoodOrderCategory to list
                if(foodOrderCategories.Count == 0)
                {
                    FoodOrderCategory foodOrderCategory = new FoodOrderCategory()
                    {
                        Id = foodCategory.Id,
                        Name = foodCategory.Category,
                        FoodOrders = new List<FoodOrder>()
                    };
                    foodOrderCategory.FoodOrders.Add(foodOrder);
                    foodOrderCategories.Add(foodOrderCategory);
                }
                else
                {
                    //Find Category in list
                    FoodOrderCategory foodOrderCategoryExisted = foodOrderCategories.Where(f => f.Id == foodCategory.Id).FirstOrDefault();

                    //Weather category existed, add foodOrder; else add category
                    if(foodOrderCategoryExisted != null)
                    {
                        //Weather FoodOrder existed in Category add quantity, else add FoodOrder
                        FoodOrder fo = foodOrderCategoryExisted.FoodOrders.Where(f => f.FoodId == foodOrder.FoodId).FirstOrDefault();
                        if (fo != null)
                        {
                            fo.Quantity += foodOrder.Quantity;
                        }
                        else
                        {
                            foodOrderCategoryExisted.FoodOrders.Add(foodOrder);
                        }                        
                    }
                    else
                    {
                        FoodOrderCategory foodOrderCategory = new FoodOrderCategory()
                        {
                            Id = foodCategory.Id,
                            Name = foodCategory.Category,
                            FoodOrders = new List<FoodOrder>()
                        };
                        foodOrderCategory.FoodOrders.Add(foodOrder);

                        //Sort Category By CategoryId
                        if (foodOrderCategory.Id < foodOrderCategories[0].Id)
                        {
                            foodOrderCategories.Insert(0, foodOrderCategory);                           
                        }
                        else
                        {
                            foodOrderCategories.Add(foodOrderCategory);
                        }
                        
                    }                    
                }
                
            }
            return foodOrderCategories;
        }
        public FoodCategory GetFoodCategoryByFoodId(int foodId)
        {
            FoodCategory foodCategory = new FoodCategory();
            Food food = _dao.GetFoods().Where(f => f.Id == foodId).FirstOrDefault();
            if (food != null)
            {
                foodCategory = _dao.GetFoodCategoryById(food.FoodCategoryId);
            }
            return foodCategory;
        }
    }
}
