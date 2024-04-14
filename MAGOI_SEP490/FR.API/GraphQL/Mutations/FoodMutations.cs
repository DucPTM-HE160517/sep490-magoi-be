using CloudinaryDotNet;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;

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
            return await foodService.AddFood(food);
        }

        public async Task<Food> EditFood(UpdateFoodInput food, IFoodService foodService)
        {
            return await foodService.UpdateFood(food);
        }
    }
}