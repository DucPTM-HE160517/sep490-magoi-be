﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        List<Feedback> GetFeedbacks();
        Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
        FeedbacksWithAverage GetFeedbacksWithAverage();
    }
}
