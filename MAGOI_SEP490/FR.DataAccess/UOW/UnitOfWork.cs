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
        private bool _disposed;
        public UnitOfWork(DBContext context)
        {
            _context = context;
        }
        public IBillDAO BillDAO => _billDAO ??= new BillDAO(_context);
        public IFeedbackDAO FeedbackDAO => _feedbackDAO ??= new FeedbackDAO(_context);
        public IFoodCategoryDAO FoodCategoryDAO => _foodCategoryDAO ??= new FoodCategoryDAO(_context);
        public IFoodDAO FoodDAO => _foodDAO ??= new FoodDAO(_context);
        public IFoodLabelsDAO FoodLabelsDAO => _foodLabelsDAO ??= new FoodLabelsDAO(_context);
        public IFoodOrderDAO FoodOrderDAO => _foodOrderDAO ??= new FoodOrderDAO(_context);
        public ILabelsDAO LabelsDAO => _labelsDAO ??= new LabelsDAO(_context);
        public IOrderDAO OrderDAO => _orderDAO ??= new OrderDAO(_context);
        public IOrderStatusDAO OrderStatusDAO => _orderStatusDAO ??= new OrderStatusDAO(_context);
        public IPaymentMethodDAO PaymentMethodDAO => _paymentMethodDAO ??= new PaymentMethodDAO(_context);
        public ISessionDAO SessionDAO => _sessionDAO ??= new SessionDAO(_context);
        public ITableDAO TableDAO => _tableDAO ??= new TableDAO(_context);
        public ITableStatusDAO TableStatusDAO => _tableStatusDAO ??= new TableStatusDAO(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
