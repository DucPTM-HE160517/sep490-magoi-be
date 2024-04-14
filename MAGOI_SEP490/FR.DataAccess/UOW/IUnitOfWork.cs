using FR.DataAccess.DAO;

namespace FR.DataAccess.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        public IFeedbackDAO FeedbackDAO { get; }
        public IBillDAO BillDAO { get; }
        public IFoodCategoryDAO FoodCategoryDAO { get; }
        public IFoodDAO FoodDAO { get; }
        public IFoodLabelsDAO FoodLabelsDAO { get; }
        public IFoodOrderDAO FoodOrderDAO { get; }
        public ILabelsDAO LabelsDAO { get; }
        public IOrderDAO OrderDAO { get; }
        public IOrderStatusDAO OrderStatusDAO { get; }
        public IPaymentMethodDAO PaymentMethodDAO { get; }
        public ISessionDAO SessionDAO { get; }
        public ITableDAO TableDAO { get; }
        public ITableStatusDAO TableStatusDAO { get; }
    Task SaveAsync();
    }
}
