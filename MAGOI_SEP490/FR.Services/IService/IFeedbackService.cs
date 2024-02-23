using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
    }
}
