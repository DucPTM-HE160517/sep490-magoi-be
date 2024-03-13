using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Services.GraphQL.InputTypes
{
    public record FoodInput(string name, string description, string imgUrl, float unitPrice, 
        int quantity, DateTime createdAt, int foodCategoryId);
}
