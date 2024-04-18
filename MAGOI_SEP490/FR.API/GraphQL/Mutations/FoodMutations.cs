using System.Text;
using CloudinaryDotNet;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Newtonsoft.Json;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<string> GetCloudinarySignedUrl(string timestamp, string? publicId, string? folder)
        {
            Cloudinary cloudinary = new Cloudinary(Environment.GetEnvironmentVariable("CLOUDINARY_URL"));
            SortedDictionary<string, object> parameters = new SortedDictionary<string, object>()
            {
                { "timestamp", timestamp },
            };

            if (publicId != null)
            {
                parameters.Add("public_id", publicId);
                parameters.Add("overwrite", "true");
            }

            if (folder != null)
            {
                parameters.Add("folder", folder);
            }

            string signature = cloudinary.Api.SignParameters(parameters);

            string signedUrl = $"timestamp={timestamp}&signature={signature}&api_key={cloudinary.Api.Account.ApiKey}";

            if (publicId != null)
            {
                signedUrl += $"&public_id={publicId}";
                signedUrl += $"&overwrite=true";
            }

            if (folder != null)
            {
                signedUrl += $"&folder={folder}";
            }

            return signedUrl;
        }

        public async Task<Food> AddFood(AddFoodInput food, IFoodService foodService)
        {
            return foodService.AddFood(food);
        }

        public async Task<Food> EditFood(UpdateFoodInput food,
            IFoodService foodService,
            ISessionService sessionService,
            IExpoNotificationService expoSdkClient)
        {
            Food f = foodService.GetFoodById(food.id);
            await Task.Run(() =>
            {
                //check new status and existing food order
                if (f is null)
                {
                    throw new Exception("Food not found!");
                }
                if (food.isActive is not null
                    && !(bool)food.isActive
                    && foodService.CheckFoodExistFoodOrder(food.id))
                {
                    throw new Exception("Can not deactivate this food because there are serving orders having it!");
                }
            });
            

            //get list of waiter devices
            List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");
            //send notification
            string msg = food.quantity == 0 ?
                $"{f.Name} đã hết hàng. Hãy chú ý thông báo tới khách hàng!"
                : $"{f.Name} đã được cập nhật số lượng thành {food.quantity} phần!";

            await expoSdkClient.SendNotification(waiterTokens, food.quantity == 0 ? $"Đã hết - {f.Name}" : $"Đã cập nhật - {f.Name}", msg,
                data: JsonConvert.SerializeObject(new
                {
                    type = food.quantity == 0 ? NotificationType.FoodOutOfStock : NotificationType.FoodAdded,
                }));

            return foodService.UpdateFood(food);
        }
    }
}