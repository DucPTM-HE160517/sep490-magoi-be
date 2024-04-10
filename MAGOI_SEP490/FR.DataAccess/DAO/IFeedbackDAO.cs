using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IFeedbackDAO : IBaseDAO<Feedback>
    {
        Task<Feedback> GetFeedbackById(Guid feedbackId);
        Task<Feedback> GetFeedbackByBillId(Guid billId);
        Task<bool> IsExist(Guid billId);
        IQueryable<Feedback> GetFeedbacks(DateTime startDate, DateTime endDate);
    }
}
