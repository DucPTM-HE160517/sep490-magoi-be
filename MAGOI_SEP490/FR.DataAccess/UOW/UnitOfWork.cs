using FR.BusinessObjects.DataContext;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;

namespace FR.DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        private IFeedbackDAO _feedbackDAO;
        public UnitOfWork(DBContext context)
        {
            _context = context;
        }
        public IFeedbackDAO Feedback  => _feedbackDAO ??= new FeedbackDAO(_context);
        public void Dispose() => _context.Dispose();

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
