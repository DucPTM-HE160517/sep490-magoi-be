using FR.BusinessObjects.DataContext;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;

namespace FR.DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        private IBillDAO _billDAO;
        private IFeedbackDAO _feedbackDAO;
        private IFoodCategoryDAO _foodCategoryDAO;
        private IFoodDAO _foodDAO;
        private IFoodLabelsDAO _foodLabelsDAO;
        private IFoodOrderDAO _foodOrderDAO;
        private ILabelsDAO _labelsDAO;
        private IOrderDAO _orderDAO;
        private IOrderStatusDAO _orderStatusDAO;
        private IPaymentMethodDAO _paymentMethodDAO;
        private ISessionDAO _sessionDAO;
        private ITableDAO _tableDAO;
        private ITableStatusDAO _tableStatusDAO;
        public UnitOfWork(DBContext context)
        {
            _context = context;
        }
        public IBillDAO Bill => _billDAO ??= new BillDAO(_context);
        public IFeedbackDAO Feedback => _feedbackDAO ??= new FeedbackDAO(_context);
        public IFoodCategoryDAO FoodCategory => _foodCategoryDAO ??= new FoodCategoryDAO(_context);
        public IFoodDAO Food => _foodDAO ??= new FoodDAO(_context);
        public IFoodLabelsDAO FoodLabels => _foodLabelsDAO ??= new FoodLabelsDAO(_context);
        public IFoodOrderDAO FoodOrder => _foodOrderDAO ??= new FoodOrderDAO(_context);
        public ILabelsDAO Labels => _labelsDAO ??= new LabelsDAO(_context);
        public IOrderDAO Order => _orderDAO ??= new OrderDAO(_context);
        public IOrderStatusDAO OrderStatus => _orderStatusDAO ??= new OrderStatusDAO(_context);
        public IPaymentMethodDAO PaymentMethod => _paymentMethodDAO ??= new PaymentMethodDAO(_context);
        public ISessionDAO Session => _sessionDAO ??= new SessionDAO(_context);
        public ITableDAO Table => _tableDAO ??= new TableDAO(_context);
        public ITableStatusDAO TableStatus => _tableStatusDAO ??= new TableStatusDAO(_context);

        public void Dispose() => _context.Dispose();

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
